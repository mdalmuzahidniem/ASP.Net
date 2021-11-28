using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class AssignedProjectModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int projectId { get; set; }
        public string status { get; set; }

        public virtual ProjectModel Project { get; set; }
        public virtual UserModel User { get; set; }
    }
}
