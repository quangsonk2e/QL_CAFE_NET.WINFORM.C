/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 2/27/2020
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DAO_Cafe;
using DTO_Cafe;
using System.Data;
namespace BUS_Cafe
{
	/// <summary>
	/// Description of FoodCategoryBUS.
	/// </summary>
	public class FoodCategoryBUS
	{
		public FoodCategoryBUS()
		{
		}
		public DataTable getFoodCategory(){
			
			return FoodCategoryDAO.Instance.getFoodCategory();
		}
		public int update(string name)
        {
            
			return FoodCategoryDAO.Instance.update(name);
        }
        public int insert(string name)
        {
        	return FoodCategoryDAO.Instance.insert(name);;
        }
        public int delete(int id)
        {
        	return FoodCategoryDAO.Instance.delete(id);
        }
	}
}
