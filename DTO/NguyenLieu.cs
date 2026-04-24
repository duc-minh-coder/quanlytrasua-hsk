using System;
using System.Data;

namespace DTO
{
    public class NguyenLieu
    {
        public int MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongTon { get; set; }

        public NguyenLieu()
        {
        }

        public NguyenLieu(int maNguyenLieu, string tenNguyenLieu, string donViTinh, int soLuongTon)
        {
            MaNguyenLieu = maNguyenLieu;
            TenNguyenLieu = tenNguyenLieu;
            DonViTinh = donViTinh;
            SoLuongTon = soLuongTon;
        }

        public NguyenLieu(DataRow row)
        {
            MaNguyenLieu = Convert.ToInt32(row["MaNguyenLieu"]);
            TenNguyenLieu = row["TenNguyenLieu"].ToString();
            DonViTinh = row["DonViTinh"].ToString();
            SoLuongTon = Convert.ToInt32(row["SoLuongTon"]);
        }
    }
}