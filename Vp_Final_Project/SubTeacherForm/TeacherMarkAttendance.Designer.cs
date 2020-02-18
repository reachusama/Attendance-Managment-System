namespace Vp_Final_Project.SubTeacherForm
{
    partial class TeacherMarkAttendance
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
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.checkedListBox_Attendance = new System.Windows.Forms.CheckedListBox();
            this.btn_MarkAttendance = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARK ATTENDANCE";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(12, 77);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(333, 25);
            this.comboBox_Course.TabIndex = 23;
            this.comboBox_Course.Text = "Choose Course";
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.Color.Black;
            this.label_Date.Location = new System.Drawing.Point(426, 77);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(57, 22);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "DATE";
            // 
            // checkedListBox_Attendance
            // 
            this.checkedListBox_Attendance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkedListBox_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Attendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Attendance.FormattingEnabled = true;
            this.checkedListBox_Attendance.HorizontalScrollbar = true;
            this.checkedListBox_Attendance.Location = new System.Drawing.Point(15, 127);
            this.checkedListBox_Attendance.Name = "checkedListBox_Attendance";
            this.checkedListBox_Attendance.Size = new System.Drawing.Size(330, 264);
            this.checkedListBox_Attendance.TabIndex = 24;
            // 
            // btn_MarkAttendance
            // 
            this.btn_MarkAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_MarkAttendance.FlatAppearance.BorderSize = 0;
            this.btn_MarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_MarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAttendance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_MarkAttendance.Location = new System.Drawing.Point(15, 431);
            this.btn_MarkAttendance.Name = "btn_MarkAttendance";
            this.btn_MarkAttendance.Size = new System.Drawing.Size(330, 28);
            this.btn_MarkAttendance.TabIndex = 27;
            this.btn_MarkAttendance.Text = "MARK ATTENDANCE";
            this.btn_MarkAttendance.UseVisualStyleBackColor = false;
            this.btn_MarkAttendance.Click += new System.EventHandler(this.btn_MarkAttendance_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.Location = new System.Drawing.Point(12, 403);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(151, 16);
            this.label_Message.TabIndex = 28;
            this.label_Message.Text = "PASSWORD CHANGED";
            // 
            // TeacherMarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 471);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.btn_MarkAttendance);
            this.Controls.Add(this.checkedListBox_Attendance);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherMarkAttendance";
            this.Text = "TeacherMarkAttendance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.CheckedListBox checkedListBox_Attendance;
        private System.Windows.Forms.Button btn_MarkAttendance;
        private System.Windows.Forms.Label label_Message;
    }
}