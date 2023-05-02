using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Order : Customer
    {
        private int ID;
        public string Date;
        public string Status;
        public int CustomerID;
        public bool Place()
        {
            return true;
        }
    }

    public class OrderDetails : Order
    {
        private int OrderID;
        public int ProductID;
        public string ProductName;
        public string Quantity;
        private int CustomerID;
        public float Cost;
        public float Subtotal;
    }

}
