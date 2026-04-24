using System;
using System.Data;

namespace DTO
{
    public class PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNhanVien { get; set; }

        public PhieuNhap()
        {
        }

        public PhieuNhap(int maPhieuNhap, DateTime ngayNhap, string maNhanVien)
        {
            MaPhieuNhap = maPhieuNhap;
            NgayNhap = ngayNhap;
            MaNhanVien = maNhanVien;
        }

        public PhieuNhap(DataRow row)
        {
            MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]);
            NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
            MaNhanVien = row["MaNhanVien"].ToString();
        }
    }
}