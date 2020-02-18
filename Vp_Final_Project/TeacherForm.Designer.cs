namespace Vp_Final_Project
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn_ViewStudents = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_EditAttendance = new System.Windows.Forms.Button();
            this.btn_ViewAttendance = new System.Windows.Forms.Button();
            this.btn_MarkAttendance = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconRestorer = new System.Windows.Forms.PictureBox();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btn_ViewStudents);
            this.MenuVertical.Controls.Add(this.signOut);
            this.MenuVertical.Controls.Add(this.btn_Settings);
            this.MenuVertical.Controls.Add(this.btn_EditAttendance);
            this.MenuVertical.Controls.Add(this.btn_ViewAttendance);
            this.MenuVertical.Controls.Add(this.btn_MarkAttendance);
            this.MenuVertical.Controls.Add(this.btn_Profile);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(226, 516);
            this.MenuVertical.TabIndex = 4;
            // 
            // btn_ViewStudents
            // 
            this.btn_ViewStudents.FlatAppearance.BorderSize = 0;
            this.btn_ViewStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewStudents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewStudents.ForeColor = System.Drawing.Color.White;
            this.btn_ViewStudents.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewStudents.Image")));
            this.btn_ViewStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewStudents.Location = new System.Drawing.Point(0, 335);
            this.btn_ViewStudents.Name = "btn_ViewStudents";
            this.btn_ViewStudents.Size = new System.Drawing.Size(226, 40);
            this.btn_ViewStudents.TabIndex = 13;
            this.btn_ViewStudents.Text = "VIEW STUDENTS            ";
            this.btn_ViewStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ViewStudents.UseVisualStyleBackColor = true;
            this.btn_ViewStudents.Click += new System.EventHandler(this.btn_ViewStudents_Click);
            // 
            // signOut
            // 
            this.signOut.FlatAppearance.BorderSize = 0;
            this.signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.ForeColor = System.Drawing.Color.White;
            this.signOut.Image = ((System.Drawing.Image)(resources.GetObject("signOut.Image")));
            this.signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOut.Location = new System.Drawing.Point(0, 457);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(226, 40);
            this.signOut.TabIndex = 12;
            this.signOut.Text = "SIGN OUT        ";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(0, 395);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(226, 40);
            this.btn_Settings.TabIndex = 11;
            this.btn_Settings.Text = "SETTINGS          ";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_EditAttendance
            // 
            this.btn_EditAttendance.FlatAppearance.BorderSize = 0;
            this.btn_EditAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_EditAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditAttendance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_EditAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditAttendance.Image")));
            this.btn_EditAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditAttendance.Location = new System.Drawing.Point(0, 276);
            this.btn_EditAttendance.Name = "btn_EditAttendance";
            this.btn_EditAttendance.Size = new System.Drawing.Size(226, 40);
            this.btn_EditAttendance.TabIndex = 10;
            this.btn_EditAttendance.Text = "EDIT ATTENDANCE       ";
            this.btn_EditAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditAttendance.UseVisualStyleBackColor = true;
            this.btn_EditAttendance.Click += new System.EventHandler(this.btn_EditAttendance_Click);
            // 
            // btn_ViewAttendance
            // 
            this.btn_ViewAttendance.FlatAppearance.BorderSize = 0;
            this.btn_ViewAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ViewAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewAttendance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_ViewAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewAttendance.Image")));
            this.btn_ViewAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewAttendance.Location = new System.Drawing.Point(0, 219);
            this.btn_ViewAttendance.Name = "btn_ViewAttendance";
            this.btn_ViewAttendance.Size = new System.Drawing.Size(226, 40);
            this.btn_ViewAttendance.TabIndex = 9;
            this.btn_ViewAttendance.Text = "VIEW ATTENDANCE     ";
            this.btn_ViewAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ViewAttendance.UseVisualStyleBackColor = true;
            this.btn_ViewAttendance.Click += new System.EventHandler(this.btn_ViewAttendance_Click);
            // 
            // btn_MarkAttendance
            // 
            this.btn_MarkAttendance.FlatAppearance.BorderSize = 0;
            this.btn_MarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_MarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAttendance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarkAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_MarkAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_MarkAttendance.Image")));
            this.btn_MarkAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MarkAttendance.Location = new System.Drawing.Point(0, 166);
            this.btn_MarkAttendance.Name = "btn_MarkAttendance";
            this.btn_MarkAttendance.Size = new System.Drawing.Size(226, 40);
            this.btn_MarkAttendance.TabIndex = 8;
            this.btn_MarkAttendance.Text = "MARK ATTENDANCE   ";
            this.btn_MarkAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MarkAttendance.UseVisualStyleBackColor = true;
            this.btn_MarkAttendance.Click += new System.EventHandler(this.btn_MarkAttendance_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.White;
            this.btn_Profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_Profile.Image")));
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(0, 113);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(226, 40);
            this.btn_Profile.TabIndex = 7;
            this.btn_Profile.Text = "PROFILE          ";
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 11);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(226, 76);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 1;
            this.btnlogoInicio.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.iconMaximizar);
            this.BarraTitulo.Controls.Add(this.iconRestorer);
            this.BarraTitulo.Controls.Add(this.iconMinimize);
            this.BarraTitulo.Controls.Add(this.iconExit);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(226, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(775, 45);
            this.BarraTitulo.TabIndex = 6;
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximizar.Image")));
            this.iconMaximizar.Location = new System.Drawing.Point(712, 6);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 11;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconRestorer
            // 
            this.iconRestorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestorer.Image = ((System.Drawing.Image)(resources.GetObject("iconRestorer.Image")));
            this.iconRestorer.Location = new System.Drawing.Point(712, 6);
            this.iconRestorer.Name = "iconRestorer";
            this.iconRestorer.Size = new System.Drawing.Size(18, 18);
            this.iconRestorer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestorer.TabIndex = 12;
            this.iconRestorer.TabStop = false;
            this.iconRestorer.Visible = false;
            this.iconRestorer.Click += new System.EventHandler(this.iconRestorer_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(679, 6);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(18, 18);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 10;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(745, 6);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(18, 18);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 9;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "TEACHER";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(8, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(226, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(775, 471);
            this.panelContenedor.TabIndex = 7;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 516);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_EditAttendance;
        private System.Windows.Forms.Button btn_ViewAttendance;
        private System.Windows.Forms.Button btn_MarkAttendance;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconRestorer;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.Button btn_ViewStudents;
    }
}