namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class FacultyControl {
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
            txtSearchBar = new TextBox();
            buttonLayout = new FlowLayoutPanel();
            searchBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            button1 = new Button();
            facultyDVG = new DataGridView();
            Faculty = new DataGridViewTextBoxColumn();
            Coordinator = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)facultyDVG).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(facultyDVG, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainLayout.Size = new Size(1812, 854);
            mainLayout.TabIndex = 0;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Left;
            header.AutoSize = true;
            header.FlatStyle = FlatStyle.Flat;
            header.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            header.ForeColor = Color.FromArgb(20, 33, 61);
            header.Location = new Point(3, 15);
            header.Name = "header";
            header.Padding = new Padding(20, 0, 0, 0);
            header.Size = new Size(440, 54);
            header.TabIndex = 0;
            header.Text = "Faculty Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 2;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationLayout.Controls.Add(txtSearchBar, 0, 0);
            operationLayout.Controls.Add(buttonLayout, 1, 0);
            operationLayout.Dock = DockStyle.Fill;
            operationLayout.Location = new Point(3, 88);
            operationLayout.Name = "operationLayout";
            operationLayout.RowCount = 1;
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            operationLayout.Size = new Size(1806, 79);
            operationLayout.TabIndex = 1;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearchBar.BackColor = Color.WhiteSmoke;
            txtSearchBar.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBar.Font = new Font("Segoe UI", 14F);
            txtSearchBar.ForeColor = Color.Black;
            txtSearchBar.Location = new Point(0, 17);
            txtSearchBar.Margin = new Padding(0, 3, 0, 3);
            txtSearchBar.Multiline = true;
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PlaceholderText = "Search Faculty";
            txtSearchBar.Size = new Size(903, 44);
            txtSearchBar.TabIndex = 0;
            txtSearchBar.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonLayout
            // 
            buttonLayout.Controls.Add(searchBtn);
            buttonLayout.Controls.Add(addBtn);
            buttonLayout.Controls.Add(editBtn);
            buttonLayout.Controls.Add(button1);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(906, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(897, 73);
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
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(621, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 75);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // facultyDVG
            // 
            facultyDVG.AccessibleRole = AccessibleRole.None;
            facultyDVG.BackgroundColor = Color.White;
            facultyDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facultyDVG.Columns.AddRange(new DataGridViewColumn[] { Faculty, Coordinator });
            facultyDVG.Dock = DockStyle.Fill;
            facultyDVG.Location = new Point(3, 173);
            facultyDVG.Name = "facultyDVG";
            facultyDVG.RowHeadersWidth = 62;
            facultyDVG.Size = new Size(1806, 678);
            facultyDVG.TabIndex = 2;
            // 
            // Faculty
            // 
            Faculty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Faculty.DataPropertyName = "FacultyName";
            Faculty.HeaderText = "Faculty";
            Faculty.MinimumWidth = 8;
            Faculty.Name = "Faculty";
            Faculty.ReadOnly = true;
            // 
            // Coordinator
            // 
            Coordinator.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Coordinator.DataPropertyName = "CoordinatorName";
            Coordinator.HeaderText = "Coordinator";
            Coordinator.MinimumWidth = 8;
            Coordinator.Name = "Coordinator";
            Coordinator.ReadOnly = true;
            // 
            // FacultyControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "FacultyControl";
            Size = new Size(1812, 854);
            Resize += FacultyControl_Resize;
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)facultyDVG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label header;
        private TableLayoutPanel operationLayout;
        private TextBox txtSearchBar;
        private FlowLayoutPanel buttonLayout;
        private Button searchBtn;
        private Button addBtn;
        private Button editBtn;
        private Button button1;
        private DataGridView facultyDVG;
        private DataGridViewTextBoxColumn Faculty;
        private DataGridViewTextBoxColumn Coordinator;
    }
}
