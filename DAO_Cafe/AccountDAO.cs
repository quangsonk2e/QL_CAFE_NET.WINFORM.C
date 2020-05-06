using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO_Cafe;
using System.Security.Cryptography;

namespace DAO_Cafe
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
           private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public bool login(string username, string pwd)
        {
           // string query = "";
            //int result=DataProvider.Instance.
            return false;
        }
       
         public Account getAccountLogin(string userName, string password)
         {
             string query = string.Format("select * from Account where UserName='{0}' and Password='{1}'",userName,password);

             DataTable dt= DataProvider.Instance.ExecuteQuery(query);
             if (dt.Rows.Count > 0)
             {
                 Account account = new Account();
                 account.ID = (int)dt.Rows[0]["id"];
                 account.DisplayName = dt.Rows[0]["DisplayName"].ToString();
                 account.UserName = dt.Rows[0]["DisplayName"].ToString();
                 account.Password = dt.Rows[0]["Password"].ToString();
                 return account;
             }
             return null;
         }
         public DataTable getAccount()
         {
             string query = "select * from Account";

             return DataProvider.Instance.ExecuteQuery(query);
         }
         public int update(string DisplayName, string UserName, string Password, int Type, int id)
         {
             
             string query = String.Format("update Account set DisplayName=N'{0}', UserName='{1}', Password='{2}', Type={3} where id={4}", DisplayName, UserName, mahoa(Password), Type.ToString(), id);
             if(string.IsNullOrEmpty(Password))
                 query = String.Format("update Account set DisplayName=N'{0}', UserName='{1}', Type={2} where id={3}", DisplayName, UserName, Type.ToString(), id);
             return DataProvider.Instance.ExecuteNonQuery(query);
         }
        public int insert(string DisplayName, string UserName, string Password, int Type)
        {
            string query = String.Format("insert into Account(DisplayName, UserName, Password, Type) values (N'{0}', N'{1}', N'{2}', {3})", DisplayName,UserName,Password, Type.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int delete(int id)
        {
            string query = String.Format("delete from Account where id={0}", id.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public string mahoa(string chuoi)
        {
            MD5 mh = MD5.Create();
            byte[] mahoa = Encoding.ASCII.GetBytes(chuoi);
            byte[] hash = mh.ComputeHash(mahoa);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            return sb.ToString();
        }
     }
}
