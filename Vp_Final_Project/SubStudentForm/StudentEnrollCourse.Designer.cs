namespace Vp_Final_Project.SubStudentForm
{
    partial class StudentEnrollCourse
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
            this.btn_RegisterCourse = new System.Windows.Forms.Button();
            this.label_Heading = new System.Windows.Forms.Label();
            this.label_TeacherName = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(759, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENROLL COURSES";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Items.AddRange(new object[] {
            "CHANGE PASSWORD",
            "CHANGE USERNAME"});
            this.comboBox_Course.Location = new System.Drawing.Point(56, 125);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(333, 25);
            this.comboBox_Course.TabIndex = 22;
            this.comboBox_Course.Text = "Choose Course";
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // btn_RegisterCourse
            // 
            this.btn_RegisterCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_RegisterCourse.FlatAppearance.BorderSize = 0;
            this.btn_RegisterCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_RegisterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_RegisterCourse.Location = new System.Drawing.Point(56, 240);
            this.btn_RegisterCourse.Name = "btn_RegisterCourse";
            this.btn_RegisterCourse.Size = new System.Drawing.Size(220, 28);
            this.btn_RegisterCourse.TabIndex = 23;
            this.btn_RegisterCourse.Text = "REGISTER COURSE";
            this.btn_RegisterCourse.UseVisualStyleBackColor = false;
            this.btn_RegisterCourse.Click += new System.EventHandler(this.btn_RegisterCourse_Click);
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.Location = new System.Drawing.Point(51, 174);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(107, 25);
            this.label_Heading.TabIndex = 24;
            this.label_Heading.Text = "TEACHER:";
            // 
            // label_TeacherName
            // 
            this.label_TeacherName.AutoSize = true;
            this.label_TeacherName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeacherName.Location = new System.Drawing.Point(183, 176);
            this.label_TeacherName.Name = "label_TeacherName";
            this.label_TeacherName.Size = new System.Drawing.Size(57, 21);
            this.label_TeacherName.TabIndex = 25;
            this.label_TeacherName.Text = "NONE";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.Transparent;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(58, 209);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(65, 17);
            this.label_Message.TabIndex = 26;
            this.label_Message.Text = "MESSAGE";
            // 
            // StudentEnrollCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 432);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.label_TeacherName);
            this.Controls.Add(this.label_Heading);
            this.Controls.Add(this.btn_RegisterCourse);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentEnrollCourse";
            this.Text = "StudentEnrollCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button btn_RegisterCourse;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.Label label_TeacherName;
        private System.Windows.Forms.Label label_Message;
    }
}