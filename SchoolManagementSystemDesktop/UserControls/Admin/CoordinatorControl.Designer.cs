namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class CoordinatorControl {
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

        private void CoordinatorControl_Resize(object sender, EventArgs e) {
            // Adjust the width of the search box to take approximately 1/3 of the control width
            txtSearch.Width = this.Width / 3;

            // Optionally adjust the DataGridView height
            coordinatorDVG.Height = this.Height - (lblHeader.Height + operationLayout.Height + 40); // 40 is padding

            // Optionally adjust button widths equally within the FlowLayoutPanel
            int buttonCount = buttonLayout.Controls.Count;
            int totalButtonLayoutWidth = buttonLayout.Width;
            int buttonWidth = buttonCount > 0 ? totalButtonLayoutWidth / buttonCount - 10 : 150;

            foreach (Control btn in buttonLayout.Controls) {
                btn.Width = buttonWidth;
                btn.Height = 60;
            }

            // Ensure the DataGridView columns scale properly
            coordinatorDVG.Columns[0].Width = coordinatorDVG.Width / 6;
            coordinatorDVG.Columns[1].Width = coordinatorDVG.Width / 6;
            coordinatorDVG.Columns[2].Width = coordinatorDVG.Width / 6;
            coordinatorDVG.Columns[3].Width = coordinatorDVG.Width / 6;
            coordinatorDVG.Columns[4].Width = coordinatorDVG.Width / 6;
            coordinatorDVG.Columns[5].Width = coordinatorDVG.Width / 6;
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            mainLayout = new TableLayoutPanel();
            lblHeader = new Label();
            operationLayout = new TableLayoutPanel();
            txtSearch = new TextBox();
            searchBtn = new Button();
            buttonLayout = new FlowLayoutPanel();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            coordinatorDVG = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colHireDate = new DataGridViewTextBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDOB = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coordinatorDVG).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblHeader, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(coordinatorDVG, 0, 2);
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
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(20, 33, 61);
            lblHeader.Location = new Point(3, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(20, 0, 0, 0);
            lblHeader.Size = new Size(517, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Coodinator Management";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 3;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.54F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.62F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.84F));
            operationLayout.Controls.Add(txtSearch, 0, 0);
            operationLayout.Controls.Add(searchBtn, 1, 0);
            operationLayout.Controls.Add(buttonLayout, 2, 0);
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
            txtSearch.Location = new Point(50, 15);
            txtSearch.Margin = new Padding(50, 3, 50, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Coordinator";
            txtSearch.Size = new Size(577, 45);
            txtSearch.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.AutoSize = true;
            searchBtn.BackColor = Color.FromArgb(20, 33, 61);
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(680, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(154, 70);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // buttonLayout
            // 
            buttonLayout.Controls.Add(addBtn);
            buttonLayout.Controls.Add(editBtn);
            buttonLayout.Controls.Add(deleteBtn);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(925, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(878, 70);
            buttonLayout.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Left;
            addBtn.BackColor = Color.Green;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 16F);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(3, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(224, 73);
            addBtn.TabIndex = 0;
            addBtn.Text = "Create";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Left;
            editBtn.BackColor = Color.DarkBlue;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI", 16F);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(233, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(224, 74);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Left;
            deleteBtn.BackColor = Color.DarkRed;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 16F);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(463, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(224, 74);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // coordinatorDVG
            // 
            coordinatorDVG.BackgroundColor = Color.White;
            coordinatorDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coordinatorDVG.Columns.AddRange(new DataGridViewColumn[] { colName, colHireDate, colPhoneNumber, colEmail, colGender, colDOB });
            coordinatorDVG.Dock = DockStyle.Fill;
            coordinatorDVG.Location = new Point(3, 167);
            coordinatorDVG.Name = "coordinatorDVG";
            coordinatorDVG.RowHeadersWidth = 62;
            coordinatorDVG.Size = new Size(1806, 654);
            coordinatorDVG.TabIndex = 2;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colHireDate
            // 
            colHireDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHireDate.DataPropertyName = "HireDate";
            colHireDate.HeaderText = "Hire Date";
            colHireDate.MinimumWidth = 8;
            colHireDate.Name = "colHireDate";
            colHireDate.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhoneNumber.DataPropertyName = "PhoneNumber";
            colPhoneNumber.HeaderText = "Phone Number";
            colPhoneNumber.MinimumWidth = 8;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colDOB
            // 
            colDOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDOB.DataPropertyName = "BirthDate";
            colDOB.HeaderText = "DOB";
            colDOB.MinimumWidth = 8;
            colDOB.Name = "colDOB";
            colDOB.ReadOnly = true;
            // 
            // CoordinatorControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "CoordinatorControl";
            Size = new Size(1812, 824);
            Resize += CoordinatorControl_Resize;
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coordinatorDVG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label lblHeader;
        private TableLayoutPanel operationLayout;
        private TextBox txtSearch;
        private Button searchBtn;
        private FlowLayoutPanel buttonLayout;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView coordinatorDVG;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colHireDate;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDOB;
    }
}
