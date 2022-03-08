//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Customers = new HashSet<Customer>();
            this.Employees = new HashSet<Employee>();
            this.Managers = new HashSet<Manager>();
            this.Orders = new HashSet<Order>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public int usertype { get; set; }
        public string house { get; set; }
        public string road { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string additional_info { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
