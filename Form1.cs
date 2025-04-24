using BT5_QuanLyKhoa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BT5_QuanLyKhoa
{
    public partial class Form1 : Form
    {
        private readonly DataService dataService;
        private readonly TreeViewManager TreeViewManager;
        private readonly StudentManager StudentManager;

        public Form1()
        {
            InitializeComponent();

            dataService = new DataService();
            TreeViewManager = new TreeViewManager(treeViewDepartments, dataService);
            StudentManager = new StudentManager(dataGridViewStudents, txtStudentID, txtStudentName);

            TreeViewManager.LoadTreeViewData();
        }

        private void treeViewDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Class selectedClass)
            {
                StudentManager.DisplayStudents(selectedClass.Students);
            }
            else
            {
                StudentManager.DisplayStudents(null);
            }
        }

        private void dataGridViewStudentsSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridViewStudents.SelectedRows[0].DataBoundItem;
                StudentManager.UpdateSelectedStudentDetails(selectedStudent);
            }
        }

    }
}