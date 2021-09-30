using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FirstApplication.Models.Entity;

namespace FirstApplication.Models.Tables
{
    public class Products
    {
        SqlConnection conn; 
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Product s)
        {
            String query = String.Format("Insert into Products values ('{0}','{1}','{2}','{3}')", s.Name, s.Price, s.Quantity, s.Description);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Product GetItem(int id)
        {
            string query = String.Format("Select * from Products where Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           
            Product p = null;
            //
            while (reader.Read())
            {
                p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };
               
            }
            conn.Close();
            return p;
        }
        public List<Product> GetAll() {
            String query = "select * from Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
                products.Add(p);
            }
            conn.Close();
            return products;
            
        }
    }
}