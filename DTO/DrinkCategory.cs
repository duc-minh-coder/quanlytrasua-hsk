using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DrinkCategory
    {
        private int _idCategory;

        public int idCategory
        {
            get { return _idCategory; }
            set { _idCategory = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DrinkCategory()
        {

        }

        public DrinkCategory(int idDrink, string Name, int Price, int idCategory)
        {
            this._idCategory = idCategory;
            this._Name = Name;
        }

        public DrinkCategory(DataRow r)
        {
            this._idCategory = (int)r["idCategory"];
            this._Name = r["Name"].ToString();
        }
    }
}
