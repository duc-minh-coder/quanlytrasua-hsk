using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class NguyenLieuDAL
    {
        public DataTable GetAllNguyenLieu()
        {
            string query = "SELECT MaNguyenLieu, TenNguyenLieu, DonViTinh, SoLuongTon FROM NguyenLieu ORDER BY TenNguyenLieu";
            DBConnect db = new DBConnect();
            return db.ExecuteQuery(query);
        }

        public List<NguyenLieu> GetNguyenLieuList()
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            DataTable dt = GetAllNguyenLieu();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new NguyenLieu(row));
            }
            return list;
        }

        public bool InsertNguyenLieu(string tenNguyenLieu, string donViTinh, int soLuongTon)
        {
            string query = "INSERT INTO NguyenLieu(TenNguyenLieu, DonViTinh, SoLuongTon) VALUES(@TenNguyenLieu, @DonViTinh, @SoLuongTon)";
            object[] value = new object[] { tenNguyenLieu, donViTinh, soLuongTon };
            DBConnect db = new DBConnect();
            return db.ExecuteNonQuery(query, value) > 0;
        }

        public bool UpdateNguyenLieu(int maNguyenLieu, string tenNguyenLieu, string donViTinh, int soLuongTon)
        {
            string query = "UPDATE NguyenLieu SET TenNguyenLieu = @TenNguyenLieu, DonViTinh = @DonViTinh, SoLuongTon = @SoLuongTon WHERE MaNguyenLieu = @MaNguyenLieu";
            object[] value = new object[] { tenNguyenLieu, donViTinh, soLuongTon, maNguyenLieu };
            DBConnect db = new DBConnect();
            return db.ExecuteNonQuery(query, value) > 0;
        }

        public bool DeleteNguyenLieu(int maNguyenLieu)
        {
            string query = "DELETE FROM NguyenLieu WHERE MaNguyenLieu = @MaNguyenLieu";
            object[] value = new object[] { maNguyenLieu };
            DBConnect db = new DBConnect();
            return db.ExecuteNonQuery(query, value) > 0;
        }

        public DataTable GetNguyenLieuDetailed()
        {
            return GetAllNguyenLieu();
        }
    }
}