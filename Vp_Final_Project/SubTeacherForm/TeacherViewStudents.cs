using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_Final_Project.SubTeacherForm
{
    public partial class TeacherViewStudents : Form
    {
        int userId;
        MySql mysql;
        public TeacherViewStudents()
        {
            InitializeComponent();
        }
        public TeacherViewStudents(int id)
        {
            InitializeComponent();
            userId = id;
            mysql = new MySql();

            comboBox_Course.DataSource = mysql.getAllAssigedCoursesByTeacherId(userId);
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";
          //  gunaDataGridView_ShowData.DataSource = mysql.getRegisteredStudentsByCourseName(comboBox_Course.Text);

        }
        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = mysql.getRegisteredStudentsByCourseName(comboBox_Course.Text);
            gunaDataGridView_ShowData.Rows.Clear();
            gunaDataGridView_ShowData.Refresh();
            gunaDataGridView_ShowData.ColumnCount = 1;
            gunaDataGridView_ShowData.Columns[0].Name = "Student Name";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gunaDataGridView_ShowData.Rows.Add();
                gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[3];
            }
        }
    }
}
