﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public System.DateTime order_place_date { get; set; }
        public string status { get; set; }
        public string delevary_address { get; set; }
        public virtual UserModel User { get; set; }
    }
}
