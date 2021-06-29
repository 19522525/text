using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class ExecuteQuery
    {
        private string connectionSTR = ConnectionString.Instance.connectionString; //ConfigurationManager.ConnectionStrings["QuanLySTK"].ToString();
        private static ExecuteQuery instance;
        public static ExecuteQuery Instance { get { if (instance == null) instance = new ExecuteQuery(); return instance; } set => instance = value; }

        public DataTable ExecuteReader(string Query, object[] ParamList = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }
        public int ExecuteNoneQuery(string Query, object[] ParamList = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                return command.ExecuteNonQuery();
            }
        }
        public object ExecuteScalar(string Query, object[] ParamList = null)
        {
            object data = new object();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                data = command.ExecuteScalar();
            }
            return data;
        }
        private void AddParameter(string Query, SqlCommand command, object[] ParamList)
        {
            if (ParamList != null)
            {
                string[] parameters = Query.Split(' ');
                int i = 0;
                for (int j = 0; j < parameters.Length; j++)
                {
                    if (parameters[j].Contains("@"))
                    {
                        command.Parameters.AddWithValue(parameters[j], ParamList[i]);
                        i++;
                    }
                }
            }

        }
    }
}
