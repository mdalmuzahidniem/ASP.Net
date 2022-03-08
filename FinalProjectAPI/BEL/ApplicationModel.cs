using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ApplicationModel
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public string application_status { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string application_subject { get; set; }
        public string application_type { get; set; }
    }
}
