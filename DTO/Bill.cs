using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Bill
    {
        private int _idBill;

        public int idBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private string _Date;

        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private int _TotalPrice;

        public int TotalPrice
        {
            get { return _TotalPrice; }
            set { _TotalPrice = value; }
        }

        private int _idTable;

        public int idTable
        {
            get { return _idTable; }
            set { _idTable = value; }
        }
        public Bill()
        { }

        public Bill(int idBill, string Date, int TotalPrice, int idTable)
        {
            this._idBill = idBill;
            this._Date = Date;
            this._TotalPrice = TotalPrice;
            this._idTable = idTable;
        }

        public Bill(DataRow r)
        {
            this._idBill = (int)r["idBill"];
            this._Date = r["Date"].ToString();
            this._TotalPrice = (int)r["TotalPrice"];
            this._idTable = (int)r["idTable"];
        }
    }
}
