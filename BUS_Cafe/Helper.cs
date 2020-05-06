/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/4/2020
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of Helper.
	/// </summary>
	public class Helper
	{
		private static Helper instance;
		 public static Helper Instance
        {
            get { if (instance == null) instance = new Helper(); return Helper.instance; }
           private set { Helper.instance = value; }
        }

		public Helper()
		{
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
        public string convertDate(string date){
        	string day=date.Substring(0,2);
        	string month=date.Substring(3,2);
        	string year=date.Substring(6,4);
        	return year+"-"+month+"-"+day;
        }
		
	}
}
