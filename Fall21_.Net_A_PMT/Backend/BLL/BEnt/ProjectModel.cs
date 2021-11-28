using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class ProjectModel
    {
        public int id { get; set; }
        public string projectName { get; set; }
        public string description { get; set; }
        public System.DateTime createdDate { get; set; }
        public int creatorId { get; set; }
        public string status { get; set; }
        public virtual UserModel User { get; set; }
    }
}
