using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DrinkCategoryDAL
    {
        public List<DrinkCategory> GetDrinkCategories()
        {
            List<DrinkCategory> list = new List<DrinkCategory>();
            string query = "SELECT * FROM DrinkCategory";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DrinkCategory(row));
            }
            return list;
        }
    }
}
