namespace SchoolManagementSystemDesktop.UserControls.Admin {
    partial class AnnouncementControl {
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
            announcementDvg = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            DatePosted = new DataGridViewTextBoxColumn();
            mainLayout.SuspendLayout();
            operationLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)announcementDvg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(header, 0, 0);
            mainLayout.Controls.Add(operationLayout, 0, 1);
            mainLayout.Controls.Add(announcementDvg, 0, 2);
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
            header.Size = new Size(594, 54);
            header.TabIndex = 0;
            header.Text = "Announcement Management";
            header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // operationLayout
            // 
            operationLayout.ColumnCount = 2;
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            operationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            operationLayout.Controls.Add(txtSearch, 0, 0);
            operationLayout.Controls.Add(buttonLayout, 1, 0);
            operationLayout.Dock = DockStyle.Fill;
            operationLayout.Location = new Point(3, 85);
            operationLayout.Name = "operationLayout";
            operationLayout.RowCount = 1;
            operationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            operationLayout.Size = new Size(1806, 76);
            operationLayout.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(3, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Announcement";
            txtSearch.Size = new Size(716, 45);
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
            buttonLayout.Location = new Point(725, 3);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(1078, 70);
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
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
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
            addBtn.TabIndex = 6;
            addBtn.Text = "Create";
            addBtn.UseVisualStyleBackColor = false;
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
            editBtn.TabIndex = 7;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
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
            viewBtn.TabIndex = 8;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = false;
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
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // announcementDvg
            // 
            announcementDvg.BackgroundColor = Color.White;
            announcementDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            announcementDvg.Columns.AddRange(new DataGridViewColumn[] { Title, FullName, Username, DatePosted });
            announcementDvg.Dock = DockStyle.Fill;
            announcementDvg.Location = new Point(3, 167);
            announcementDvg.Name = "announcementDvg";
            announcementDvg.RowHeadersWidth = 62;
            announcementDvg.Size = new Size(1806, 654);
            announcementDvg.TabIndex = 2;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Sender";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // DatePosted
            // 
            DatePosted.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatePosted.DataPropertyName = "DatePosted";
            DatePosted.HeaderText = "DatePosted";
            DatePosted.MinimumWidth = 8;
            DatePosted.Name = "DatePosted";
            DatePosted.ReadOnly = true;
            // 
            // AnnouncementControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Name = "AnnouncementControl";
            Size = new Size(1812, 824);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            operationLayout.ResumeLayout(false);
            operationLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)announcementDvg).EndInit();
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
        private DataGridView announcementDvg;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn DatePosted;
    }
}
