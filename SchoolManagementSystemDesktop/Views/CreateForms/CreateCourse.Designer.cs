namespace SchoolManagementSystemDesktop.Views.CreateForms {
    partial class CreateCourse {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTitle = new Label();
            lblCourseName = new Label();
            lblCourseCode = new Label();
            txtCourseCode = new TextBox();
            txtCourseName = new TextBox();
            cmbFaculty = new ComboBox();
            createBtn = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 33, 61);
            lblTitle.Location = new Point(250, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(286, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Course";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.BackColor = Color.White;
            lblCourseName.Font = new Font("Segoe UI", 14F);
            lblCourseName.ForeColor = Color.FromArgb(20, 33, 61);
            lblCourseName.Location = new Point(90, 202);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(185, 38);
            lblCourseName.TabIndex = 3;
            lblCourseName.Text = "Course Name";
            lblCourseName.Click += lblFacultyName_Click;
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.BackColor = Color.White;
            lblCourseCode.Font = new Font("Segoe UI", 14F);
            lblCourseCode.ForeColor = Color.FromArgb(20, 33, 61);
            lblCourseCode.Location = new Point(90, 117);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(175, 38);
            lblCourseCode.TabIndex = 4;
            lblCourseCode.Text = "Course Code";
            // 
            // txtCourseCode
            // 
            txtCourseCode.BackColor = Color.WhiteSmoke;
            txtCourseCode.BorderStyle = BorderStyle.FixedSingle;
            txtCourseCode.Font = new Font("Segoe UI", 12F);
            txtCourseCode.ForeColor = Color.FromArgb(20, 33, 61);
            txtCourseCode.Location = new Point(318, 120);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.PlaceholderText = "Enter Course Code";
            txtCourseCode.Size = new Size(380, 39);
            txtCourseCode.TabIndex = 5;
            txtCourseCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCourseName
            // 
            txtCourseName.BackColor = Color.WhiteSmoke;
            txtCourseName.BorderStyle = BorderStyle.FixedSingle;
            txtCourseName.Font = new Font("Segoe UI", 12F);
            txtCourseName.ForeColor = Color.FromArgb(20, 33, 61);
            txtCourseName.Location = new Point(318, 205);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.PlaceholderText = "Enter Course Name";
            txtCourseName.Size = new Size(380, 39);
            txtCourseName.TabIndex = 6;
            txtCourseName.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbFaculty
            // 
            cmbFaculty.BackColor = Color.WhiteSmoke;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.Font = new Font("Segoe UI", 12F);
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(90, 275);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(608, 40);
            cmbFaculty.TabIndex = 24;
            cmbFaculty.ValueMember = "FacultyId";
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.DarkGreen;
            createBtn.Font = new Font("Segoe UI", 14F);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(274, 349);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(220, 58);
            createBtn.TabIndex = 25;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(createBtn);
            Controls.Add(cmbFaculty);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseCode);
            Controls.Add(lblCourseCode);
            Controls.Add(lblCourseName);
            Controls.Add(lblTitle);
            Name = "CreateCourse";
            Text = "CreateCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCourseName;
        private Label lblCourseCode;
        private TextBox txtCourseCode;
        private TextBox txtCourseName;
        private ComboBox cmbFaculty;
        private Button createBtn;
    }
}