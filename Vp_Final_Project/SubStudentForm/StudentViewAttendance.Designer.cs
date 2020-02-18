namespace Vp_Final_Project.SubStudentForm
{
    partial class StudentViewAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.comboBox_Date = new System.Windows.Forms.ComboBox();
            this.gunaDataGridView_ShowData = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_MarkAttendance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView_ShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW ATTENDANCE";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Course.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(31, 71);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(265, 25);
            this.comboBox_Course.TabIndex = 23;
            this.comboBox_Course.Text = "Select Course";
            // 
            // comboBox_Date
            // 
            this.comboBox_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_Date.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Date.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBox_Date.FormattingEnabled = true;
            this.comboBox_Date.Location = new System.Drawing.Point(434, 71);
            this.comboBox_Date.Name = "comboBox_Date";
            this.comboBox_Date.Size = new System.Drawing.Size(265, 25);
            this.comboBox_Date.TabIndex = 24;
            this.comboBox_Date.Text = "Select Date";
            // 
            // gunaDataGridView_ShowData
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView_ShowData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView_ShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView_ShowData.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView_ShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView_ShowData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView_ShowData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView_ShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView_ShowData.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView_ShowData.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView_ShowData.EnableHeadersVisualStyles = false;
            this.gunaDataGridView_ShowData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView_ShowData.Location = new System.Drawing.Point(31, 146);
            this.gunaDataGridView_ShowData.Name = "gunaDataGridView_ShowData";
            this.gunaDataGridView_ShowData.RowHeadersVisible = false;
            this.gunaDataGridView_ShowData.RowTemplate.Height = 24;
            this.gunaDataGridView_ShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView_ShowData.Size = new System.Drawing.Size(687, 223);
            this.gunaDataGridView_ShowData.TabIndex = 25;
            this.gunaDataGridView_ShowData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.gunaDataGridView_ShowData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView_ShowData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView_ShowData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView_ShowData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView_ShowData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView_ShowData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView_ShowData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView_ShowData.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView_ShowData.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gunaDataGridView_ShowData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btn_MarkAttendance
            // 
            this.btn_MarkAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_MarkAttendance.FlatAppearance.BorderSize = 0;
            this.btn_MarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_MarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAttendance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_MarkAttendance.Location = new System.Drawing.Point(31, 108);
            this.btn_MarkAttendance.Name = "btn_MarkAttendance";
            this.btn_MarkAttendance.Size = new System.Drawing.Size(265, 28);
            this.btn_MarkAttendance.TabIndex = 30;
            this.btn_MarkAttendance.Text = "SHOW ATTENDANCE";
            this.btn_MarkAttendance.UseVisualStyleBackColor = false;
            this.btn_MarkAttendance.Click += new System.EventHandler(this.btn_MarkAttendance_Click);
            // 
            // StudentViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(743, 393);
            this.Controls.Add(this.btn_MarkAttendance);
            this.Controls.Add(this.gunaDataGridView_ShowData);
            this.Controls.Add(this.comboBox_Date);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentViewAttendance";
            this.Text = "StudentViewAttendance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView_ShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.ComboBox comboBox_Date;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView_ShowData;
        private System.Windows.Forms.Button btn_MarkAttendance;
    }
}