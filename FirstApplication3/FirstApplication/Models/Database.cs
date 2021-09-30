using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FirstApplication.Models.Tables;
namespace FirstApplication.Models
{
    public class Database
    {
        public Products Products { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-T8L630M;Database=.net;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            Products = new Products(conn);
        }

    }
}