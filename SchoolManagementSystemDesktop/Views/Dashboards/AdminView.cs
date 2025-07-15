using SchoolManagementSystemDesktop.UserControls.Admin;

namespace SchoolManagementSystemDesktop.Views.Dashboards {
    public partial class AdminView : Form {
        private float baseWidth;
        private float baseFontSize;
        private float baseButtonHeight;

        private FacultyControl _facultyControl;
        private SubjectControl _subjectControl;
        private CoordinatorControl _coordinatorControl;
        private TeacherControl _teacherControl;
        private CourseControl _courseControl;
        private StudentControl _studentControl;
        private FeeControl _feeControl;
        private ClassControl _classControl;
        private AnnouncementControl _announcementControl;
        private AdminDashboardControl _adminDashboardControl;

        public AdminView(SubjectControl subjectControl, CoordinatorControl coordinatorControl,
            FacultyControl facultyControl, TeacherControl teacherControl,
            CourseControl courseControl, StudentControl studentControl,
            FeeControl feeControl, ClassControl classControl,
            AnnouncementControl announcementControl, AdminDashboardControl adminDashboardControl) {
            baseWidth = 1920f;
            baseFontSize = 10f;
            baseButtonHeight = 50f;

            InitializeComponent();
            _facultyControl = facultyControl;
            _subjectControl = subjectControl;
            _coordinatorControl = coordinatorControl;
            _teacherControl = teacherControl;
            _courseControl = courseControl;
            _studentControl = studentControl;
            _feeControl = feeControl;
            _classControl = classControl;
            _announcementControl = announcementControl;
            _adminDashboardControl = adminDashboardControl;
        }

        private void facultyBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _facultyControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_facultyControl);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void subjectBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _subjectControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_subjectControl);
        }

        private void coordinatorBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _coordinatorControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_coordinatorControl);
        }

        private void teacherBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _teacherControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_teacherControl);
        }

        private void studentBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _studentControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_studentControl);
        }

        private void courseBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _courseControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_courseControl);
        }

        private void classBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _classControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_classControl);
        }

        private void announcementBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _announcementControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_announcementControl);
        }

        private void feeBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _feeControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_feeControl);
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            _adminDashboardControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(_adminDashboardControl);
        }

        //private void contentPanel_Resize(object sender, EventArgs e) {
        //    Panel headerPanel =  _facultyControl.GetHeaderPanel();
        //    headerPanel.Font = new Font("Segoe UI", baseFontSize * CalculateScaleFactor(), FontStyle.Bold);
        //}
    }
}
