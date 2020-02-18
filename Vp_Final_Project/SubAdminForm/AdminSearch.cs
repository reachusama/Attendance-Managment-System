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
    public partial class AdminSearch : Form
    {
        MySql mysql;
        public AdminSearch()
        {
            InitializeComponent();
            mysql = new MySql();
        }

        private void comboBox_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunaDataGridView_ShowData.Rows.Clear();
            gunaDataGridView_ShowData.Refresh();

            DataTable dt;
            if(comboBox_Person.Text == "STUDENT")
            {
                dt = mysql.getStudentUsers();

                gunaDataGridView_ShowData.ColumnCount = 4;
                gunaDataGridView_ShowData.Columns[0].Name = "ID";
                gunaDataGridView_ShowData.Columns[1].Name = "Name";
                gunaDataGridView_ShowData.Columns[2].Name = "Email";
                gunaDataGridView_ShowData.Columns[3].Name = "Department";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gunaDataGridView_ShowData.Rows.Add();
                    gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[1];
                    gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[3];
                    gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[4];
                    gunaDataGridView_ShowData.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[9];
                }
               // gunaDataGridView_ShowData.DataSource = mysql.getStudentUsers();
            }
            if (comboBox_Person.Text == "ASSIGNED COURSES")
            {
                dt = mysql.getAllAssignedCourses();

                gunaDataGridView_ShowData.ColumnCount = 4;
                gunaDataGridView_ShowData.Columns[0].Name = "Course ID";
                gunaDataGridView_ShowData.Columns[1].Name = "Teacher ID";
                gunaDataGridView_ShowData.Columns[2].Name = "Course Name";
                gunaDataGridView_ShowData.Columns[3].Name = "Teacher Name";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gunaDataGridView_ShowData.Rows.Add();
                    gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                    gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[1];
                    gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[2];
                    gunaDataGridView_ShowData.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[3];
                }
                //gunaDataGridView_ShowData.DataSource = mysql.getAllAssignedCourses();
            }
            if (comboBox_Person.Text == "COURSE")
            {
                dt = mysql.getAllCourses();

                gunaDataGridView_ShowData.ColumnCount = 3;
                gunaDataGridView_ShowData.Columns[0].Name = "Course ID";
                gunaDataGridView_ShowData.Columns[2].Name = "Credit Hour";
                gunaDataGridView_ShowData.Columns[1].Name = "Course Name";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gunaDataGridView_ShowData.Rows.Add();
                    gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                    gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[1];
                    gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[2];
                }
             //   gunaDataGridView_ShowData.DataSource = mysql.getAllCourses();
            }
            if (comboBox_Person.Text == "TEACHER")
            {
                dt = mysql.getTeacherUsers();
                gunaDataGridView_ShowData.ColumnCount = 4;
                gunaDataGridView_ShowData.Columns[0].Name = "ID";
                gunaDataGridView_ShowData.Columns[1].Name = "Name";
                gunaDataGridView_ShowData.Columns[2].Name = "Email";
                gunaDataGridView_ShowData.Columns[3].Name = "Department";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gunaDataGridView_ShowData.Rows.Add();
                    gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[1];
                    gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[3];
                    gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[4];
                    gunaDataGridView_ShowData.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[7];
                }
              //  gunaDataGridView_ShowData.DataSource = mysql.getTeacherUsers();
            }

        }
    }
}
