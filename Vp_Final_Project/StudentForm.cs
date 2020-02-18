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
    public partial class StudentForm : Form
    {
        int userId = 0;
        public StudentForm()
        {
            InitializeComponent();
            ChnageFormPanel(new SubStudentForm.StudentProfile());
        }
        public StudentForm(int id)
        {
            InitializeComponent();
            userId = id;
            ChnageFormPanel(new SubStudentForm.StudentProfile(userId));
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 226)
            {
                MenuVertical.Width = 60;
            }
            else
                MenuVertical.Width = 226;
        }



        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestorer.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestorer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestorer.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubStudentForm.StudentProfile(userId));
        }

        private void btn_ViewAttendance_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubStudentForm.StudentViewAttendance(userId));
        }

        private void btn_EnrollCourse_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubStudentForm.StudentEnrollCourse(userId));
        }

        private void btn_ViewCourses_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubStudentForm.StudentViewCourses(userId));
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubStudentForm.StudentSettings(userId));
        }
    }
}
