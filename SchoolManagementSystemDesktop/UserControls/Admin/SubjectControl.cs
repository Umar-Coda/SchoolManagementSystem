using System.ComponentModel;

namespace SchoolManagementSystemDesktop.UserControls.Admin {
    public partial class SubjectControl : UserControl {
        private readonly SubjectController _subjectController;

        public SubjectControl(SubjectController subjectController) {
            InitializeComponent();
            dvgSubject.AutoGenerateColumns = false;

            _subjectController = subjectController;

            LoadSubjectGrid(); 
        }

        private void SubjectControl_Click(object sender, EventArgs e) {

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            string searchItem = txtSearch.Text.Trim().ToLower();
            var subjects = _subjectController.LoadSubjectData(searchItem);
            UpdateSubjectGrid(subjects);
        }

        private void LoadSubjectGrid() {
            var subjects = _subjectController.LoadSubjectData(string.Empty);
            UpdateSubjectGrid(subjects);
        }

        private void UpdateSubjectGrid(List<SubjectGridData> subjects) {
            var bindingList = new BindingList<SubjectGridData>(subjects);
            dvgSubject.DataSource = null;
            dvgSubject.DataSource = bindingList;
        }

        private void addSubjectBtn_Click(object sender, EventArgs e) {
            var createSubjectView = new CreateSubject(_subjectController);
            createSubjectView.Show();
        }  
    }
}
