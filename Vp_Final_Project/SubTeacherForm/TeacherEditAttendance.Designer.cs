namespace Vp_Final_Project.SubTeacherForm
{
    partial class TeacherEditAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.btn_MarkAttendance = new System.Windows.Forms.Button();
            this.checkedListBox_Attendance = new System.Windows.Forms.CheckedListBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.comboBox_Date = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDIT ATTENDANCE";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.Location = new System.Drawing.Point(34, 405);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(151, 16);
            this.label_Message.TabIndex = 33;
            this.label_Message.Text = "PASSWORD CHANGED";
            // 
            // btn_MarkAttendance
            // 
            this.btn_MarkAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_MarkAttendance.FlatAppearance.BorderSize = 0;
            this.btn_MarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_MarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAttendance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_MarkAttendance.Location = new System.Drawing.Point(37, 433);
            this.btn_MarkAttendance.Name = "btn_MarkAttendance";
            this.btn_MarkAttendance.Size = new System.Drawing.Size(330, 28);
            this.btn_MarkAttendance.TabIndex = 32;
            this.btn_MarkAttendance.Text = "EDIT ATTENDANCE";
            this.btn_MarkAttendance.UseVisualStyleBackColor = false;
            this.btn_MarkAttendance.Click += new System.EventHandler(this.btn_MarkAttendance_Click);
            // 
            // checkedListBox_Attendance
            // 
            this.checkedListBox_Attendance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkedListBox_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Attendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Attendance.FormattingEnabled = true;
            this.checkedListBox_Attendance.HorizontalScrollbar = true;
            this.checkedListBox_Attendance.Location = new System.Drawing.Point(37, 151);
            this.checkedListBox_Attendance.Name = "checkedListBox_Attendance";
            this.checkedListBox_Attendance.Size = new System.Drawing.Size(330, 242);
            this.checkedListBox_Attendance.TabIndex = 31;
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(34, 66);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(251, 25);
            this.comboBox_Course.TabIndex = 30;
            this.comboBox_Course.Text = "Choose Course";
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // comboBox_Date
            // 
            this.comboBox_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Date.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Date.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Date.FormattingEnabled = true;
            this.comboBox_Date.Location = new System.Drawing.Point(455, 66);
            this.comboBox_Date.Name = "comboBox_Date";
            this.comboBox_Date.Size = new System.Drawing.Size(265, 25);
            this.comboBox_Date.TabIndex = 34;
            this.comboBox_Date.Text = "Select Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(37, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "SHOW ATTENDANCE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherEditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Date);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.btn_MarkAttendance);
            this.Controls.Add(this.checkedListBox_Attendance);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherEditAttendance";
            this.Text = "TeacherEditAttendance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button btn_MarkAttendance;
        private System.Windows.Forms.CheckedListBox checkedListBox_Attendance;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.ComboBox comboBox_Date;
        private System.Windows.Forms.Button button1;
    }
}