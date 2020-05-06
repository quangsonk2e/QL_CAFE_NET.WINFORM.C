using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO_Cafe
{
  public class Table
    {
      public Table(int id, string name, string status)
      {
          this.iD = id;
          this.name = name;
          this.status = status;
      }
      public Table(DataRow row)
      {
          this.iD =(int) row["id"];
          this.Name = row["name"].ToString();
          this.Status = row["status"].ToString();
      }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name, status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
