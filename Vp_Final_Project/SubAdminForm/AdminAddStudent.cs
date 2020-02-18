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
    public partial class AdminAddStudent : Form
    {
        MySql mysql;
        public AdminAddStudent()
        {
            InitializeComponent();
            mysql = new MySql();
            label_Message.Hide();
        }
        private void textBox_Name_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "FULL NAME")
            {
                textBox_Name.Text = "";
            }
        }

        private void textBox_Email_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "EMAIL ADDRESS")
            {
                textBox_Email.Text = "";
            }
        }

        private void textBox_Department_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Department.Text == "DEPARTMENT")
            {
                textBox_Department.Text = "";
            }
        }

        private void textBox_Number_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Number.Text == "CONTACT NUMBER")
            {
                textBox_Number.Text = "";
            }
        }

        private void textBox_Address_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Address.Text == "ADDRESS")
            {
                textBox_Address.Text = "";
            }
        }

        private void textBox_UserName_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "USER NAME")
            {
                textBox_UserName.Text = "";
            }
        }

        private void textBox_Password_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox_Name_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                textBox_Name.Text = "FULL NAME";
            }
        }

        private void textBox_Email_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = "EMAIL ADDRESS";
            }
        }

        private void textBox_Department_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Department.Text == "")
            {
                textBox_Department.Text = "DEPARTMENT";
            }
        }

        private void textBox_Number_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Number.Text == "")
            {
                textBox_Number.Text = "CONTACT NUMBER";
            }
        }

        private void textBox_Address_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Address.Text == "")
            {
                textBox_Address.Text = "ADDRESS";
            }
        }

        private void textBox_UserName_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.Text = "USER NAME";
            }
        }

        private void textBox_Password_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "PASSWORD";
                textBox_Password.PasswordChar = '\0';
            }
        }
        
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text != "USER NAME" && textBox_Password.Text != "PASSWORD"
              && textBox_Name.Text != "FULL NAME" && textBox_Email.Text != "EMAIL ADDRESS"
              && textBox_Department.Text != "DEPARTMENT" && textBox_Number.Text != "CONTACT NUMBER" && textBox_Address.Text != "ADDRESS")
            {
                mysql.StudentInsert(textBox_UserName.Text, textBox_Password.Text, textBox_Name.Text, textBox_Email.Text,
                    textBox_Address.Text, textBox_Number.Text,"","", textBox_Department.Text);
                label_Message.ForeColor = Color.Green;
                label_Message.Text = "Student Added Successfully.";
                label_Message.Show();
            }
            else
            {
                label_Message.Text = "Kindly, Fill all the fields.";
                label_Message.ForeColor = Color.Red;
                label_Message.Show();
            }
        }
    }
}
