using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PhieuNhapDAL
    {
        public DataTable GetPhieuNhapSummary()
        {
            string query = @"SELECT pn.MaPhieuNhap,
                                    pn.NgayNhap,
                                    pn.MaNhanVien,
                                    a.Realname AS TenNhanVien,
                                    COUNT(ct.MaNguyenLieu) AS SoLoaiNguyenLieu,
                                    ISNULL(SUM(ct.SoLuongNhap * ct.DonGiaNhap), 0) AS TongTien
                             FROM PhieuNhap pn
                             LEFT JOIN ChiTietPhieuNhap ct ON pn.MaPhieuNhap = ct.MaPhieuNhap
                             LEFT JOIN Account a ON pn.MaNhanVien = a.Username
                             GROUP BY pn.MaPhieuNhap, pn.NgayNhap, pn.MaNhanVien, a.Realname
                             ORDER BY pn.MaPhieuNhap DESC";
            DBConnect db = new DBConnect();
            return db.ExecuteQuery(query);
        }

        public bool SavePhieuNhap(DateTime ngayNhap, string maNhanVien, List<ChiTietPhieuNhap> chiTietPhieuNhap)
        {
            if (chiTietPhieuNhap == null || chiTietPhieuNhap.Count == 0)
            {
                return false;
            }

            using (SqlConnection connection = new SqlConnection(DBConnect.DefaultConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    int maPhieuNhap = InsertPhieuNhap(connection, transaction, ngayNhap, maNhanVien);

                    foreach (ChiTietPhieuNhap chiTiet in chiTietPhieuNhap)
                    {
                        InsertChiTietPhieuNhap(connection, transaction, maPhieuNhap, chiTiet.MaNguyenLieu, chiTiet.SoLuongNhap, chiTiet.DonGiaNhap);
                        UpdateStock(connection, transaction, chiTiet.MaNguyenLieu, chiTiet.SoLuongNhap);
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                    }

                    return false;
                }
            }
        }

        private int InsertPhieuNhap(SqlConnection connection, SqlTransaction transaction, DateTime ngayNhap, string maNhanVien)
        {
            string query = "INSERT INTO PhieuNhap(NgayNhap, MaNhanVien) VALUES(@NgayNhap, @MaNhanVien); SELECT CAST(SCOPE_IDENTITY() AS INT)";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void InsertChiTietPhieuNhap(SqlConnection connection, SqlTransaction transaction, int maPhieuNhap, int maNguyenLieu, int soLuongNhap, decimal donGiaNhap)
        {
            string query = "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaNguyenLieu, SoLuongNhap, DonGiaNhap) VALUES(@MaPhieuNhap, @MaNguyenLieu, @SoLuongNhap, @DonGiaNhap)";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
                command.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateStock(SqlConnection connection, SqlTransaction transaction, int maNguyenLieu, int soLuongNhap)
        {
            string query = "UPDATE NguyenLieu SET SoLuongTon = SoLuongTon + @SoLuongNhap WHERE MaNguyenLieu = @MaNguyenLieu";
            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
                command.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
                command.ExecuteNonQuery();
            }
        }
    }
}