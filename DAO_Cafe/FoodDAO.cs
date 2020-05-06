/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 2/27/2020
 * Time: 2:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using DTO_Cafe;
namespace DAO_Cafe
{
	/// <summary>
	/// Description of FoodDAO.
	/// </summary>
	public class FoodDAO
	{
		private static FoodDAO instance;
		public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
           private set { FoodDAO.instance = value; }
        }
		private FoodDAO()
		{
		}
        public DataTable getFoodByCate(int id = 0)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC dbo.getFoodByCate @id", id.ToString());
        }

        public Food getFoodbyId(int id = 0)
        {
            Food fd = new Food();
            DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC dbo.getFoodById @id", id.ToString());
            fd.ID =(int) dt.Rows[0]["id"];
            fd.Name = dt.Rows[0]["name"].ToString() ;
            fd.IdCategory = (int)dt.Rows[0]["idCategory"];
            fd.Price = (Decimal)dt.Rows[0]["price"];
            return fd;
        }
        public int update(string name, int idCategory, decimal price, int id)
        {
            string query = String.Format("update Food set name=N'{0}', idCategory={1}, price={2} where id={3}", name, idCategory, price, id);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int insert(string name, int idCategory, decimal price)
        {
            string query = String.Format("insert into Food(name, idCategory, price) values(N'{0}', {1}, {2})", name, idCategory, price);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int delete(int id)
        {
            string query = String.Format("delete from Food where id={0}", id.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
	}
}
