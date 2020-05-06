using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Cafe
{
    public  class Food
    {
        private int iD, idCategory;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
