using System;
using System.Data;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaNguyenLieu { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }

        public ChiTietPhieuNhap()
        {
        }

        public ChiTietPhieuNhap(int maPhieuNhap, int maNguyenLieu, int soLuongNhap, decimal donGiaNhap)
        {
            MaPhieuNhap = maPhieuNhap;
            MaNguyenLieu = maNguyenLieu;
            SoLuongNhap = soLuongNhap;
            DonGiaNhap = donGiaNhap;
        }

        public ChiTietPhieuNhap(DataRow row)
        {
            MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]);
            MaNguyenLieu = Convert.ToInt32(row["MaNguyenLieu"]);
            SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);
            DonGiaNhap = Convert.ToDecimal(row["DonGiaNhap"]);
        }
    }
}