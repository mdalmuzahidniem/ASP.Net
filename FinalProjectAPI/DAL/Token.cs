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
    
    public partial class Token
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string accessToken { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> expiredAt { get; set; }
    }
}
