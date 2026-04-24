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
    public class DrinkCategoryBUS
    {
        DrinkCategoryDAL drinkCategoryDAL = new DrinkCategoryDAL();
        public List<DrinkCategory> GetDrinkCategories()
        {
            return drinkCategoryDAL.GetDrinkCategories();
        }
    }
}
