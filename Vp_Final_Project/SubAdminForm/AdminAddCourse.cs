using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_Final_Project.SubAdminForm
{
    public partial class AdminAddCourse : Form
    {
        MySql mysql;
        public AdminAddCourse()
        {
            InitializeComponent();
            mysql = new MySql();

            comboBox_Course.DataSource = mysql.getAllCoursesName();
            comboBox_Course.DisplayMember = "course_Name";
            comboBox_Course.SelectedItem = null;
            comboBox_Course.Text = "Select Course";

            comboBox_Teacher.DataSource = mysql.getAllTeachersName();
            comboBox_Teacher.DisplayMember = "teacher_Name";
            comboBox_Teacher.SelectedItem = null; 
            comboBox_Teacher.Text = "Select Teacher";

            label_AddCourseMessage.Hide();
            label_AssinCourseMessage.Hide();
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            if(textBox_CourseName.Text != "COURSE NAME" && textBox_CreditHour.Text != "CREDIT HOUR")
            {
                mysql.CourseInsert(textBox_CourseName.Text, textBox_CreditHour.Text);
                label_AddCourseMessage.ForeColor = Color.Green;
                label_AddCourseMessage.Text = "Course Added Successfully";
                label_AddCourseMessage.Show();
            }
            else
            {
                label_AddCourseMessage.ForeColor = Color.Red;
                label_AddCourseMessage.Text = "Kindly, fill all the fields.";
                label_AddCourseMessage.Show();
            }
        }

        private void button_AssignCourse_Click(object sender, EventArgs e)
        {
            if(comboBox_Teacher.Text != "Select Teacher" && comboBox_Course.Text != "Select Course")
            {
                int courseId = mysql.getCourseIdByName(comboBox_Course.Text);
                int teacherId = mysql.getTeacherIdByName(comboBox_Teacher.Text);
                mysql.AssignedCourseInsert(courseId, teacherId, comboBox_Course.Text, comboBox_Teacher.Text);
                label_AssinCourseMessage.ForeColor = Color.Green;
                label_AssinCourseMessage.Text = "Course Added Successfully";
                label_AssinCourseMessage.Show();
            }
            else
            {
                label_AssinCourseMessage.ForeColor = Color.Red;
                label_AssinCourseMessage.Text = "Kindly, fill all the fields.";
                label_AssinCourseMessage.Show();
            }
        }


        private void textBox_CourseName_MouseEnter(object sender, EventArgs e)
        {
            if(textBox_CourseName.Text == "COURSE NAME")
            {
                textBox_CourseName.Text = "";
            }
        }

        private void textBox_CreditHour_MouseEnter(object sender, EventArgs e)
        {
            if(textBox_CreditHour.Text == "CREDIT HOUR")
            {
                textBox_CreditHour.Text = "";
            }
        }

        private void textBox_CourseName_MouseLeave(object sender, EventArgs e)
        {
            if(textBox_CourseName.Text == "")
            {
                textBox_CourseName.Text = "COURSE NAME";
            }
        }

        private void textBox_CreditHour_MouseLeave(object sender, EventArgs e)
        {
            if(textBox_CreditHour.Text == "")
            {

                textBox_CreditHour.Text = "CREDIT HOUR";
            }
        }

        private void comboBox_Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Option.Text == "ADD NEW COURSE")
            {
                panel_NewCourse.Show();
                panel_AssignCourse.Hide();
            }
            if(comboBox_Option.Text == "ASSIGN COURSE")
            {
                panel_NewCourse.Hide();
                panel_AssignCourse.Show();
            }
        }
    }
}
