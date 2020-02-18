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
    public partial class StudentProfile : Form
    {
        int userId = 0;
        MySql mysql;
        public StudentProfile()
        {
            InitializeComponent();
        }
        public StudentProfile(int id)
        {
            InitializeComponent();
            userId = id;

            mysql = new MySql();
            updateData();
        }
        private void updateData()
        {
            DataTable dt = mysql.getStudentUser(userId);

            label_Name.Text = dt.Rows[0]["student_Name"].ToString();
            label_Dept.Text = dt.Rows[0]["student_Department"].ToString();
            label_Contact.Text = dt.Rows[0]["student_ContactNumber"].ToString();
            label_Address.Text = dt.Rows[0]["student_Address"].ToString();
            label_UserName.Text = dt.Rows[0]["student_Enrollment"].ToString(); 
            label_Email.Text = dt.Rows[0]["student_EmailAddress"].ToString();
        }
        private void StudentProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
