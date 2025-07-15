namespace SchoolManagementSystemDesktop.Views.EditForms {
    partial class EditCoordinator {
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
            panel1 = new Panel();
            label1 = new Label();
            txtSearchCoordinator = new TextBox();
            searchCoordinatorBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(searchCoordinatorBtn);
            panel1.Controls.Add(txtSearchCoordinator);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(20, 33, 61);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 712);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 30F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(434, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 80);
            label1.TabIndex = 0;
            label1.Text = "Edit Coordinator";
            // 
            // txtSearchCoordinator
            // 
            txtSearchCoordinator.BackColor = Color.Gainsboro;
            txtSearchCoordinator.Font = new Font("Segoe UI", 14F);
            txtSearchCoordinator.ForeColor = Color.Black;
            txtSearchCoordinator.Location = new Point(422, 122);
            txtSearchCoordinator.Multiline = true;
            txtSearchCoordinator.Name = "txtSearchCoordinator";
            txtSearchCoordinator.PlaceholderText = "Search Coordinator";
            txtSearchCoordinator.ScrollBars = ScrollBars.Vertical;
            txtSearchCoordinator.Size = new Size(512, 49);
            txtSearchCoordinator.TabIndex = 1;
            txtSearchCoordinator.TextChanged += txtSearchCoordinator_TextChanged;
            // 
            // searchCoordinatorBtn
            // 
            searchCoordinatorBtn.BackColor = Color.FromArgb(22, 33, 61);
            searchCoordinatorBtn.FlatAppearance.BorderSize = 0;
            searchCoordinatorBtn.FlatStyle = FlatStyle.Flat;
            searchCoordinatorBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchCoordinatorBtn.ForeColor = Color.White;
            searchCoordinatorBtn.Location = new Point(603, 188);
            searchCoordinatorBtn.Name = "searchCoordinatorBtn";
            searchCoordinatorBtn.Size = new Size(131, 49);
            searchCoordinatorBtn.TabIndex = 2;
            searchCoordinatorBtn.Text = "Search";
            searchCoordinatorBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1322, 99);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(1322, 158);
            panel3.TabIndex = 4;
            // 
            // EditCoordinator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 712);
            Controls.Add(panel1);
            Name = "EditCoordinator";
            Text = "EditCoordinator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchCoordinator;
        private Label label1;
        private Button searchCoordinatorBtn;
        private Panel panel2;
        private Panel panel3;
    }
}