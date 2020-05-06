/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/4/2020
 * Time: 8:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Text;
using DTO_Cafe;

namespace DAO_Cafe
{
	/// <summary>
	/// Description of BillInfoDao.
	/// </summary>
	public class BillInfoDao
	{
		private static BillInfoDao instance;
		public static BillInfoDao Instance
        {
            get { if (instance == null) instance = new BillInfoDao(); return BillInfoDao.instance; }
           private set { BillInfoDao.instance = value; }
        }
		private BillInfoDao()
		{
		}
		public DataTable getBillInfo(int idBill=0){
			return DataProvider.Instance.ExecuteQuery("EXEC dbo.getBillInfoIdBill @idBill",idBill.ToString());
		}
		

		public DataTable getBillByDate(DateTime dateStart, DateTime dateEnd){
	 		string query = string.Format(@"select Bill.id, Bill.DateCheckOut, Bill.status, SUM(food.price* BillInfo.count1) as tongtien
									from Bill
									inner join BillInfo on BillInfo.idBill=Bill.id
									inner join Food on Food.id=BillInfo.idFood
									where Bill.DateCheckOut>='{0}' and Bill.DateCheckOut<='{1}'
									group by Bill.id, Bill.DateCheckOut, Bill.status",
	                             	dateStart, dateEnd);
            return DataProvider.Instance.ExecuteQuery(query);
		}
		public Decimal getBillSum(DateTime dateStart, DateTime dateEnd){
	 		string query = string.Format(@"select SUM(food.price* BillInfo.count1) as tongtien from Bill inner join BillInfo on BillInfo.idBill=Bill.id inner join Food on Food.id=BillInfo.idFood where Bill.DateCheckOut>='{0}' and Bill.DateCheckOut<='{1}'",dateStart, dateEnd);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0 || DataProvider.Instance.ExecuteQuery(query).Rows[0]["tongtien"]==DBNull.Value) return 0;
            else return (decimal)DataProvider.Instance.ExecuteQuery(query).Rows[0]["tongtien"];
		}
        public DataTable getBillInfo(int idBill = 0, int idFood=0)
        {
            string query = string.Format("select * from BillInfo where idBill={0} and idFood={1}", idBill, idFood);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int updateBill(BillInfo billInfo)
        {
            string query = string.Format("update BillInfo set idBill={0}, idFood={1}, count1={2} where id= {3}", billInfo.IdBill, billInfo.IdFood, billInfo.Count1,billInfo.ID);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
		public int insert(int idBill,int idFood, int count){
			string query=String.Format("INSERT INTO BillInfo(idBill, idFood, count1) values({0},{1},{2})",idBill, idFood, count);
			
			return DataProvider.Instance.ExecuteNonQuery(query);
			
		}
        public int delete(int id)
        {
            string query = String.Format("delete from BillInfo where id={0}", id.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
	}
}
