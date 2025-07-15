namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class CourseControl {
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            courseDvg = new DataGridView();
            CourseCode = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            FacultyName = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courseDvg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            mainLayout.Controls.Add(courseDvg, 0, 2);
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
            header.FlatStyle = FlatStyle.Flat;
            header.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            header.ForeColor = Color.FromArgb(20, 33, 61);
            header.Location = new Point(3, 14);
            header.Name = "header";
            header.Padding = new Padding(20, 0, 0, 0);
            header.Size = new Size(435, 54);
            header.TabIndex = 0;
            header.Text = "Course Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1806, 76);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(3, 16);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Course";
            txtSearch.Size = new Size(897, 43);
            txtSearch.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(searchBtn);
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Controls.Add(editBtn);
            flowLayoutPanel1.Controls.Add(deleteBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(906, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(897, 70);
            flowLayoutPanel1.TabIndex = 1;
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
            searchBtn.TabIndex = 0;
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
            addBtn.TabIndex = 1;
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
            editBtn.TabIndex = 2;
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
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // courseDvg
            // 
            courseDvg.BackgroundColor = Color.White;
            courseDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseDvg.Columns.AddRange(new DataGridViewColumn[] { CourseCode, CourseName, FacultyName });
            courseDvg.Dock = DockStyle.Fill;
            courseDvg.Location = new Point(3, 167);
            courseDvg.Name = "courseDvg";
            courseDvg.RowHeadersWidth = 62;
            courseDvg.Size = new Size(1806, 654);
            courseDvg.TabIndex = 2;
            // 
            // CourseCode
            // 
            CourseCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseCode.DataPropertyName = "CourseCode";
            CourseCode.HeaderText = "Course Code";
            CourseCode.MinimumWidth = 8;
            CourseCode.Name = "CourseCode";
            CourseCode.ReadOnly = true;
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.DataPropertyName = "CourseName";
            CourseName.HeaderText = "Course";
            CourseName.MinimumWidth = 8;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // FacultyName
            // 
            FacultyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FacultyName.DataPropertyName = "FacultyName";
            FacultyName.HeaderText = "Faculty";
            FacultyName.MinimumWidth = 8;
            FacultyName.Name = "FacultyName";
            FacultyName.ReadOnly = true;
            // 
            // CourseControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "CourseControl";
            Size = new Size(1812, 824);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)courseDvg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label header;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button searchBtn;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView courseDvg;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn FacultyName;
    }
}
