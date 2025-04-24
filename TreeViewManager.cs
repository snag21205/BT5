using BT5_QuanLyKhoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5_QuanLyKhoa
{
    public class TreeViewManager
    {
        private readonly TreeView TreeView;
        private readonly DataService DataService;

        public TreeViewManager(TreeView treeView, DataService dataService)
        {
            TreeView = treeView;
            DataService = dataService;
        }

        public void LoadTreeViewData()
        {
            TreeView.Nodes.Clear();

            foreach (Department department in DataService.Departments)
            {
                TreeNode departmentNode = new TreeNode(department.DepartmentName)
                {
                    Tag = department
                };

                foreach (Class cls in department.Classes)
                {
                    TreeNode classNode = new TreeNode(cls.ClassName)
                    {
                        Tag = cls
                    };
                    departmentNode.Nodes.Add(classNode);
                }

                TreeView.Nodes.Add(departmentNode);
            }

            TreeView.ExpandAll();
        }
    }
}
