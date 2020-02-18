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
    public partial class TeacherViewAttendance : Form
    {
        MySql mysql;
        int userId;
        public TeacherViewAttendance()
        {
            InitializeComponent();
        }
        public TeacherViewAttendance(int id)
        {
            InitializeComponent();
            userId = id;
            mysql = new MySql();

            comboBox_Course.DataSource = mysql.getAttendanceCoursesForTeacher(userId);
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";

            comboBox_Date.DataSource = mysql.getAttendanceDatesForTeacher(userId);
            comboBox_Date.DisplayMember = "date_Name";
            comboBox_Date.SelectedItem = null;
            comboBox_Date.Text = "Select Date";
        }

        private void btn_MarkAttendance_Click(object sender, EventArgs e)
        {
            DataTable dt = mysql.getAttendanceByCourseAndDateForTeacher(userId, comboBox_Course.Text, comboBox_Date.Text);
            gunaDataGridView_ShowData.Rows.Clear();
            gunaDataGridView_ShowData.Refresh();

            gunaDataGridView_ShowData.ColumnCount = 4;
            gunaDataGridView_ShowData.Columns[0].Name = "Student Name";
            gunaDataGridView_ShowData.Columns[1].Name = "Teacher Name";
            gunaDataGridView_ShowData.Columns[2].Name = "Date Name";
            gunaDataGridView_ShowData.Columns[3].Name = "Attendance";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gunaDataGridView_ShowData.Rows.Add();
                gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[4];
                gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[5];
                gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[7];
                gunaDataGridView_ShowData.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[8];
            }
        }
    }
}
