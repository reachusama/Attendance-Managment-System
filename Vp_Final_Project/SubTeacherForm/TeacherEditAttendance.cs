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
    public partial class TeacherEditAttendance : Form
    {
        MySql mysql;
        int userId;
        string dateNow;
        DataTable data;
        public TeacherEditAttendance()
        {
            InitializeComponent();
        }
        public TeacherEditAttendance(int id)
        {
            InitializeComponent();
            mysql = new MySql();
            data = new DataTable();
            userId = id;

            comboBox_Course.DataSource = mysql.getAttendanceCoursesForTeacher(userId);
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";

            comboBox_Date.DataSource = mysql.getAttendanceDatesForTeacher(userId);
            comboBox_Date.DisplayMember = "date_Name";
            comboBox_Date.SelectedItem = null;
            comboBox_Date.Text = "Select Date";

            label_Message.Hide();
        }

        private void btn_MarkAttendance_Click(object sender, EventArgs e)
        {
            string attendance_Status = "";
            int attendance_Id = 0;
            
            int iter = 0;
            foreach (object item in checkedListBox_Attendance.Items)
            {
                if (checkedListBox_Attendance.CheckedItems.Contains(item))
                    attendance_Status = "Present";
                else
                    attendance_Status = "Absent";

                attendance_Id = Convert.ToInt32(data.Rows[iter]["attendance_Id"].ToString());
                iter++;
                mysql.AttendanceUpdate(attendance_Id,attendance_Status);
            }
            label_Message.ForeColor = Color.Green;
            label_Message.Text = "Attendance Edited.";
            label_Message.Show();
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_Message.Hide();
            data = mysql.getAttendanceByCourseAndDateForTeacher(userId, comboBox_Course.Text, comboBox_Date.Text);
            DataColumn dc = data.Columns["student_Name"];
            string studentName;
            string checkState;
            int iter = 0;
            foreach (DataRow row in data.Rows)
            {
                studentName = row["student_Name"].ToString();
                checkState = row["attendance_Status"].ToString();
                checkedListBox_Attendance.Items.Add(studentName);
                if (checkState == "Present")
                {
                    checkedListBox_Attendance.SetItemCheckState(iter, CheckState.Checked);
                }
                iter++;
            }
        }
    }
}
