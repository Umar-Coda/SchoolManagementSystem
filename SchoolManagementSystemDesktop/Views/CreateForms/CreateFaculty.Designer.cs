namespace SchoolManagementSystemDesktop.Views.CreateForms {
    partial class CreateFaculty {
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblFacultyName = new Label();
            txtFacultyName = new TextBox();
            txtCoordinator = new TextBox();
            button1 = new Button();
            cmbCoordinator = new ComboBox();
            coordinatorSDBindingSource = new BindingSource(components);
            createBtn = new Button();
            panel1 = new Panel();
            facultyControllerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)coordinatorSDBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facultyControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 33, 61);
            lblTitle.Location = new Point(362, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 65);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Faculty";
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.BackColor = Color.White;
            lblFacultyName.Font = new Font("Segoe UI", 14F);
            lblFacultyName.ForeColor = Color.FromArgb(20, 33, 61);
            lblFacultyName.Location = new Point(181, 120);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(185, 38);
            lblFacultyName.TabIndex = 2;
            lblFacultyName.Text = "Faculty Name";
            // 
            // txtFacultyName
            // 
            txtFacultyName.BackColor = Color.WhiteSmoke;
            txtFacultyName.BorderStyle = BorderStyle.FixedSingle;
            txtFacultyName.Font = new Font("Segoe UI", 12F);
            txtFacultyName.ForeColor = Color.FromArgb(20, 33, 61);
            txtFacultyName.Location = new Point(415, 120);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.PlaceholderText = "Enter faculty";
            txtFacultyName.Size = new Size(489, 39);
            txtFacultyName.TabIndex = 3;
            txtFacultyName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCoordinator
            // 
            txtCoordinator.BackColor = Color.WhiteSmoke;
            txtCoordinator.BorderStyle = BorderStyle.FixedSingle;
            txtCoordinator.Font = new Font("Segoe UI", 12F);
            txtCoordinator.ForeColor = Color.FromArgb(20, 33, 61);
            txtCoordinator.Location = new Point(181, 194);
            txtCoordinator.Name = "txtCoordinator";
            txtCoordinator.PlaceholderText = "Enter coordinator name";
            txtCoordinator.Size = new Size(455, 39);
            txtCoordinator.TabIndex = 4;
            txtCoordinator.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(662, 190);
            button1.Name = "button1";
            button1.Size = new Size(242, 46);
            button1.TabIndex = 22;
            button1.Text = "Search Coordinator";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCoordinator
            // 
            cmbCoordinator.BackColor = Color.WhiteSmoke;
            cmbCoordinator.DataSource = coordinatorSDBindingSource;
            cmbCoordinator.DisplayMember = "CoordinatorName";
            cmbCoordinator.Font = new Font("Segoe UI", 12F);
            cmbCoordinator.FormattingEnabled = true;
            cmbCoordinator.Location = new Point(181, 261);
            cmbCoordinator.Name = "cmbCoordinator";
            cmbCoordinator.Size = new Size(723, 40);
            cmbCoordinator.TabIndex = 23;
            cmbCoordinator.ValueMember = "CoordinatorId";
            cmbCoordinator.SelectedIndexChanged += cmbCoordinator_SelectedIndexChanged;
            // 
            // coordinatorSDBindingSource
            // 
            coordinatorSDBindingSource.DataSource = typeof(CoordinatorSD);
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.DarkGreen;
            createBtn.Font = new Font("Segoe UI", 14F);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(427, 327);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(220, 58);
            createBtn.TabIndex = 24;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 436);
            panel1.TabIndex = 25;
            // 
            // facultyControllerBindingSource
            // 
            facultyControllerBindingSource.DataSource = typeof(FacultyController);
            // 
            // CreateFaculty
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1081, 436);
            Controls.Add(createBtn);
            Controls.Add(cmbCoordinator);
            Controls.Add(button1);
            Controls.Add(txtCoordinator);
            Controls.Add(txtFacultyName);
            Controls.Add(lblFacultyName);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "CreateFaculty";
            Text = "CreateFaculty";
            ((System.ComponentModel.ISupportInitialize)coordinatorSDBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)facultyControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFacultyName;
        private TextBox txtFacultyName;
        private TextBox txtCoordinator;
        private Button button1;
        private ComboBox cmbCoordinator;
        private Button createBtn;
        private Panel panel1;
        private BindingSource coordinatorSDBindingSource;
        private BindingSource facultyControllerBindingSource;
    }
}