using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product : OrderDetails
    {
        public int ID;
        public string Name;
        public string Brand;
        public float BasePrice;
        public float Discount;
        public string Description;

        public bool FilterProducts()
        {
            return true;
        }
        public string SearchProducts()
        {
            return "";
        }
    }
    public class Category : Product
    {
        public int ID;
        public string Name;
        public string Description;

    }
}
