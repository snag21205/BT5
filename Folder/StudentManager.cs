using BT5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5_QuanLyKhoa
{
    public class StudentManager
    {
        private readonly DataGridView DataGridView;
        private readonly TextBox TxtStudentID;
        private readonly TextBox TxtStudentName;

        public StudentManager(DataGridView dataGridView, TextBox txtStudentID, TextBox txtStudentName)
        {
            DataGridView = dataGridView;
            TxtStudentID = txtStudentID;
            TxtStudentName = txtStudentName;
        }

        public void DisplayStudents(List<Student> students)
        {
            DataGridView.DataSource = students;
            ClearStudentDetails();
        }

        public void ClearStudentDetails()
        {
            TxtStudentID.Text = string.Empty;
            TxtStudentName.Text = string.Empty;
        }

        public void UpdateSelectedStudentDetails(Student selectedStudent)
        {
            if (selectedStudent != null)
            {
                TxtStudentID.Text = selectedStudent.ID.ToString();
                TxtStudentName.Text = selectedStudent.Name;
            }
        }
    }

}
