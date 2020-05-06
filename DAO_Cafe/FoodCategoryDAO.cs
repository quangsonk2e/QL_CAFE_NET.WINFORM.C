/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 2/27/2020
 * Time: 2:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace DAO_Cafe
{
	/// <summary>
	/// Description of FoodCategoryDAO.
	/// </summary>
	public class FoodCategoryDAO
	{
		private static FoodCategoryDAO instance;
		public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
           private set { FoodCategoryDAO.instance = value; }
        }
		private FoodCategoryDAO()
		{
		}
		public DataTable getFoodCategory(){
			
			return DataProvider.Instance.ExecuteQuery("getFoodCategory");
		}
		public int update(string name)
        {
            string query = String.Format("update from FoodCategory set name=N'{0}'", name);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int insert(string name)
        {
            string query = String.Format("insert into FoodCategory(name) values(N'{0}')", name);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int delete(int id)
        {
            string query = String.Format("delete from FoodCategory where id={0}", id.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
	}
}
