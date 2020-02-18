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
    public partial class LoginForm : Form
    {
        MySql mysql;
        public LoginForm()
        {
            InitializeComponent();
            label_Message.Hide();
            label_Message.Text = "";
            mysql = new MySql();
        }

        private void textBox_UserName_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "User Name")
            {
                textBox_UserName.Text = "";
            }
        }

        private void textBox_UserName_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.Text = "User Name";
            }
        }

        private void textBox_Password_MouseEnter(object sender, EventArgs e)
        {
            if(textBox_Password.Text == "Password")
            {
                textBox_Password.Text = "";
                textBox_Password.PasswordChar = '*';
            }
        }

        private void textBox_Password_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Password";
                textBox_Password.PasswordChar = '\0'; 
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(textBox_UserName.Text == "User Name" && textBox_Password.Text == "Password")
            {
                label_Message.Text = "Kindly, fill the fields.";
                label_Message.Show();
                return;
            }
            if(comboBox_Person.Text == "Login Person")
            {
                label_Message.Text = "Kindly, choose a person.";
                label_Message.Show();
                return;
            }
            if (comboBox_Person.Text == "Teacher")
            {
                if(textBox_UserName.Text != "" && textBox_Password.Text != "")
                {
                    if (mysql.isTeacherValid(textBox_UserName.Text, textBox_Password.Text))
                    {
                        this.Hide();
                        TeacherForm frm = new TeacherForm(mysql.getTeacherId(textBox_UserName.Text, textBox_Password.Text));
                        frm.Show();
                    }
                    else
                    {
                        label_Message.Text = "Wrong Username or Password";
                        label_Message.Show();
                    }
                }
                else
                {
                    label_Message.Text = "Kindly, fill the fields.";
                    label_Message.Show();
                }

            }
            if (comboBox_Person.Text == "Student")
            {
                if (textBox_UserName.Text != "" && textBox_Password.Text != "")
                {
                    if (mysql.isStudentValid(textBox_UserName.Text, textBox_Password.Text))
                    {
                        this.Hide();
                        StudentForm frm = new StudentForm(mysql.getStudentId(textBox_UserName.Text, textBox_Password.Text));
                        frm.Show();
                    }
                    else
                    {
                        label_Message.Text = "Wrong Username or Password";
                        label_Message.Show();
                    }
                }
                else
                {
                    label_Message.Text = "Kindly, fill the fields.";
                    label_Message.Show();
                }
               
            }
            if (comboBox_Person.Text == "Admin")
            {
                if (textBox_UserName.Text != "" && textBox_Password.Text != "")
                {
                    if (mysql.isAdminValid(textBox_UserName.Text, textBox_Password.Text))
                    {
                        this.Hide();
                        AdminForm frm = new AdminForm(mysql.getAdminId(textBox_UserName.Text, textBox_Password.Text));
                        frm.Show();
                    }
                    else
                    {
                        label_Message.Text = "Wrong Username or Password";
                        label_Message.Show();
                    }
                }
                else
                {
                    label_Message.Text = "Kindly, fill the fields.";
                    label_Message.Show();
                }
            }
        }
    }
}
