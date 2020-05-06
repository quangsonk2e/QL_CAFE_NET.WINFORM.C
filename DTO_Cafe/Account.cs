using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_Cafe
{
    public  class Account
    {
        private int iD, type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string displayName, userName, password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
    }
}
