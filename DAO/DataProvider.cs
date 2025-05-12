using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        string connectionStr = @"Data Source=MSI;Initial Catalog=flashCard3;Integrated Security=True;";
        
        private static DataProvider instance;

        public static DataProvider Instance { 
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            set => instance = value; 
        }

        public DataTable executeReader(string query, List<object> parameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] queryList = query.Split(' ', ',', '=', ')', '(');
                    int i = 0;
                    foreach (var item in queryList)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);

                connection.Close();
            }
            return table;
        }

        public object executeScalar(string query, List<object> parameters = null)
        {
            object result;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] queryList = query.Split(' ', ',', '=', ')', '(');
                    int i = 0;
                    foreach (var item in queryList)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                result = command.ExecuteScalar();

                connection.Close();
            }
            return result;
        }

        public int executeNonQuery(string query, List<object> parameters = null)
        {
            int result = -1;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] queryList = query.Split(' ', ',', '=', ')', '(');
                    int i = 0;
                    foreach (var item in queryList)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                result = command.ExecuteNonQuery();

                connection.Close();
            }
            return result;
        }
    }
}
