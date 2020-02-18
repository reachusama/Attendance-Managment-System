namespace Vp_Final_Project.SubAdminForm
{
    partial class AdminAddCourse
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
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            this.textBox_CreditHour = new System.Windows.Forms.TextBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.panel_NewCourse = new System.Windows.Forms.Panel();
            this.label_AddCourseMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.panel_AssignCourse = new System.Windows.Forms.Panel();
            this.label_AssinCourseMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.comboBox_Teacher = new System.Windows.Forms.ComboBox();
            this.button_AssignCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_NewCourse.SuspendLayout();
            this.panel_AssignCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 62);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE MANAGMENT";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 15;
            this.lineShape2.X2 = 234;
            this.lineShape2.Y1 = 114;
            this.lineShape2.Y2 = 114;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 235;
            this.lineShape1.Y1 = 73;
            this.lineShape1.Y2 = 73;
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_AddCourse.FlatAppearance.BorderSize = 0;
            this.btn_AddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_AddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_AddCourse.Location = new System.Drawing.Point(16, 155);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(220, 28);
            this.btn_AddCourse.TabIndex = 18;
            this.btn_AddCourse.Text = "ADD COURSE";
            this.btn_AddCourse.UseVisualStyleBackColor = false;
            this.btn_AddCourse.Click += new System.EventHandler(this.btn_AddCourse_Click);
            // 
            // textBox_CreditHour
            // 
            this.textBox_CreditHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreditHour.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CreditHour.ForeColor = System.Drawing.Color.Black;
            this.textBox_CreditHour.Location = new System.Drawing.Point(15, 91);
            this.textBox_CreditHour.Name = "textBox_CreditHour";
            this.textBox_CreditHour.Size = new System.Drawing.Size(218, 16);
            this.textBox_CreditHour.TabIndex = 17;
            this.textBox_CreditHour.Text = "CREDIT HOUR";
            this.textBox_CreditHour.MouseEnter += new System.EventHandler(this.textBox_CreditHour_MouseEnter);
            this.textBox_CreditHour.MouseLeave += new System.EventHandler(this.textBox_CreditHour_MouseLeave);
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CourseName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseName.ForeColor = System.Drawing.Color.Black;
            this.textBox_CourseName.Location = new System.Drawing.Point(15, 50);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(218, 16);
            this.textBox_CourseName.TabIndex = 16;
            this.textBox_CourseName.Text = "COURSE NAME";
            this.textBox_CourseName.MouseEnter += new System.EventHandler(this.textBox_CourseName_MouseEnter);
            this.textBox_CourseName.MouseLeave += new System.EventHandler(this.textBox_CourseName_MouseLeave);
            // 
            // panel_NewCourse
            // 
            this.panel_NewCourse.Controls.Add(this.label_AddCourseMessage);
            this.panel_NewCourse.Controls.Add(this.label2);
            this.panel_NewCourse.Controls.Add(this.btn_AddCourse);
            this.panel_NewCourse.Controls.Add(this.textBox_CreditHour);
            this.panel_NewCourse.Controls.Add(this.textBox_CourseName);
            this.panel_NewCourse.Controls.Add(this.shapeContainer2);
            this.panel_NewCourse.Location = new System.Drawing.Point(36, 119);
            this.panel_NewCourse.Name = "panel_NewCourse";
            this.panel_NewCourse.Size = new System.Drawing.Size(245, 301);
            this.panel_NewCourse.TabIndex = 19;
            // 
            // label_AddCourseMessage
            // 
            this.label_AddCourseMessage.AutoSize = true;
            this.label_AddCourseMessage.BackColor = System.Drawing.Color.Transparent;
            this.label_AddCourseMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddCourseMessage.ForeColor = System.Drawing.Color.Red;
            this.label_AddCourseMessage.Location = new System.Drawing.Point(15, 127);
            this.label_AddCourseMessage.Name = "label_AddCourseMessage";
            this.label_AddCourseMessage.Size = new System.Drawing.Size(65, 17);
            this.label_AddCourseMessage.TabIndex = 25;
            this.label_AddCourseMessage.Text = "MESSAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD NEW COURSE";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(245, 301);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Option.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Option.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Items.AddRange(new object[] {
            "ADD NEW COURSE",
            "ASSIGN COURSE"});
            this.comboBox_Option.Location = new System.Drawing.Point(36, 82);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(333, 25);
            this.comboBox_Option.TabIndex = 20;
            this.comboBox_Option.Text = "Choose Option";
            this.comboBox_Option.SelectedIndexChanged += new System.EventHandler(this.comboBox_Option_SelectedIndexChanged);
            // 
            // panel_AssignCourse
            // 
            this.panel_AssignCourse.Controls.Add(this.label_AssinCourseMessage);
            this.panel_AssignCourse.Controls.Add(this.label3);
            this.panel_AssignCourse.Controls.Add(this.comboBox_Course);
            this.panel_AssignCourse.Controls.Add(this.comboBox_Teacher);
            this.panel_AssignCourse.Controls.Add(this.button_AssignCourse);
            this.panel_AssignCourse.Location = new System.Drawing.Point(35, 119);
            this.panel_AssignCourse.Name = "panel_AssignCourse";
            this.panel_AssignCourse.Size = new System.Drawing.Size(245, 301);
            this.panel_AssignCourse.TabIndex = 20;
            // 
            // label_AssinCourseMessage
            // 
            this.label_AssinCourseMessage.AutoSize = true;
            this.label_AssinCourseMessage.BackColor = System.Drawing.Color.Transparent;
            this.label_AssinCourseMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AssinCourseMessage.ForeColor = System.Drawing.Color.Red;
            this.label_AssinCourseMessage.Location = new System.Drawing.Point(20, 137);
            this.label_AssinCourseMessage.Name = "label_AssinCourseMessage";
            this.label_AssinCourseMessage.Size = new System.Drawing.Size(65, 17);
            this.label_AssinCourseMessage.TabIndex = 26;
            this.label_AssinCourseMessage.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "ASSIGN COURSE";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(16, 103);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(220, 25);
            this.comboBox_Course.TabIndex = 22;
            this.comboBox_Course.Text = "Select Course";
            // 
            // comboBox_Teacher
            // 
            this.comboBox_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Teacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Teacher.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Teacher.FormattingEnabled = true;
            this.comboBox_Teacher.Location = new System.Drawing.Point(16, 55);
            this.comboBox_Teacher.Name = "comboBox_Teacher";
            this.comboBox_Teacher.Size = new System.Drawing.Size(220, 25);
            this.comboBox_Teacher.TabIndex = 21;
            this.comboBox_Teacher.Text = "Select Teacher";
            // 
            // button_AssignCourse
            // 
            this.button_AssignCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button_AssignCourse.FlatAppearance.BorderSize = 0;
            this.button_AssignCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button_AssignCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AssignCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.button_AssignCourse.Location = new System.Drawing.Point(16, 166);
            this.button_AssignCourse.Name = "button_AssignCourse";
            this.button_AssignCourse.Size = new System.Drawing.Size(220, 28);
            this.button_AssignCourse.TabIndex = 18;
            this.button_AssignCourse.Text = "ASSIGN COURSE";
            this.button_AssignCourse.UseVisualStyleBackColor = false;
            this.button_AssignCourse.Click += new System.EventHandler(this.button_AssignCourse_Click);
            // 
            // AdminAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 432);
            this.Controls.Add(this.panel_AssignCourse);
            this.Controls.Add(this.comboBox_Option);
            this.Controls.Add(this.panel_NewCourse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddCourse";
            this.Text = "AdminAddCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_NewCourse.ResumeLayout(false);
            this.panel_NewCourse.PerformLayout();
            this.panel_AssignCourse.ResumeLayout(false);
            this.panel_AssignCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_AddCourse;
        private System.Windows.Forms.TextBox textBox_CreditHour;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Panel panel_NewCourse;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Panel panel_AssignCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.ComboBox comboBox_Teacher;
        private System.Windows.Forms.Button button_AssignCourse;
        private System.Windows.Forms.Label label_AddCourseMessage;
        private System.Windows.Forms.Label label_AssinCourseMessage;
    }
}