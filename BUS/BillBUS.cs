using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BillBUS
    {
        BillDAL billDAL = new BillDAL();
        public object insertBill(string date, int price)
        {
            try
            {
                return billDAL.insertBill(date, price);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool insertBillInfo(int idDrink, int quantity)
        {
            try
            {
                if (billDAL.insertBillInfo(idDrink, quantity))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable getReportByDate(int day, int month, int year)
        {
            return billDAL.reportByDate(day, month, year);
        }

        public DataTable getReportByMonth(int month)
        {
            try
            {
                return billDAL.reportByMonth(month);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
