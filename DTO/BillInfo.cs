using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class BillInfo
    {
        private int _idBill;

        public int idBill
        {
            get { return _idBill; }
            set { _idBill = value; }
        }

        private int _idDrink;

        public int idDrink
        {
            get { return _idDrink; }
            set { _idDrink = value; }
        }

        private int _Quantity;

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public BillInfo()
        { }

        public BillInfo(int idBill, int idDrink, int Quantity)
        {
            this._idBill = idBill;
            this._idDrink = idDrink;
            this._Quantity = Quantity;
        }

        public BillInfo(DataRow r)
        {
            this._idBill = (int)r["idBill"];
            this._idDrink = (int)r["idDrink"];
            this._Quantity = (int)r["Quantity"];
        }
    }
}
