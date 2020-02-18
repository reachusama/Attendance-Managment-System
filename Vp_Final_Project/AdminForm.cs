using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_Final_Project
{
    public partial class AdminForm : Form
    {
        int userId = 0;
        public AdminForm()
        {
            InitializeComponent();
            ChnageFormPanel(new SubAdminForm.AdminProfile());
        }
        public AdminForm(int id)
        {
            InitializeComponent();
            userId = id;
            ChnageFormPanel(new SubAdminForm.AdminProfile(userId));

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 226)
            {
                MenuVertical.Width = 60;
            }
            else
                MenuVertical.Width = 226;
        }

        private void ChnageFormPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void signOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconMaximizar.Visible = false;
            iconRestorer.Visible = true;
        }

        private void iconRestorer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconMaximizar.Visible = true;
            iconRestorer.Visible = false;
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminProfile(userId));
        }

        private void but_AddTeacher_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminAddTeacher());
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminAddStudent());
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminAddCourse());
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminSettings(userId));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubAdminForm.AdminSearch());
        }
    }
}
