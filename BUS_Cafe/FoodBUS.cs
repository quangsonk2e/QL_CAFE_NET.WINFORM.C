/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 2/27/2020
 * Time: 3:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using DAO_Cafe;
using System.Data;
using DTO_Cafe;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of FoodBUS.
	/// </summary>
	public class FoodBUS
	{
		public FoodBUS()
		{
		}
		public DataTable getFoodByCate(int id){
			return FoodDAO.Instance.getFoodByCate(id);
		}
		public Food getFood(int id){
			if(id!=0){
				
				return FoodDAO.Instance.getFoodbyId(id);
        		
        	}
        	else
        		return null;
		}
		public int insert(string name, int idCategory, decimal price){
			return FoodDAO.Instance.insert(name,idCategory,price);
		}
		public int update(string name, int idCategory, decimal price, int id)
        {
			return FoodDAO.Instance.update(name, idCategory,price,id);
		}
		 public int delete(int id)
        {
		 	return FoodDAO.Instance.delete(id);
		 }
	}
}
