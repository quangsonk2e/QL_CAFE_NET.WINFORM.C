using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO_Cafe
{
    public class Bill
    {
        private int iD, idTable, status;
        public Bill(int id, DateTime dateCheckin, DateTime dateCheckOut, int status)
        {
            this.iD = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = row["DateCheackin"] == null ? DateTime.Now : (DateTime)row["DateCheackin"];
            this.DateCheckOut =row["DateCheckOut"] == null ? DateTime.Now : (DateTime)row["DateCheckOut"];
            this.IdTable = (int)row["idTable"];
            this.Status = (int)row["status"];

        }
        public int IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private DateTime dateCheckIn, dateCheckOut;

        public DateTime DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public DateTime DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }
    }
}
