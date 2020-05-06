/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/5/2020
 * Time: 9:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using DAO_Cafe;
using DTO_Cafe;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of AccountBUS.
	/// </summary>
	public class AccountBUS
	{
		public AccountBUS()
		{
		}
		public DataTable getAccount(){
			return AccountDAO.Instance.getAccount();
		}
        public Account getAccountLogin(string userName, string password)
        {
            return AccountDAO.Instance.getAccountLogin(userName, password);
        }
		  public int insert(string DisplayName, string UserName, string Password, int Type)
		  {
		  	return AccountDAO.Instance.insert(DisplayName,UserName, Password,Type);
		  }
          public int update(string DisplayName, string UserName, string Password, int Type, int id)
          {
              return AccountDAO.Instance.update(DisplayName, UserName, Password, Type, id);
          }
	}
}
