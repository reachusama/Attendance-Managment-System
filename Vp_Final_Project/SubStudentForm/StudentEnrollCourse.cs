using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_Final_Project.SubStudentForm
{
    public partial class StudentEnrollCourse : Form
    {
        MySql mysql;
        int userId;
        public StudentEnrollCourse()
        {
            InitializeComponent();
        }
        public StudentEnrollCourse(int id)
        {
            InitializeComponent();

            mysql = new MySql();
            userId = id;
            comboBox_Course.DataSource = mysql.getAllAssignedCourses();
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";
            label_Message.Hide();
        }
        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_TeacherName.Text = mysql.getTeacherNameByCourse(comboBox_Course.Text);
            label_Message.Hide();
        }

        private void btn_RegisterCourse_Click(object sender, EventArgs e)
        {
            int cId = 0;
            int tId = 0;
            string stuName = "";

            if (label_TeacherName.Text != "NONE" && comboBox_Course.Text != "")
            {

                cId = mysql.getCourseIdByName(comboBox_Course.Text);
                tId = mysql.getTeacherIdByName(label_TeacherName.Text);
                stuName = mysql.getStudentNameById(userId);


                mysql.RegisteredCoursesInsert(userId, cId, tId, stuName, label_TeacherName.Text, comboBox_Course.Text);
                label_Message.ForeColor = Color.Green;
                label_Message.Text = "Course Registered Successfully.";
                label_Message.Show();

            }
            else
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Kindly, Choose a Course.";
                label_Message.Show();
            }
        }
    }
}
