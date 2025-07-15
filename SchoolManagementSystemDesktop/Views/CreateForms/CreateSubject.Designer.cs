namespace SchoolManagementSystemDesktop.Views.CreateForms {
    partial class CreateSubject {
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
            lblSubjectCode = new Label();
            lblSubjectName = new Label();
            txtSubjectCode = new TextBox();
            txtSubjectName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 33, 61);
            lblTitle.Location = new Point(339, 50);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(355, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Subject";
            // 
            // lblSubjectCode
            // 
            lblSubjectCode.AutoSize = true;
            lblSubjectCode.FlatStyle = FlatStyle.Flat;
            lblSubjectCode.Font = new Font("Segoe UI", 14F);
            lblSubjectCode.ForeColor = Color.FromArgb(20, 33, 61);
            lblSubjectCode.Location = new Point(307, 155);
            lblSubjectCode.Margin = new Padding(4, 0, 4, 0);
            lblSubjectCode.Name = "lblSubjectCode";
            lblSubjectCode.Size = new Size(252, 38);
            lblSubjectCode.TabIndex = 1;
            lblSubjectCode.Text = "Enter Subject Code";
            lblSubjectCode.Click += lblSubjectCode_Click;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.FlatStyle = FlatStyle.Flat;
            lblSubjectName.Font = new Font("Segoe UI", 14F);
            lblSubjectName.ForeColor = Color.FromArgb(20, 33, 61);
            lblSubjectName.Location = new Point(307, 274);
            lblSubjectName.Margin = new Padding(4, 0, 4, 0);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(262, 38);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Enter Subject Name";
            lblSubjectName.Click += lblSubjectName_Click;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.BackColor = Color.WhiteSmoke;
            txtSubjectCode.BorderStyle = BorderStyle.FixedSingle;
            txtSubjectCode.ForeColor = Color.FromArgb(20, 33, 61);
            txtSubjectCode.Location = new Point(307, 209);
            txtSubjectCode.Margin = new Padding(4);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.PlaceholderText = "e.g SIS 1200T";
            txtSubjectCode.Size = new Size(426, 39);
            txtSubjectCode.TabIndex = 3;
            txtSubjectCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubjectName
            // 
            txtSubjectName.BackColor = Color.WhiteSmoke;
            txtSubjectName.BorderStyle = BorderStyle.FixedSingle;
            txtSubjectName.ForeColor = Color.FromArgb(20, 33, 61);
            txtSubjectName.Location = new Point(307, 337);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.PlaceholderText = "e.g Mathematics";
            txtSubjectName.Size = new Size(426, 39);
            txtSubjectName.TabIndex = 4;
            txtSubjectName.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(408, 415);
            button1.Name = "button1";
            button1.Size = new Size(220, 58);
            button1.TabIndex = 5;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CreateSubject
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 485);
            Controls.Add(button1);
            Controls.Add(txtSubjectName);
            Controls.Add(txtSubjectCode);
            Controls.Add(lblSubjectName);
            Controls.Add(lblSubjectCode);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateSubject";
            Text = "Subject Creation Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubjectCode;
        private Label lblSubjectName;
        private TextBox txtSubjectCode;
        private TextBox txtSubjectName;
        private Button button1;
    }
}