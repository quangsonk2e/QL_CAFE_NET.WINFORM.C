using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO_Cafe
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
          private  set { DataProvider.instance = value; }
        }
        private DataProvider(){}
        private string connectionStr = ConfigurationManager.AppSettings.Get("connectionStr");
      
        public DataTable ExecuteQuery(string query, params string[] para)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item.TrimEnd(','), para[i]);
                            i++;
                        }
                    }
                }

                adapter.Fill(dt);
                connection.Close();
            }

            return dt;
        }
        public int ExecuteNonQuery(string query, params string[] para)
        {
            int sl = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item.TrimEnd(',').TrimEnd(')'), para[i]);
                            i++;
                        }
                    }
                }
				
                sl = command.ExecuteNonQuery();
                connection.Close();
            }

            return sl;
        }

        public object ExecuteScalar(string query, params string[] para)
        {
            object sl = 0;
            
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item.TrimEnd(','), para[i]);
                            i++;
                        }
                    }
                }

                sl = Convert.ToInt32(command.ExecuteScalar());
                
                connection.Close();
            }

            return sl;
        }
    }
    }

