using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FirstApplication.Models.Entity;

namespace FirstApplication.Models.Tables
{
    public class Users
    {
        SqlConnection conn;
        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }
        public User Authenticate(string username, string password)
        {
            User user = null;
            conn.Open();
            string query = String.Format("select * from Users where Username='{0}' and Password='{1}'",username,password);
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User() { 
                    Id=reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                };
            }
            conn.Close();
            return user;
        }
    }
}