using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem
{
    public class ConnectionString
    {
        private static ConnectionString instance;

        public string connectionString = @"Data Source=DESKTOP-R3JFTAQ;Initial Catalog=QuanLySTK;Integrated Security=True";

        public static ConnectionString Instance { get { if (instance == null) instance = new ConnectionString(); return instance; } private set => instance = value; }
    }
}
