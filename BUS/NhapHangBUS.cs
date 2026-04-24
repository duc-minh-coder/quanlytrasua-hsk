using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class NhapHangBUS
    {
        private readonly PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();

        public DataTable GetPhieuNhapSummary()
        {
            return phieuNhapDAL.GetPhieuNhapSummary();
        }

        public bool SavePhieuNhap(DateTime ngayNhap, string maNhanVien, List<ChiTietPhieuNhap> chiTietPhieuNhap)
        {
            try
            {
                return phieuNhapDAL.SavePhieuNhap(ngayNhap, maNhanVien, chiTietPhieuNhap);
            }
            catch
            {
                return false;
            }
        }
    }
}