/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/5/2020
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DAO_Cafe;
using DTO_Cafe;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of TableBUS.
	/// </summary>
	public class TableBUS
	{
		public TableBUS()
		{
		}
		public int update(int id, string name, string status){
			Table table=new Table(id,name,status);
			return TableDAO.Instance.update(table);
		}
	}
}
