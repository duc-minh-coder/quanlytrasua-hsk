using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class NguyenLieuBUS
    {
        private readonly NguyenLieuDAL nguyenLieuDAL = new NguyenLieuDAL();

        public List<NguyenLieu> GetNguyenLieuList()
        {
            return nguyenLieuDAL.GetNguyenLieuList();
        }

        public DataTable GetNguyenLieuDetailed()
        {
            return nguyenLieuDAL.GetNguyenLieuDetailed();
        }

        public bool InsertNguyenLieu(string tenNguyenLieu, string donViTinh, int soLuongTon)
        {
            return nguyenLieuDAL.InsertNguyenLieu(tenNguyenLieu, donViTinh, soLuongTon);
        }

        public bool UpdateNguyenLieu(int maNguyenLieu, string tenNguyenLieu, string donViTinh, int soLuongTon)
        {
            return nguyenLieuDAL.UpdateNguyenLieu(maNguyenLieu, tenNguyenLieu, donViTinh, soLuongTon);
        }

        public bool DeleteNguyenLieu(int maNguyenLieu)
        {
            return nguyenLieuDAL.DeleteNguyenLieu(maNguyenLieu);
        }
    }
}