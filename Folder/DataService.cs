using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5.Models
{
    public class DataService
    {
        private static int nextStudentId = 100;
        private static Random random = new Random();
        public List<Department> Departments { get; private set; }

        public DataService()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            
            Departments = new List<Department>();

            
            Department itBusiness = new Department
            {
                DepartmentID = "CNTT-KD",
                DepartmentName = "Khoa CNTT Kinh doanh",
                Classes = new List<Class>()
            };

            
            Class class1 = new Class
            {
                ClassID = "111-22-111",
                ClassName = "Class 111-22-111",
                DepartmentID = itBusiness.DepartmentID
            };

            Class class2 = new Class
            {
                ClassID = "111-22-222",
                ClassName = "Class 111-22-222",
                DepartmentID = itBusiness.DepartmentID
            };

            itBusiness.Classes.Add(class1);
            itBusiness.Classes.Add(class2);

           
            Department accounting = new Department
            {
                DepartmentID = "KT",
                DepartmentName = "Khoa Kế toán",
                Classes = new List<Class>()
            };

            
            Class class3 = new Class
            {
                ClassID = "222-33-111",
                ClassName = "Class 222-33-111",
                DepartmentID = accounting.DepartmentID
            };

            Class class4 = new Class
            {
                ClassID = "222-33-222",
                ClassName = "Class 222-33-222",
                DepartmentID = accounting.DepartmentID
            };

            accounting.Classes.Add(class3);
            accounting.Classes.Add(class4);

            
            Departments.Add(itBusiness);
            Departments.Add(accounting);

            // Thêm sinh viên vào lớp
            AddStudentsToClass(class1);
            AddStudentsToClass(class2);
            AddStudentsToClass(class3);
            AddStudentsToClass(class4);
        }

        private string randomPhoneNumbers()
        {  
            string phoneNumber = "0123456";
            for (int i = 0; i < 3; i++)
            {
                phoneNumber += random.Next(0, 10).ToString(); 
            }
            return phoneNumber;
        }

        private void AddStudentsToClass(Class cls)
        {
            for (int i = 1; i <= 5; i++)
            {
                nextStudentId++; 

                Student student = new Student
                {
                    ID = nextStudentId,
                    Name = $"Sinh viên {nextStudentId}",
                    Email = $"sv{nextStudentId}@ueh.edu.vn",
                    Phone = randomPhoneNumbers(),
                    Address = $"Địa chỉ của sinh viên {nextStudentId}",
                    DateOfBirth = DateTime.Now.AddYears(-20).AddDays(-i * 30).Date,
                    ClassID = int.Parse(cls.ClassID.Replace("-", ""))
                };

                cls.Students.Add(student);
            }
        }
    }
}
