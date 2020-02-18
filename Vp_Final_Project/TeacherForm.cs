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
    public partial class TeacherForm : Form
    {
        int userId = 0;
        public TeacherForm()
        {
            InitializeComponent();
            ChnageFormPanel(new SubTeacherForm.TeacherProfile());
        }
        public TeacherForm(int id)
        {
            InitializeComponent();
            userId = id;
            ChnageFormPanel(new SubTeacherForm.TeacherProfile(userId));
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

        private void iconMinimize_Click(object sender, EventArgs e)
        {
         
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherProfile(userId));
        }

        private void btn_MarkAttendance_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherMarkAttendance(userId));
        }

        private void btn_ViewAttendance_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherViewAttendance(userId));
        }

        private void btn_EditAttendance_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherEditAttendance(userId));
        }

        private void btn_ViewStudents_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherViewStudents(userId));
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            ChnageFormPanel(new SubTeacherForm.TeacherSettings(userId));
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
