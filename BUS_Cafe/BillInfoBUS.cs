/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/4/2020
 * Time: 8:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using DAO_Cafe;
using DTO_Cafe;

namespace BUS_Cafe
{
	/// <summary>
	/// Description of BillInfoBUS.
	/// </summary>
	public class BillInfoBUS
	{
		public BillInfoBUS()
		{
		}
		public List<BillInfo> getBillInfo(int idBill=0){
			DataTable dt= BillInfoDao.Instance.getBillInfo(idBill);
			List<BillInfo> lBI=new List<BillInfo>();
			foreach (DataRow row in dt.Rows) {
				BillInfo bI=new BillInfo();
				bI.IdBill=(int) row["idBill"];
				bI.IdFood=(int) row["idFood"];
				bI.Count1=(int)row["count1"];
				lBI.Add(bI);
			}
			return lBI;
		}
		public int insert(int idBill,int idFood, int count, int idTable){
            int idBill1 = 0;
            if (idBill == -1)
            {
                idBill1 = BillDAO.Instance.insert(DateTime.Now, DateTime.Now, idTable, 1);
            }
            else
                idBill1 = idBill;
            // Trộn billInfo
            if (BillInfoDao.Instance.getBillInfo(idBill1, idFood).Rows.Count > 0)
            {
                DataTable dt=BillInfoDao.Instance.getBillInfo(idBill1, idFood);
                BillInfo bIf = new BillInfo();
                bIf.ID = (int)dt.Rows[0]["id"];
                bIf.IdBill = (int)dt.Rows[0]["idBill"];
                bIf.IdFood = (int)dt.Rows[0]["idFood"];
                bIf.Count1 = (int)dt.Rows[0]["count1"];
                bIf.Count1 += count;
                BillInfoDao.Instance.updateBill(bIf);
            }
            else
                BillInfoDao.Instance.insert(idBill1, idFood, count);

            return idBill1;
		}
	}
}
