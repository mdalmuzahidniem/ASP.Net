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
    
    public partial class React
    {
        public int Id { get; set; }
        public int News_id { get; set; }
        public string Reacts { get; set; }
        public int User_id { get; set; }
    
        public virtual News News { get; set; }
        public virtual User User { get; set; }
    }
}
