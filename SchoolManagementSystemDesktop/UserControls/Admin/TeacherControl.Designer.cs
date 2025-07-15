namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class TeacherControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            mainLayout = new TableLayoutPanel();
            header = new Label();
            operationLayout = new TableLayoutPanel();
            txtSearch = new TextBox();
            buttonLayout = new FlowLayoutPanel();
            searchBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            teacherDvg = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            SubjectCode = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherDvg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(teacherDvg, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainLayout.Size = new Size(1812, 824);
            mainLayout.TabIndex = 0;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Left;
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            header.ForeColor = Color.FromArgb(20, 33, 61);
            header.Location = new Point(3, 14);
            header.Name = "header";
            header.Padding = new Padding(20, 0, 0, 0);
            header.Size = new Size(450, 54);
            header.TabIndex = 0;
            header.Text = "Teacher Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 2;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.Controls.Add(txtSearch, 0, 0);
            operationLayout.Controls.Add(buttonLayout, 1, 0);
            operationLayout.Dock = DockStyle.Fill;
            operationLayout.Location = new Point(3, 85);
            operationLayout.Name = "operationLayout";
            operationLayout.RowCount = 1;
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            operationLayout.Size = new Size(1806, 76);
            operationLayout.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(3, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Teacher";
            txtSearch.Size = new Size(897, 45);
            txtSearch.TabIndex = 0;
            // 
            // buttonLayout
            // 
            buttonLayout.Controls.Add(searchBtn);
            buttonLayout.Controls.Add(addBtn);
            buttonLayout.Controls.Add(editBtn);
            buttonLayout.Controls.Add(deleteBtn);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(906, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(897, 70);
            buttonLayout.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkBlue;
            searchBtn.FlatAppearance.BorderColor = Color.White;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 16F);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(3, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(200, 75);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Green;
            addBtn.FlatAppearance.BorderColor = Color.White;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 16F);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(209, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(200, 75);
            addBtn.TabIndex = 2;
            addBtn.Text = "Create";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Blue;
            editBtn.FlatAppearance.BorderColor = Color.White;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 16F);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(415, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(200, 75);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.DarkRed;
            deleteBtn.FlatAppearance.BorderColor = Color.White;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 16F);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(621, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(200, 75);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // teacherDvg
            // 
            teacherDvg.BackgroundColor = Color.White;
            teacherDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherDvg.Columns.AddRange(new DataGridViewColumn[] { FullName, Gender, Email, PhoneNumber, Address, BirthDate, SubjectCode });
            teacherDvg.Dock = DockStyle.Fill;
            teacherDvg.Location = new Point(3, 167);
            teacherDvg.Name = "teacherDvg";
            teacherDvg.RowHeadersWidth = 62;
            teacherDvg.Size = new Size(1806, 654);
            teacherDvg.TabIndex = 2;
            // 
            // Name
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "Name";
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 8;
            FullName.Name = "Name";
            FullName.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // BirthDate
            // 
            BirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "DOB";
            BirthDate.MinimumWidth = 8;
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            // 
            // SubjectCode
            // 
            SubjectCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubjectCode.DataPropertyName = "SubjectCode";
            SubjectCode.HeaderText = "Subject";
            SubjectCode.MinimumWidth = 8;
            SubjectCode.Name = "SubjectCode";
            SubjectCode.ReadOnly = true;
            // 
            // TeacherControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "TeacherControl";
            Size = new Size(1812, 824);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacherDvg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label header;
        private TableLayoutPanel operationLayout;
        private TextBox txtSearch;
        private FlowLayoutPanel buttonLayout;
        private Button searchBtn;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView teacherDvg;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn SubjectCode;
    }
}
