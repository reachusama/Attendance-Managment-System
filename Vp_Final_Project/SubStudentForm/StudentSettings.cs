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
    public partial class StudentSettings : Form
    {
        MySql mysql;
        int userId;
        public StudentSettings()
        {
            InitializeComponent();
            label_Message.Text = "";
            comboBox_Option.Text = "CHANGE PASSWORD";
        }
        public StudentSettings(int id)
        {
            InitializeComponent();
            label_Message.Text = "";
            comboBox_Option.Text = "CHANGE PASSWORD";
            userId = id;
            mysql = new MySql();
        }
        private void textBox_OldPass_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_OldPass.Text == "OLD PASSWORD" || textBox_OldPass.Text == "OLD USERNAME")
            {
                textBox_OldPass.Text = "";
                textBox_OldPass.PasswordChar = '*';
            }
        }

        private void textBox_OldPass_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_OldPass.Text == "")
            {
                if (comboBox_Option.Text == "CHANGE PASSWORD")
                    textBox_OldPass.Text = "OLD PASSWORD";
                else
                    textBox_OldPass.Text = "OLD USERNAME";
                textBox_OldPass.PasswordChar = '\0';
            }
        }

        private void textBox_NewPass_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_NewPass.Text == "NEW PASSWORD" || textBox_NewPass.Text == "NEW USERNAME")
            {
                textBox_NewPass.Text = "";
                textBox_NewPass.PasswordChar = '*';
            }
        }

        private void textBox_NewPass_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_NewPass.Text == "")
            {
                if (comboBox_Option.Text == "CHANGE PASSWORD")
                    textBox_NewPass.Text = "NEW PASSWORD";
                else
                    textBox_NewPass.Text = "NEW USERNAME";
                textBox_NewPass.PasswordChar = '\0';
            }
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (comboBox_Option.Text == "CHANGE PASSWORD")
            {
                if (textBox_NewPass.Text != "NEW PASSWORD" && textBox_OldPass.Text != "OLD PASSWORD")
                {
                    if (mysql.changeStudentPassword(userId, textBox_NewPass.Text, textBox_OldPass.Text))
                    {
                        label_Message.ForeColor = Color.Green;
                        label_Message.Text = "Password Changed Succsessfully.";
                        label_Message.Show();
                    }
                    else
                    {
                        label_Message.ForeColor = Color.Red;
                        label_Message.Text = "Invalid Old Password.";
                        label_Message.Show();
                    }
                }
                else
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Kindly, fill all the fields.";
                    label_Message.Show();
                }

            }
            else
            {
                if (textBox_NewPass.Text != "NEW USERNAME" && textBox_OldPass.Text != "OLD USERNAME")
                {
                    if (mysql.changeStudentUserName(userId, textBox_NewPass.Text, textBox_OldPass.Text))
                    {
                        label_Message.ForeColor = Color.Green;
                        label_Message.Text = "Username Changed Succsessfully.";
                        label_Message.Show();
                    }
                    else
                    {
                        label_Message.ForeColor = Color.Red;
                        label_Message.Text = "Invalid Old Username.";
                        label_Message.Show();
                    }
                }
                else
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Kindly, fill all the fields.";
                    label_Message.Show();
                }
            }
        }

        private void comboBox_Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Option.Text == "CHANGE PASSWORD")
            {
                textBox_OldPass.Text = "OLD PASSWORD";
                textBox_NewPass.Text = "NEW PASSWORD";
                btn_ChangePass.Text = "CHANGE PASSWORD";
                label_Heading.Text = "CHANGE PASSWORD";
            }
            else
            {
                textBox_OldPass.Text = "OLD USERNAME";
                textBox_NewPass.Text = "NEW USERNAME";
                btn_ChangePass.Text = "CHANGE USERNAME";
                label_Heading.Text = "CHANGE USERNAME";
            }
        }
    
    
    }
}
