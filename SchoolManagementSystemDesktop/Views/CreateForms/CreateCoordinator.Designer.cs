namespace SchoolManagementSystemDesktop.Views.CreateForms {
    partial class CreateCoordinator {
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
            lblFirstname = new Label();
            txtFirstname = new TextBox();
            lblLastname = new Label();
            txtLastname = new TextBox();
            lblGender = new Label();
            radioMaleBtn = new RadioButton();
            radioFemaleBtn = new RadioButton();
            lblBirthDate = new Label();
            txtBirthDate = new DateTimePicker();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            lblAddress = new Label();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblUserAccountTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Gainsboro;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 33, 61);
            lblTitle.Location = new Point(342, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(499, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register Coordinator";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = Color.Gainsboro;
            lblFirstname.Font = new Font("Segoe UI", 14F);
            lblFirstname.ForeColor = Color.FromArgb(20, 33, 61);
            lblFirstname.Location = new Point(30, 176);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(138, 38);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "Firstname";
            lblFirstname.Click += lblFirstname_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = Color.WhiteSmoke;
            txtFirstname.BorderStyle = BorderStyle.FixedSingle;
            txtFirstname.Font = new Font("Segoe UI", 12F);
            txtFirstname.ForeColor = Color.FromArgb(20, 33, 61);
            txtFirstname.Location = new Point(196, 179);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "e.g Jon Doe";
            txtFirstname.Size = new Size(315, 39);
            txtFirstname.TabIndex = 2;
            txtFirstname.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = Color.Gainsboro;
            lblLastname.Font = new Font("Segoe UI", 14F);
            lblLastname.ForeColor = Color.FromArgb(20, 33, 61);
            lblLastname.Location = new Point(30, 259);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(134, 38);
            lblLastname.TabIndex = 3;
            lblLastname.Text = "Lastname";
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.WhiteSmoke;
            txtLastname.BorderStyle = BorderStyle.FixedSingle;
            txtLastname.Font = new Font("Segoe UI", 12F);
            txtLastname.ForeColor = Color.FromArgb(20, 33, 61);
            txtLastname.Location = new Point(196, 258);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "e.g Doe";
            txtLastname.Size = new Size(315, 39);
            txtLastname.TabIndex = 4;
            txtLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Gainsboro;
            lblGender.Font = new Font("Segoe UI", 14F);
            lblGender.ForeColor = Color.FromArgb(20, 33, 61);
            lblGender.Location = new Point(30, 335);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(108, 38);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // radioMaleBtn
            // 
            radioMaleBtn.AutoSize = true;
            radioMaleBtn.BackColor = Color.Gainsboro;
            radioMaleBtn.FlatStyle = FlatStyle.Flat;
            radioMaleBtn.Font = new Font("Segoe UI", 12F);
            radioMaleBtn.Location = new Point(196, 338);
            radioMaleBtn.Name = "radioMaleBtn";
            radioMaleBtn.Size = new Size(90, 36);
            radioMaleBtn.TabIndex = 6;
            radioMaleBtn.TabStop = true;
            radioMaleBtn.Text = "Male";
            radioMaleBtn.UseVisualStyleBackColor = false;
            // 
            // radioFemaleBtn
            // 
            radioFemaleBtn.AutoSize = true;
            radioFemaleBtn.BackColor = Color.Gainsboro;
            radioFemaleBtn.FlatStyle = FlatStyle.Flat;
            radioFemaleBtn.Font = new Font("Segoe UI", 12F);
            radioFemaleBtn.Location = new Point(312, 337);
            radioFemaleBtn.Name = "radioFemaleBtn";
            radioFemaleBtn.Size = new Size(114, 36);
            radioFemaleBtn.TabIndex = 7;
            radioFemaleBtn.TabStop = true;
            radioFemaleBtn.Text = "Female";
            radioFemaleBtn.UseVisualStyleBackColor = false;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.BackColor = Color.Gainsboro;
            lblBirthDate.Font = new Font("Segoe UI", 14F);
            lblBirthDate.ForeColor = Color.FromArgb(20, 33, 61);
            lblBirthDate.Location = new Point(30, 411);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(74, 38);
            lblBirthDate.TabIndex = 8;
            lblBirthDate.Text = "DOB";
            // 
            // txtBirthDate
            // 
            txtBirthDate.CalendarFont = new Font("Segoe UI", 12F);
            txtBirthDate.Location = new Point(196, 418);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(315, 31);
            txtBirthDate.TabIndex = 9;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Gainsboro;
            lblPhoneNumber.Font = new Font("Segoe UI", 14F);
            lblPhoneNumber.ForeColor = Color.FromArgb(20, 33, 61);
            lblPhoneNumber.Location = new Point(30, 492);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(96, 38);
            lblPhoneNumber.TabIndex = 10;
            lblPhoneNumber.Text = "Phone";
            lblPhoneNumber.Click += label1_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.WhiteSmoke;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtPhoneNumber.ForeColor = Color.FromArgb(20, 33, 61);
            txtPhoneNumber.Location = new Point(196, 495);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "e.g 58200784";
            txtPhoneNumber.Size = new Size(315, 39);
            txtPhoneNumber.TabIndex = 11;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Gainsboro;
            lblEmail.Font = new Font("Segoe UI", 14F);
            lblEmail.ForeColor = Color.FromArgb(20, 33, 61);
            lblEmail.Location = new Point(30, 578);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 38);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Gainsboro;
            lblAddress.Font = new Font("Segoe UI", 14F);
            lblAddress.ForeColor = Color.FromArgb(20, 33, 61);
            lblAddress.Location = new Point(30, 658);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(116, 38);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.FromArgb(20, 33, 61);
            txtEmail.Location = new Point(196, 581);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g jondoe@example.com";
            txtEmail.Size = new Size(315, 39);
            txtEmail.TabIndex = 14;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.WhiteSmoke;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.ForeColor = Color.FromArgb(20, 33, 61);
            txtAddress.Location = new Point(196, 661);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(886, 39);
            txtAddress.TabIndex = 15;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUserAccountTitle
            // 
            lblUserAccountTitle.AutoSize = true;
            lblUserAccountTitle.BackColor = Color.Gray;
            lblUserAccountTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUserAccountTitle.ForeColor = Color.White;
            lblUserAccountTitle.Location = new Point(675, 176);
            lblUserAccountTitle.Name = "lblUserAccountTitle";
            lblUserAccountTitle.Size = new Size(366, 54);
            lblUserAccountTitle.TabIndex = 16;
            lblUserAccountTitle.Text = "Enter account info";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Gray;
            lblUsername.Font = new Font("Segoe UI", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(599, 259);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 38);
            lblUsername.TabIndex = 17;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Gray;
            lblPassword.Font = new Font("Segoe UI", 14F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(599, 338);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(132, 38);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(799, 262);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 39);
            txtUsername.TabIndex = 19;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(799, 341);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 39);
            txtPassword.TabIndex = 20;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(476, 712);
            button1.Name = "button1";
            button1.Size = new Size(220, 58);
            button1.TabIndex = 21;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 774);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(550, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 308);
            panel2.TabIndex = 0;
            // 
            // CreateCoordinator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 782);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblUserAccountTitle);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(radioFemaleBtn);
            Controls.Add(radioMaleBtn);
            Controls.Add(lblGender);
            Controls.Add(txtLastname);
            Controls.Add(lblLastname);
            Controls.Add(txtFirstname);
            Controls.Add(lblFirstname);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "CreateCoordinator";
            Text = "Register Coordinator";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFirstname;
        private TextBox txtFirstname;
        private Label lblLastname;
        private TextBox txtLastname;
        private Label lblGender;
        private RadioButton radioMaleBtn;
        private RadioButton radioFemaleBtn;
        private Label lblBirthDate;
        private DateTimePicker txtBirthDate;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblEmail;
        private Label lblAddress;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblUserAccountTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
    }
}