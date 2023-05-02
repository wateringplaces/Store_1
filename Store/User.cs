using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class User
    {
        private string UserID;
        private string Password;
        public string LoginStatus;
        private bool VerifyLogin()
        {
            return true;
        }

    }

    public abstract class Customer : User
    {
        public string name;
        public string surname;
        private string DNI;
        private string Address;
        private string Email;
        private int PhoneNumber;
    }

    public abstract class ShoppingCart : Customer
    {
        public int ID;
        public int ProductID;
        public int Quantity;
        public float Subtotal;

        public bool Update()
        {
            return true;
        }
        public string Checkout()
        {
            return "";
        }
    }
}

