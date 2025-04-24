namespace BT5_QuanLyKhoa
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewDepartments = new System.Windows.Forms.TreeView();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewDepartments
            // 
            this.treeViewDepartments.Location = new System.Drawing.Point(12, 12);
            this.treeViewDepartments.Name = "treeViewDepartments";
            this.treeViewDepartments.Size = new System.Drawing.Size(349, 530);
            this.treeViewDepartments.TabIndex = 0;
            this.treeViewDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDepartments_AfterSelect);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(367, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(688, 193);
            this.dataGridViewStudents.TabIndex = 1;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudentsSelectionChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(569, 330);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(178, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(569, 374);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(178, 22);
            this.txtStudentName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.treeViewDepartments);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /*private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;*/
        private System.Windows.Forms.TreeView treeViewDepartments;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}

