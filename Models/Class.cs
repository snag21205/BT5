using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_QuanLyKhoa.Models
{
    public class Class
    {
        public string ClassID { get; set; }  
        public string ClassName { get; set; }
        public string DepartmentID { get; set; } //khoa ngoai tham chieu den khoa

        public List<Student> Students { get; set; }

        public Class()
        {
            Students = new List<Student>();
        }
    }
}
