using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5.Models
{
    public class Department
    {
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public List<Class> Classes { get; set; }

        public Department()
        {
            Classes = new List<Class>();
        }
    }
}
