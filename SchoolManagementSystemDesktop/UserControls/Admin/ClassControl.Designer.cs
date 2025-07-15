namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class ClassControl {
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
            textBox1 = new TextBox();
            buttonLayout = new FlowLayoutPanel();
            searchBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            classDvg = new DataGridView();
            ClassCode = new DataGridViewTextBoxColumn();
            CourseCode = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classDvg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(classDvg, 0, 2);
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
            header.BackColor = Color.White;
            header.FlatStyle = FlatStyle.Flat;
            header.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            header.ForeColor = Color.FromArgb(20, 33, 61);
            header.Location = new Point(3, 14);
            header.Name = "header";
            header.Padding = new Padding(20, 0, 0, 0);
            header.Size = new Size(400, 54);
            header.TabIndex = 0;
            header.Text = "Class Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 2;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.Controls.Add(textBox1, 0, 0);
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(3, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Class";
            textBox1.Size = new Size(897, 45);
            textBox1.TabIndex = 0;
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
            searchBtn.TabIndex = 2;
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
            addBtn.TabIndex = 3;
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
            editBtn.TabIndex = 4;
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
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // classDvg
            // 
            classDvg.BackgroundColor = Color.White;
            classDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classDvg.Columns.AddRange(new DataGridViewColumn[] { ClassCode, CourseCode, CourseName });
            classDvg.Dock = DockStyle.Fill;
            classDvg.Location = new Point(3, 167);
            classDvg.Name = "classDvg";
            classDvg.RowHeadersWidth = 62;
            classDvg.Size = new Size(1806, 654);
            classDvg.TabIndex = 2;
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
            // ClassControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "ClassControl";
            Size = new Size(1812, 824);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)classDvg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label header;
        private TableLayoutPanel operationLayout;
        private TextBox textBox1;
        private FlowLayoutPanel buttonLayout;
        private Button searchBtn;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView classDvg;
        private DataGridViewTextBoxColumn ClassCode;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn CourseName;
    }
}
