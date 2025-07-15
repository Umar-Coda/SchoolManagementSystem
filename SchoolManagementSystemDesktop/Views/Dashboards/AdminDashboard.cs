using SchoolManagementSystemDesktop.UserControls.Admin;

namespace SchoolManagementSystemDesktop.Views.Dashboards {
    public partial class AdminDashboard : Form {
        private Panel sidebar;
        private Panel contentPanel;

        private Button btnStudents, btnTeachers, btnFees, 
            btnSubjects, btnTimetable, btnAnnouncements, btnNotifications, btnAttendance;

        public AdminDashboard() {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI() {
            this.Text = "Administrator Dashboard";
            this.WindowState = FormWindowState.Maximized;

            sidebar = new Panel {
                Dock = DockStyle.Left,
                Width = 200,
                BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
            };

            contentPanel = new Panel {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White
            };

            btnStudents = CreateSidebarButton("Student Management", 20);
            btnTeachers = CreateSidebarButton("Teacher Management", 70);
            btnFees = CreateSidebarButton("Fee Management", 120);
            btnSubjects = CreateSidebarButton("Course & Subject Mgmt", 170);
            btnTimetable = CreateSidebarButton("Timetable Management", 220);
            btnAnnouncements = CreateSidebarButton("Announcements", 270);
            btnNotifications = CreateSidebarButton("Notifications", 320);
            btnAttendance = CreateSidebarButton("Attendance Tracking", 370);

            //btnStudents.Click += (s, e) => LoadModule(new StudentsControl());
            //btnTeachers.Click += (s, e) => LoadModule(new TeachersControl());
            //btnFees.Click += (s, e) => LoadModule(new FeesControl());
            //btnSubjects.Click += (s, e) => LoadModule(new SubjectsControl());
            //btnTimetable.Click += (s, e) => LoadModule(new TimetableControl());
            //btnAnnouncements.Click += (s, e) => LoadModule(new AnnouncementsControl());
            //btnNotifications.Click += (s, e) => LoadModule(new NotificationsControl());
            //btnAttendance.Click += (s, e) => LoadModule(new AttendanceControl());

            sidebar.Controls.AddRange(new Control[] {
            btnStudents, btnTeachers, btnFees, btnSubjects, btnTimetable, btnAnnouncements, btnNotifications, btnAttendance
        });

            this.Controls.Add(contentPanel);
            this.Controls.Add(sidebar);
        }

        private Button CreateSidebarButton(string text, int top) {
            return new Button {
                Text = text,
                Top = top,
                Left = 10,
                Width = 180,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
            };
        }

        private void LoadModule(UserControl module) {
            contentPanel.Controls.Clear();
            module.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(module);
        }
    }
}
