using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO_Cafe;


namespace DAO_Cafe
{
   public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
           private set { BillDAO.instance = value; }
        }

       private BillDAO() { }
       public int GetUncheckBillIDByTableID(int id)
       {
           DataTable data = DataProvider.Instance.ExecuteQuery("select * from bill where idTable= " + id + " and status= 1");

           if (data.Rows.Count > 0)
           {
               Bill bill = new Bill(data.Rows[0]);
               return bill.ID;
           }
               return -1;
       }
        public int update(DateTime DateCheckIn, DateTime DateCheckOut, int idTable, int status, int id)
       {
           string query = String.Format("update Bill set DateCheackIn='{0}', DateCheckOut='{1}', idTable={2}, status={3} where id={4}", DateCheckIn.ToString("MM-dd-yyyy"), DateCheckOut.ToString("MM-dd-yyyy"), idTable, status, id);
           return (int)DataProvider.Instance.ExecuteNonQuery(query);
       }
        public int updateStatus(int status, int id)
        {
            string query = String.Format("update Bill set status={0} where id={1}", status, id);
            return (int)DataProvider.Instance.ExecuteNonQuery(query);
        }
       public int insert(DateTime DateCheckIn, DateTime DateCheckOut, int idTable, int status)
       {
           string query = String.Format("insert into Bill(DateCheackIn, DateCheckOut, idTable, status) values('{0}', '{1}', {2}, {3}); SELECT  SCOPE_IDENTITY()", DateCheckIn.ToString("MM-dd-yyyy"), DateCheckOut.ToString("MM-dd-yyyy"), idTable.ToString(), status.ToString());
           return (int)DataProvider.Instance.ExecuteScalar(query);
       }
       public int delete(int id)
       {
           string query = String.Format("delete from Bill where id={0}", id.ToString());
           return DataProvider.Instance.ExecuteNonQuery(query);
       }
       
       
    }
}
