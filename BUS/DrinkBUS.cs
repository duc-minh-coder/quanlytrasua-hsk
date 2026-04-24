using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DrinkBUS
    {
        DrinkDAL drinkDAL = new DrinkDAL();
        public List<Drink> GetDrinkList()
        {
            List<Drink> listDrink = new List<Drink>();
            DataTable dt = drinkDAL.GetAllDrinks();
            foreach (DataRow row in dt.Rows)
            {
                Drink drink = new Drink(row);
                listDrink.Add(drink);
            }
            return listDrink;
        }
        public DataTable GetAllDrinksDetailed()
        {
            return drinkDAL.GetAllDrinksDetailed();
        }

        public bool InsertDrink(string name, string price, int idCategory)
        {
            return drinkDAL.InsertDrink(name, price, idCategory);
        }

        public bool DeleteDrink(int idDrink)
        {
            return drinkDAL.DeleteDrink(idDrink);
        }

        public bool UpdateDrink(int idDrink, string name, string price, int idCategory)
        {
            return drinkDAL.UpdateDrink(idDrink, name, price, idCategory);
        }
    }
}
