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
    public partial class StudentViewCourses : Form
    {
        int userId;
        MySql mysql;
        public StudentViewCourses()
        {
            InitializeComponent();
        }
        public StudentViewCourses(int id)
        {
            InitializeComponent();
            userId = id;
            mysql = new MySql();
            DataTable dt = mysql.getRegisteredCoursesForStudent(userId);
            
            gunaDataGridView_ShowData.Rows.Clear();
            gunaDataGridView_ShowData.Refresh();

            gunaDataGridView_ShowData.ColumnCount = 3;
            gunaDataGridView_ShowData.Columns[0].Name = "Student Name";
            gunaDataGridView_ShowData.Columns[1].Name = "Teacher Name";
            gunaDataGridView_ShowData.Columns[2].Name = "Course Name";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gunaDataGridView_ShowData.Rows.Add();
                gunaDataGridView_ShowData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[3];
                gunaDataGridView_ShowData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[4];
                gunaDataGridView_ShowData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[5];
            }
        }
    }
}
