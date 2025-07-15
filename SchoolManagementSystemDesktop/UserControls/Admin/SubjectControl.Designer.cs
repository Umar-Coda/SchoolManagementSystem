namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class SubjectControl {
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

        private void SubjectControl_Resize(object sender, EventArgs e) {
            // Adjust the width of the search box to take approximately 1/3 of the control width
            txtSearch.Width = this.Width / 3;

            // Optionally adjust the DataGridView height
            dvgSubject.Height = this.Height - (lblHeader.Height + operationLayout.Height + 40); // 40 is padding

            // Optionally adjust button widths equally within the FlowLayoutPanel
            int buttonCount = buttonLayout.Controls.Count;
            int totalButtonLayoutWidth = buttonLayout.Width;
            int buttonWidth = buttonCount > 0 ? totalButtonLayoutWidth / buttonCount - 10 : 150;

            foreach (Control btn in buttonLayout.Controls) {
                btn.Width = buttonWidth;
                btn.Height = 60;
            }

            // Ensure the DataGridView columns scale properly
            dvgSubject.Columns[0].Width = dvgSubject.Width / 2;
            dvgSubject.Columns[1].Width = dvgSubject.Width / 2;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            mainLayout = new TableLayoutPanel();
            lblHeader = new Label();
            operationLayout = new TableLayoutPanel();
            txtSearch = new TextBox();
            buttonLayout = new FlowLayoutPanel();
            addSubjectBtn = new Button();
            editSubjectBtn = new Button();
            deleteSubjectBtn = new Button();
            searchBtn = new Button();
            dvgSubject = new DataGridView();
            SubjectCode = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            getDataServiceBindingSource = new BindingSource(components);
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getDataServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblHeader, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(dvgSubject, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.995318F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1825848F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 79.8221F));
            mainLayout.Size = new Size(1812, 854);
            mainLayout.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Left;
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(20, 33, 61);
            lblHeader.Location = new Point(3, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(20, 0, 0, 0);
            lblHeader.Size = new Size(445, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Subject Management";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 3;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.54153F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.6212626F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.8372078F));
            operationLayout.Controls.Add(txtSearch, 0, 0);
            operationLayout.Controls.Add(buttonLayout, 2, 0);
            operationLayout.Controls.Add(searchBtn, 1, 0);
            operationLayout.Dock = DockStyle.Fill;
            operationLayout.Location = new Point(3, 88);
            operationLayout.Name = "operationLayout";
            operationLayout.RowCount = 1;
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            operationLayout.Size = new Size(1806, 80);
            operationLayout.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(50, 17);
            txtSearch.Margin = new Padding(50, 3, 50, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Subject";
            txtSearch.Size = new Size(578, 45);
            txtSearch.TabIndex = 0;
            // 
            // buttonLayout
            // 
            buttonLayout.Controls.Add(addSubjectBtn);
            buttonLayout.Controls.Add(editSubjectBtn);
            buttonLayout.Controls.Add(deleteSubjectBtn);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(927, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(876, 74);
            buttonLayout.TabIndex = 1;
            // 
            // addSubjectBtn
            // 
            addSubjectBtn.Anchor = AnchorStyles.Left;
            addSubjectBtn.BackColor = Color.Green;
            addSubjectBtn.FlatAppearance.BorderSize = 0;
            addSubjectBtn.FlatStyle = FlatStyle.Flat;
            addSubjectBtn.Font = new Font("Segoe UI", 16F);
            addSubjectBtn.ForeColor = Color.White;
            addSubjectBtn.Location = new Point(3, 3);
            addSubjectBtn.Name = "addSubjectBtn";
            addSubjectBtn.Size = new Size(224, 73);
            addSubjectBtn.TabIndex = 0;
            addSubjectBtn.Text = "Create";
            addSubjectBtn.UseVisualStyleBackColor = false;
            addSubjectBtn.Click += addSubjectBtn_Click;
            // 
            // editSubjectBtn
            // 
            editSubjectBtn.BackColor = Color.DarkBlue;
            editSubjectBtn.FlatAppearance.BorderSize = 0;
            editSubjectBtn.FlatStyle = FlatStyle.Flat;
            editSubjectBtn.Font = new Font("Segoe UI", 16F);
            editSubjectBtn.ForeColor = Color.White;
            editSubjectBtn.Location = new Point(233, 3);
            editSubjectBtn.Name = "editSubjectBtn";
            editSubjectBtn.Size = new Size(224, 73);
            editSubjectBtn.TabIndex = 1;
            editSubjectBtn.Text = "Edit";
            editSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // deleteSubjectBtn
            // 
            deleteSubjectBtn.BackColor = Color.DarkRed;
            deleteSubjectBtn.FlatAppearance.BorderSize = 0;
            deleteSubjectBtn.FlatStyle = FlatStyle.Flat;
            deleteSubjectBtn.Font = new Font("Segoe UI", 16F);
            deleteSubjectBtn.ForeColor = Color.White;
            deleteSubjectBtn.Location = new Point(463, 3);
            deleteSubjectBtn.Name = "deleteSubjectBtn";
            deleteSubjectBtn.Size = new Size(224, 73);
            deleteSubjectBtn.TabIndex = 2;
            deleteSubjectBtn.Text = "Delete";
            deleteSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            searchBtn.AutoSize = true;
            searchBtn.BackColor = Color.FromArgb(20, 33, 61);
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(681, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(154, 74);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // dvgSubject
            // 
            dvgSubject.BackgroundColor = Color.White;
            dvgSubject.BorderStyle = BorderStyle.None;
            dvgSubject.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dvgSubject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvgSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSubject.Columns.AddRange(new DataGridViewColumn[] { SubjectCode, SubjectName });
            dvgSubject.Dock = DockStyle.Fill;
            dvgSubject.Location = new Point(3, 174);
            dvgSubject.Name = "dvgSubject";
            dvgSubject.RowHeadersWidth = 62;
            dvgSubject.Size = new Size(1806, 677);
            dvgSubject.TabIndex = 2;
            // 
            // SubjectCode
            // 
            SubjectCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SubjectCode.DataPropertyName = "SubjectCode";
            SubjectCode.HeaderText = "Subject Code";
            SubjectCode.MinimumWidth = 8;
            SubjectCode.Name = "SubjectCode";
            SubjectCode.ReadOnly = true;
            SubjectCode.Width = 872;
            // 
            // SubjectName
            // 
            SubjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "Subject Name";
            SubjectName.MinimumWidth = 8;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            // 
            // SubjectControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "SubjectControl";
            Size = new Size(1812, 854);
            Click += SubjectControl_Click;
            Resize += SubjectControl_Resize;
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)getDataServiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Label lblHeader;
        private TableLayoutPanel operationLayout;
        private TextBox txtSearch;
        private FlowLayoutPanel buttonLayout;
        private Button addSubjectBtn;
        private Button editSubjectBtn;
        private Button deleteSubjectBtn;
        private DataGridView dvgSubject;
        private BindingSource getDataServiceBindingSource;
        private DataGridViewTextBoxColumn SubjectCode;
        private DataGridViewTextBoxColumn SubjectName;
        private Button searchBtn;
    }
}
