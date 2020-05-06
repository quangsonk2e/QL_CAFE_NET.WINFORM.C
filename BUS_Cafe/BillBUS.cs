/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/5/2020
 * Time: 10:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DAO_Cafe;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of BillBUS.
	/// </summary>
	public class BillBUS
	{
		public BillBUS()
		{
		}
		public int update(DateTime DateCheckIn, DateTime DateCheckOut, int idTable, int status, int id)
       {
			return BillDAO.Instance.update(DateCheckIn, DateCheckOut, idTable, status, id);
		}
        public int updateStatus(int status, int id)
        {
            return BillDAO.Instance.updateStatus(status, id);
        }
	}
}
