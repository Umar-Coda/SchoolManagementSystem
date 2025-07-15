namespace SchoolManagementSystemDesktop.Views.Dashboards {
    partial class AdminView {
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

        #region OnMouseEnter
        private void dashboardBtn_MouseEnter(object sender, EventArgs e) {
            dashboardBtn.MouseEnter += (s, e) => dashboardBtn.BackColor = Color.FromArgb(252, 163, 17);
            dashboardBtn.MouseEnter += (s, e) => dashboardBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void facultyBtn_MouseEnter(object sender, EventArgs e) {
            facultyBtn.MouseEnter += (s, e) => facultyBtn.BackColor = Color.FromArgb(252, 163, 17);
            facultyBtn.MouseEnter += (s, e) => facultyBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void coordinatorBtn_MouseEnter(object sender, EventArgs e) {
            coordinatorBtn.MouseEnter += (s, e) => coordinatorBtn.BackColor = Color.FromArgb(252, 163, 17);
            coordinatorBtn.MouseEnter += (s, e) => coordinatorBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void teacherBtn_MouseEnter(object sender, EventArgs e) {
            teacherBtn.MouseEnter += (s, e) => teacherBtn.BackColor = Color.FromArgb(252, 163, 17);
            teacherBtn.MouseEnter += (s, e) => teacherBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void studentBtn_MouseEnter(object sender, EventArgs e) {
            studentBtn.MouseEnter += (s, e) => studentBtn.BackColor = Color.FromArgb(252, 163, 17);
            studentBtn.MouseEnter += (s, e) => studentBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void courseBtn_MouseEnter(object sender, EventArgs e) {
            courseBtn.MouseEnter += (s, e) => courseBtn.BackColor = Color.FromArgb(252, 163, 17);
            courseBtn.MouseEnter += (s, e) => courseBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void classBtn_MouseEnter(object sender, EventArgs e) {
            classBtn.MouseEnter += (s, e) => classBtn.BackColor = Color.FromArgb(252, 163, 17);
            classBtn.MouseEnter += (s, e) => classBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void subjectBtn_MouseEnter(object sender, EventArgs e) {
            subjectBtn.MouseEnter += (s, e) => subjectBtn.BackColor = Color.FromArgb(252, 163, 17);
            subjectBtn.MouseEnter += (s, e) => subjectBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void feeBtn_MouseEnter(object sender, EventArgs e) {
            feeBtn.MouseEnter += (s, e) => feeBtn.BackColor = Color.FromArgb(252, 163, 17);
            feeBtn.MouseEnter += (s, e) => feeBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }

        private void announcementBtn_MouseEnter(object sender, EventArgs e) {
            announcementBtn.MouseEnter += (s, e) => announcementBtn.BackColor = Color.FromArgb(252, 163, 17);
            announcementBtn.MouseEnter += (s, e) => announcementBtn.ForeColor = Color.FromArgb(20, 33, 61);
        }
        #endregion

        #region OnMouseLeave
        private void dashboardBtn_MouseLeave(object sender, EventArgs e) {
            dashboardBtn.MouseLeave += (s, e) => dashboardBtn.BackColor = Color.FromArgb(20, 33, 61);
            dashboardBtn.MouseLeave += (s, e) => dashboardBtn.ForeColor = Color.White;
        }

        private void facultyBtn_MouseLeave(object sender, EventArgs e) {
            facultyBtn.MouseLeave += (s, e) => facultyBtn.BackColor = Color.FromArgb(20, 33, 61);
            facultyBtn.MouseLeave += (s, e) => facultyBtn.ForeColor = Color.White;
        }

        private void coordinatorBtn_MouseLeave(object sender, EventArgs e) {
            coordinatorBtn.MouseLeave += (s, e) => coordinatorBtn.BackColor = Color.FromArgb(20, 33, 61);
            coordinatorBtn.MouseLeave += (s, e) => coordinatorBtn.ForeColor = Color.White;
        }

        private void teacherBtn_MouseLeave(object sender, EventArgs e) {
            teacherBtn.MouseLeave += (s, e) => teacherBtn.BackColor = Color.FromArgb(20, 33, 61);
            teacherBtn.MouseLeave += (s, e) => teacherBtn.ForeColor = Color.White;
        }

        private void studentBtn_MouseLeave(object sender, EventArgs e) {
            studentBtn.MouseLeave += (s, e) => studentBtn.BackColor = Color.FromArgb(20, 33, 61);
            studentBtn.MouseLeave += (s, e) => studentBtn.ForeColor = Color.White;
        }

        private void courseBtn_MouseLeave(object sender, EventArgs e) {
            courseBtn.MouseLeave += (s, e) => courseBtn.BackColor = Color.FromArgb(20, 33, 61);
            courseBtn.MouseLeave += (s, e) => courseBtn.ForeColor = Color.White;
        }

        private void classBtn_MouseLeave(object sender, EventArgs e) {
            classBtn.MouseLeave += (s, e) => classBtn.BackColor = Color.FromArgb(20, 33, 61);
            classBtn.MouseLeave += (s, e) => classBtn.ForeColor = Color.White;
        }

        private void subjectBtn_MouseLeave(object sender, EventArgs e) {
            subjectBtn.MouseLeave += (s, e) => subjectBtn.BackColor = Color.FromArgb(20, 33, 61);
            subjectBtn.MouseLeave += (s, e) => subjectBtn.ForeColor = Color.White;
        }

        private void feeBtn_MouseLeave(object sender, EventArgs e) {
            feeBtn.MouseLeave += (s, e) => feeBtn.BackColor = Color.FromArgb(20, 33, 61);
            feeBtn.MouseLeave += (s, e) => feeBtn.ForeColor = Color.White;
        }

        private void announcementBtn_MouseLeave(object sender, EventArgs e) {
            announcementBtn.MouseLeave += (s, e) => announcementBtn.BackColor = Color.FromArgb(20, 33, 61);
            announcementBtn.MouseLeave += (s, e) => announcementBtn.ForeColor = Color.White;
        }
        #endregion

        #region Resize
        private void dashboardBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            dashboardBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            dashboardBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void facultyBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            facultyBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            facultyBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private float CalculateScaleFactor() {
            return this.ClientSize.Width / baseWidth;
        }

        private void coordinatorBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            coordinatorBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            coordinatorBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void headerPanel_Resize(object sender, EventArgs e) {
            float baseGreetingFont = 16f;
            float baseProfileFont = 12f;

            //lblGreeting.Font = new Font("Segoe UI", baseGreetingFont * CalculateScaleFactor(), FontStyle.Bold);
            profileLink.Font = new Font("Segoe UI", baseProfileFont * CalculateScaleFactor(), FontStyle.Bold);

            // Optional: Adjust position/margins
            int sidePadding = (int)(20 * CalculateScaleFactor());
            lblGreeting.Location = new Point(sidePadding + 50, lblGreeting.Location.Y); // Leave space for menu icon
            profileLink.Location = new Point(this.ClientSize.Width - profileLink.Width - sidePadding, profileLink.Location.Y);
        }

        private void teacherBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            teacherBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            teacherBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void studentBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            studentBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            studentBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void courseBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            courseBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            courseBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void classBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            classBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            classBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void subjectBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;


            subjectBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            subjectBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void feeBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            feeBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            feeBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }

        private void announcementBtn_Resize(object sender, EventArgs e) {
            float scaledFontSize = baseFontSize * CalculateScaleFactor();
            if (scaledFontSize < 8f) scaledFontSize = 8f;

            announcementBtn.Font = new Font("Segoe UI", scaledFontSize, FontStyle.Regular);
            announcementBtn.Height = (int)(baseButtonHeight * CalculateScaleFactor());
        }
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            mainLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            profileLink = new LinkLabel();
            lblGreeting = new Label();
            contentLayout = new TableLayoutPanel();
            sidebarPanel = new Panel();
            announcementBtn = new Button();
            feeBtn = new Button();
            subjectBtn = new Button();
            classBtn = new Button();
            courseBtn = new Button();
            studentBtn = new Button();
            teacherBtn = new Button();
            coordinatorBtn = new Button();
            facultyBtn = new Button();
            dashboardBtn = new Button();
            contentPanel = new Panel();
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            contentLayout.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(contentLayout, 2, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.198113F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90.80189F));
            mainLayout.Size = new Size(1339, 848);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(20, 33, 61);
            headerPanel.Controls.Add(profileLink);
            headerPanel.Controls.Add(lblGreeting);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.ForeColor = Color.White;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1333, 72);
            headerPanel.TabIndex = 0;
            headerPanel.Resize += headerPanel_Resize;
            // 
            // profileLink
            // 
            profileLink.ActiveLinkColor = Color.White;
            profileLink.Anchor = AnchorStyles.Right;
            profileLink.AutoSize = true;
            profileLink.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            profileLink.LinkColor = Color.White;
            profileLink.Location = new Point(1200, 24);
            profileLink.Name = "profileLink";
            profileLink.Size = new Size(90, 32);
            profileLink.TabIndex = 1;
            profileLink.TabStop = true;
            profileLink.Text = "Profile";
            // 
            // lblGreeting
            // 
            lblGreeting.Anchor = AnchorStyles.Left;
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(19, 19);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(190, 38);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hello. Admin";
            lblGreeting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contentLayout
            // 
            contentLayout.ColumnCount = 2;
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            contentLayout.Controls.Add(sidebarPanel, 0, 0);
            contentLayout.Controls.Add(contentPanel, 1, 0);
            contentLayout.Dock = DockStyle.Fill;
            contentLayout.Location = new Point(3, 81);
            contentLayout.Name = "contentLayout";
            contentLayout.RowCount = 1;
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentLayout.Size = new Size(1333, 764);
            contentLayout.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(20, 33, 61);
            sidebarPanel.Controls.Add(announcementBtn);
            sidebarPanel.Controls.Add(feeBtn);
            sidebarPanel.Controls.Add(subjectBtn);
            sidebarPanel.Controls.Add(classBtn);
            sidebarPanel.Controls.Add(courseBtn);
            sidebarPanel.Controls.Add(studentBtn);
            sidebarPanel.Controls.Add(teacherBtn);
            sidebarPanel.Controls.Add(coordinatorBtn);
            sidebarPanel.Controls.Add(facultyBtn);
            sidebarPanel.Controls.Add(dashboardBtn);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(3, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(260, 758);
            sidebarPanel.TabIndex = 0;
            // 
            // announcementBtn
            // 
            announcementBtn.Dock = DockStyle.Top;
            announcementBtn.FlatAppearance.BorderSize = 0;
            announcementBtn.FlatStyle = FlatStyle.Flat;
            announcementBtn.Font = new Font("Segoe UI", 10F);
            announcementBtn.ForeColor = Color.White;
            announcementBtn.Location = new Point(0, 450);
            announcementBtn.Name = "announcementBtn";
            announcementBtn.Padding = new Padding(10, 0, 0, 0);
            announcementBtn.Size = new Size(260, 50);
            announcementBtn.TabIndex = 8;
            announcementBtn.Text = "Announcement";
            announcementBtn.TextAlign = ContentAlignment.MiddleLeft;
            announcementBtn.UseVisualStyleBackColor = true;
            announcementBtn.Click += announcementBtn_Click;
            announcementBtn.MouseEnter += announcementBtn_MouseEnter;
            announcementBtn.MouseLeave += announcementBtn_MouseLeave;
            announcementBtn.Resize += announcementBtn_Resize;
            // 
            // feeBtn
            // 
            feeBtn.Dock = DockStyle.Top;
            feeBtn.FlatAppearance.BorderSize = 0;
            feeBtn.FlatStyle = FlatStyle.Flat;
            feeBtn.Font = new Font("Segoe UI", 10F);
            feeBtn.ForeColor = Color.White;
            feeBtn.Location = new Point(0, 400);
            feeBtn.Name = "feeBtn";
            feeBtn.Padding = new Padding(10, 0, 0, 0);
            feeBtn.Size = new Size(260, 50);
            feeBtn.TabIndex = 7;
            feeBtn.Text = "Fee";
            feeBtn.TextAlign = ContentAlignment.MiddleLeft;
            feeBtn.UseVisualStyleBackColor = true;
            feeBtn.Click += feeBtn_Click;
            feeBtn.MouseEnter += feeBtn_MouseEnter;
            feeBtn.MouseLeave += feeBtn_MouseLeave;
            feeBtn.Resize += feeBtn_Resize;
            // 
            // subjectBtn
            // 
            subjectBtn.Dock = DockStyle.Top;
            subjectBtn.FlatAppearance.BorderSize = 0;
            subjectBtn.FlatStyle = FlatStyle.Flat;
            subjectBtn.Font = new Font("Segoe UI", 10F);
            subjectBtn.ForeColor = Color.White;
            subjectBtn.Location = new Point(0, 350);
            subjectBtn.Name = "subjectBtn";
            subjectBtn.Padding = new Padding(10, 0, 0, 0);
            subjectBtn.Size = new Size(260, 50);
            subjectBtn.TabIndex = 6;
            subjectBtn.Text = "Subject";
            subjectBtn.TextAlign = ContentAlignment.MiddleLeft;
            subjectBtn.UseVisualStyleBackColor = true;
            subjectBtn.Click += subjectBtn_Click;
            subjectBtn.MouseEnter += subjectBtn_MouseEnter;
            subjectBtn.MouseLeave += subjectBtn_MouseLeave;
            subjectBtn.Resize += subjectBtn_Resize;
            // 
            // classBtn
            // 
            classBtn.Dock = DockStyle.Top;
            classBtn.FlatAppearance.BorderSize = 0;
            classBtn.FlatStyle = FlatStyle.Flat;
            classBtn.Font = new Font("Segoe UI", 10F);
            classBtn.ForeColor = Color.White;
            classBtn.Location = new Point(0, 300);
            classBtn.Name = "classBtn";
            classBtn.Padding = new Padding(10, 0, 0, 0);
            classBtn.Size = new Size(260, 50);
            classBtn.TabIndex = 5;
            classBtn.Text = "Class";
            classBtn.TextAlign = ContentAlignment.MiddleLeft;
            classBtn.UseVisualStyleBackColor = true;
            classBtn.Click += classBtn_Click;
            classBtn.MouseEnter += classBtn_MouseEnter;
            classBtn.MouseLeave += classBtn_MouseLeave;
            classBtn.Resize += classBtn_Resize;
            // 
            // courseBtn
            // 
            courseBtn.Dock = DockStyle.Top;
            courseBtn.FlatAppearance.BorderSize = 0;
            courseBtn.FlatStyle = FlatStyle.Flat;
            courseBtn.Font = new Font("Segoe UI", 10F);
            courseBtn.ForeColor = Color.White;
            courseBtn.Location = new Point(0, 250);
            courseBtn.Name = "courseBtn";
            courseBtn.Padding = new Padding(10, 0, 0, 0);
            courseBtn.Size = new Size(260, 50);
            courseBtn.TabIndex = 4;
            courseBtn.Text = "Course";
            courseBtn.TextAlign = ContentAlignment.MiddleLeft;
            courseBtn.UseVisualStyleBackColor = true;
            courseBtn.Click += courseBtn_Click;
            courseBtn.MouseEnter += courseBtn_MouseEnter;
            courseBtn.MouseLeave += courseBtn_MouseLeave;
            courseBtn.Resize += courseBtn_Resize;
            // 
            // studentBtn
            // 
            studentBtn.Dock = DockStyle.Top;
            studentBtn.FlatAppearance.BorderSize = 0;
            studentBtn.FlatStyle = FlatStyle.Flat;
            studentBtn.Font = new Font("Segoe UI", 10F);
            studentBtn.ForeColor = Color.White;
            studentBtn.Location = new Point(0, 200);
            studentBtn.Name = "studentBtn";
            studentBtn.Padding = new Padding(10, 0, 0, 0);
            studentBtn.Size = new Size(260, 50);
            studentBtn.TabIndex = 3;
            studentBtn.Text = "Student";
            studentBtn.TextAlign = ContentAlignment.MiddleLeft;
            studentBtn.UseVisualStyleBackColor = true;
            studentBtn.Click += studentBtn_Click;
            studentBtn.MouseEnter += studentBtn_MouseEnter;
            studentBtn.MouseLeave += studentBtn_MouseLeave;
            studentBtn.Resize += studentBtn_Resize;
            // 
            // teacherBtn
            // 
            teacherBtn.Dock = DockStyle.Top;
            teacherBtn.FlatAppearance.BorderSize = 0;
            teacherBtn.FlatStyle = FlatStyle.Flat;
            teacherBtn.Font = new Font("Segoe UI", 10F);
            teacherBtn.ForeColor = Color.White;
            teacherBtn.Location = new Point(0, 150);
            teacherBtn.Name = "teacherBtn";
            teacherBtn.Padding = new Padding(10, 0, 0, 0);
            teacherBtn.Size = new Size(260, 50);
            teacherBtn.TabIndex = 2;
            teacherBtn.Text = "Teacher";
            teacherBtn.TextAlign = ContentAlignment.MiddleLeft;
            teacherBtn.UseVisualStyleBackColor = true;
            teacherBtn.Click += teacherBtn_Click;
            teacherBtn.MouseEnter += teacherBtn_MouseEnter;
            teacherBtn.MouseLeave += teacherBtn_MouseLeave;
            teacherBtn.Resize += teacherBtn_Resize;
            // 
            // coordinatorBtn
            // 
            coordinatorBtn.Dock = DockStyle.Top;
            coordinatorBtn.FlatAppearance.BorderSize = 0;
            coordinatorBtn.FlatStyle = FlatStyle.Flat;
            coordinatorBtn.Font = new Font("Segoe UI", 10F);
            coordinatorBtn.ForeColor = Color.White;
            coordinatorBtn.Location = new Point(0, 100);
            coordinatorBtn.Name = "coordinatorBtn";
            coordinatorBtn.Padding = new Padding(10, 0, 0, 0);
            coordinatorBtn.Size = new Size(260, 50);
            coordinatorBtn.TabIndex = 1;
            coordinatorBtn.Text = "Coordinator";
            coordinatorBtn.TextAlign = ContentAlignment.MiddleLeft;
            coordinatorBtn.UseVisualStyleBackColor = true;
            coordinatorBtn.Click += coordinatorBtn_Click;
            coordinatorBtn.MouseEnter += coordinatorBtn_MouseEnter;
            coordinatorBtn.MouseLeave += coordinatorBtn_MouseLeave;
            coordinatorBtn.Resize += coordinatorBtn_Resize;
            // 
            // facultyBtn
            // 
            facultyBtn.Dock = DockStyle.Top;
            facultyBtn.FlatAppearance.BorderSize = 0;
            facultyBtn.FlatStyle = FlatStyle.Flat;
            facultyBtn.Font = new Font("Segoe UI", 10F);
            facultyBtn.ForeColor = Color.White;
            facultyBtn.Location = new Point(0, 50);
            facultyBtn.Name = "facultyBtn";
            facultyBtn.Padding = new Padding(10, 0, 0, 0);
            facultyBtn.Size = new Size(260, 50);
            facultyBtn.TabIndex = 0;
            facultyBtn.Text = "Faculty";
            facultyBtn.TextAlign = ContentAlignment.MiddleLeft;
            facultyBtn.UseVisualStyleBackColor = true;
            facultyBtn.Click += facultyBtn_Click;
            facultyBtn.MouseEnter += facultyBtn_MouseEnter;
            facultyBtn.MouseLeave += facultyBtn_MouseLeave;
            facultyBtn.Resize += facultyBtn_Resize;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Dock = DockStyle.Top;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 10F);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(10, 0, 0, 0);
            dashboardBtn.Size = new Size(260, 50);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            dashboardBtn.MouseEnter += dashboardBtn_MouseEnter;
            dashboardBtn.MouseLeave += dashboardBtn_MouseLeave;
            dashboardBtn.Resize += dashboardBtn_Resize;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(269, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1061, 758);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 848);
            Controls.Add(mainLayout);
            Name = "AdminView";
            Text = "AdminView";
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentLayout.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private Panel headerPanel;
        private Label lblGreeting;
        private LinkLabel profileLink;
        private TableLayoutPanel contentLayout;
        private Panel sidebarPanel;
        private Button dashboardBtn;
        private Button facultyBtn;
        private Button coordinatorBtn;
        private Button teacherBtn;
        private Button studentBtn;
        private Button courseBtn;
        private Button subjectBtn;
        private Button classBtn;
        private Button announcementBtn;
        private Button feeBtn;
        private Panel contentPanel;
    }
}