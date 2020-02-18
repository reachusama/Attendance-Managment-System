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
    public partial class TeacherProfile : Form
    {
        int userId = 0;
        MySql mysql;
        public TeacherProfile()
        {
            InitializeComponent();
        }
        public TeacherProfile(int id)
        {
            InitializeComponent();
            userId = id;
            mysql = new MySql();
            updateData();
        }
        private void updateData()
        {
            DataTable dt = mysql.getTeacherUser(userId);

            label_Name.Text = dt.Rows[0]["teacher_Name"].ToString();
            label_Dept.Text = dt.Rows[0]["teacher_Department"].ToString();
            label_Contact.Text = dt.Rows[0]["teacher_ContactNumber"].ToString();
            label_Address.Text = dt.Rows[0]["teacher_Address"].ToString();
            label_UserName.Text = dt.Rows[0]["teacher_UserName"].ToString();
            label_Email.Text = dt.Rows[0]["teacher_EmailAddress"].ToString();
        }
    }
}
