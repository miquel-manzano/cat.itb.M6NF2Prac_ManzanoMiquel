using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6NF2Prac.connections
{
    // Conexions
    public class StoreCloudConnection
    {
        private String HOST = "postgresql-miquel.alwaysdata.net"; // Ubicació de la BD.
        private String DB = "miquel_mystore"; // nom de la BD.
        private String USER = "miquel_admin"; // nom user
        private String PASSWORD = "Admin2025!"; // password user

        public NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(
                "Host=" + HOST + ";" + "Username=" + USER + ";" +
                "Password=" + PASSWORD + ";" + "Database=" + DB + ";"
            );
            conn.Open();
            return conn;
        }
    }
}
