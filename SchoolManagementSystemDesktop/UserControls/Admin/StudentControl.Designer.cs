namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class StudentControl {
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
            viewBtn = new Button();
            deleteBtn = new Button();
            studentDvg = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            ClassCode = new DataGridViewTextBoxColumn();
            CourseCode = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDvg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(studentDvg, 0, 2);
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
            header.Size = new Size(454, 54);
            header.TabIndex = 0;
            header.Text = "Student Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 2;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            operationLayout.Controls.Add(txtSearch, 0, 0);
            operationLayout.Controls.Add(buttonLayout, 1, 0);
            operationLayout.Dock = DockStyle.Fill;
            operationLayout.Location = new Point(3, 85);
            operationLayout.Name = "operationLayout";
            operationLayout.RowCount = 1;
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            operationLayout.Size = new Size(1806, 76);
            operationLayout.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(3, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Student";
            txtSearch.Size = new Size(671, 45);
            txtSearch.TabIndex = 0;
            // 
            // buttonLayout
            // 
            buttonLayout.Controls.Add(searchBtn);
            buttonLayout.Controls.Add(addBtn);
            buttonLayout.Controls.Add(editBtn);
            buttonLayout.Controls.Add(viewBtn);
            buttonLayout.Controls.Add(deleteBtn);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(680, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(1123, 70);
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
            searchBtn.TabIndex = 3;
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
            addBtn.TabIndex = 4;
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
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.BackColor = Color.DarkCyan;
            viewBtn.FlatAppearance.BorderColor = Color.White;
            viewBtn.FlatStyle = FlatStyle.Flat;
            viewBtn.Font = new Font("Segoe UI", 16F);
            viewBtn.ForeColor = Color.White;
            viewBtn.Location = new Point(621, 3);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(200, 75);
            viewBtn.TabIndex = 6;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += viewBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.DarkRed;
            deleteBtn.FlatAppearance.BorderColor = Color.White;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 16F);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(827, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(200, 75);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // studentDvg
            // 
            studentDvg.BackgroundColor = Color.White;
            studentDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDvg.Columns.AddRange(new DataGridViewColumn[] { FullName, ClassCode, CourseCode, CourseName });
            studentDvg.Dock = DockStyle.Fill;
            studentDvg.Location = new Point(3, 167);
            studentDvg.Name = "studentDvg";
            studentDvg.RowHeadersWidth = 62;
            studentDvg.Size = new Size(1806, 654);
            studentDvg.TabIndex = 2;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "Name";
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // ClassCode
            // 
            ClassCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassCode.DataPropertyName = "ClassCode";
            ClassCode.HeaderText = "Class Code";
            ClassCode.MinimumWidth = 8;
            ClassCode.Name = "ClassCode";
            ClassCode.ReadOnly = true;
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
            // StudentControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "StudentControl";
            Size = new Size(1812, 824);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentDvg).EndInit();
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
        private Button viewBtn;
        private Button deleteBtn;
        private DataGridView studentDvg;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ClassCode;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn CourseName;
    }
}
