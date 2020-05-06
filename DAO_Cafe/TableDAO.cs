using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO_Cafe;
using DTO_Cafe;
using System.Data;
namespace DAO_Cafe
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
           private set { TableDAO.instance = value; }
        }
        private TableDAO() { }

        public List<Table> LoadTableList() {
            List<Table> tableList = new List<Table>();
            string query=string.Format("",1);
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.getTable");
            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
        public int update(Table table){
        	string query = String.Format("update Tablefood set name='{0}', status='{1}' where id={2}", table.Name, table.Status, table.ID);
        	return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
        public int insert(string name, string status="Trống")
        {
            string query = String.Format("insert into Tablefood(name, status) values('{0}','{1}')", name, status);

            return DataProvider.Instance.ExecuteNonQuery(query);

        }
        public int delete(int id)
        {
            string query = String.Format("delete from Tablefood where id={0}", id.ToString());
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
