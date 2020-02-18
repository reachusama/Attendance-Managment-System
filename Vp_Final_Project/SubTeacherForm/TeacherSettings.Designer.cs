namespace Vp_Final_Project.SubTeacherForm
{
    partial class TeacherSettings
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
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.label_Heading = new System.Windows.Forms.Label();
            this.textBox_OldPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 67);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTINGS";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 50;
            this.lineShape1.X2 = 269;
            this.lineShape1.Y1 = 214;
            this.lineShape1.Y2 = 214;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 50;
            this.lineShape2.X2 = 269;
            this.lineShape2.Y1 = 262;
            this.lineShape2.Y2 = 262;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(775, 471);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Option.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Option.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Items.AddRange(new object[] {
            "CHANGE PASSWORD",
            "CHANGE USERNAME"});
            this.comboBox_Option.Location = new System.Drawing.Point(47, 99);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(333, 25);
            this.comboBox_Option.TabIndex = 27;
            this.comboBox_Option.Text = "Choose Option";
            this.comboBox_Option.SelectedIndexChanged += new System.EventHandler(this.comboBox_Option_SelectedIndexChanged);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_ChangePass.FlatAppearance.BorderSize = 0;
            this.btn_ChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePass.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.Location = new System.Drawing.Point(49, 305);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(220, 28);
            this.btn_ChangePass.TabIndex = 26;
            this.btn_ChangePass.Text = "CHANGE PASSWORD";
            this.btn_ChangePass.UseVisualStyleBackColor = false;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.Location = new System.Drawing.Point(48, 279);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(151, 16);
            this.label_Message.TabIndex = 25;
            this.label_Message.Text = "PASSWORD CHANGED";
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass.ForeColor = System.Drawing.Color.Black;
            this.textBox_NewPass.Location = new System.Drawing.Point(49, 244);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.Size = new System.Drawing.Size(218, 16);
            this.textBox_NewPass.TabIndex = 24;
            this.textBox_NewPass.Text = "NEW PASSWORD";
            this.textBox_NewPass.MouseEnter += new System.EventHandler(this.textBox_NewPass_MouseEnter);
            this.textBox_NewPass.MouseLeave += new System.EventHandler(this.textBox_NewPass_MouseLeave);
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.Location = new System.Drawing.Point(44, 157);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(223, 25);
            this.label_Heading.TabIndex = 23;
            this.label_Heading.Text = "CHANGE PASSWORD";
            // 
            // textBox_OldPass
            // 
            this.textBox_OldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_OldPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OldPass.ForeColor = System.Drawing.Color.Black;
            this.textBox_OldPass.Location = new System.Drawing.Point(49, 195);
            this.textBox_OldPass.Name = "textBox_OldPass";
            this.textBox_OldPass.Size = new System.Drawing.Size(218, 16);
            this.textBox_OldPass.TabIndex = 22;
            this.textBox_OldPass.Text = "OLD PASSWORD";
            this.textBox_OldPass.MouseEnter += new System.EventHandler(this.textBox_OldPass_MouseEnter);
            this.textBox_OldPass.MouseLeave += new System.EventHandler(this.textBox_OldPass_MouseLeave);
            // 
            // TeacherSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 471);
            this.Controls.Add(this.comboBox_Option);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.label_Heading);
            this.Controls.Add(this.textBox_OldPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherSettings";
            this.Text = "TeacherSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.TextBox textBox_OldPass;
    }
}