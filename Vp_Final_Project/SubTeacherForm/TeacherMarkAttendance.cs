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
    public partial class TeacherMarkAttendance : Form
    {
        MySql mysql;
        int userId;
        string dateNow;
        DataTable data;
        public TeacherMarkAttendance()
        {
            InitializeComponent();
        }
        public TeacherMarkAttendance(int id)
        {
            InitializeComponent();
            mysql = new MySql();
            data = new DataTable();
            userId = id;

            comboBox_Course.DataSource = mysql.getAllAssigedCoursesByTeacherId(userId);
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";

            DateTime dateTime = DateTime.UtcNow.Date;
            dateNow = dateTime.ToString("dd-MM-yyyy");
            label_Date.Text = DateTime.UtcNow.Date.ToString();

            label_Message.Hide();
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Message.Hide();
            data = mysql.getRegisteredStudentsByTeacherIdAndCourseName(userId, comboBox_Course.Text);
            checkedListBox_Attendance.DataSource = data;
            checkedListBox_Attendance.DisplayMember = "student_Name";
        }

        private void btn_MarkAttendance_Click(object sender, EventArgs e)
        {
            string attendance_Status = "";
            int teacherId = Convert.ToInt32(data.Rows[0]["teacher_Id"].ToString());
            int coureId = Convert.ToInt32(data.Rows[0]["course_Id"].ToString());
            string teacherName = data.Rows[0]["teacher_Name"].ToString();
            string courseName = data.Rows[0]["course_Name"].ToString();

            int stuId = 0;
            string stuName = "";
            int iter = 0;
            foreach (object item in checkedListBox_Attendance.Items)
            {
                if (checkedListBox_Attendance.CheckedItems.Contains(item))
                    attendance_Status = "Present";
                else
                    attendance_Status = "Absent";
                
                stuId = Convert.ToInt32(data.Rows[iter]["student_Id"].ToString());
                stuName = data.Rows[iter]["student_Name"].ToString();
                iter++;
                mysql.AttendanceInsert(stuId, teacherId, coureId, stuName, teacherName, courseName, dateNow, attendance_Status);
            }
            label_Message.ForeColor = Color.Green;
            label_Message.Text = "Attendance Marked.";
            label_Message.Show();
        }
    }
}
