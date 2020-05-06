using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Cafe
{
    public  class BillInfo
    {
        private int iD, idBill, idFood, count1;

        public int Count1
        {
            get { return count1; }
            set { count1 = value; }
        }

        public int IdFood
        {
            get { return idFood; }
            set { idFood = value; }
        }

        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
