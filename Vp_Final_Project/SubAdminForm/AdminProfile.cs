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
    public partial class AdminProfile : Form
    {
        int userId = 0;
        MySql mysql;
        public AdminProfile()
        {
            InitializeComponent();
        }
        public AdminProfile(int id)
        {
            InitializeComponent();
            userId = id;
            mysql = new MySql();
            updateData();
        }
        private void updateData()
        {
            DataTable dt = mysql.getAdminUser(userId);

            label_Name.Text = dt.Rows[0]["admin_FullName"].ToString();
            label_UserName.Text = dt.Rows[0]["admin_UserName"].ToString(); ;
            label_Email.Text = dt.Rows[0]["admin_Email"].ToString();
        }
    }
}
