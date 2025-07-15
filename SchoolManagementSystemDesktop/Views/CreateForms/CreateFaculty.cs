
namespace SchoolManagementSystemDesktop.Views.CreateForms {
    public partial class CreateFaculty : Form {
        private FacultyController _facultyController;

        private string _facultyName;
        private int _coordinatorId;
        private string _coordinatorName;

        public CreateFaculty(FacultyController facultyController) {
            InitializeComponent();
            _facultyController = facultyController;
        }

        // Search Coordinator Button
        private void button1_Click(object sender, EventArgs e) {
            _coordinatorName = txtCoordinator.Text;

            if (string.IsNullOrEmpty(_coordinatorName)) {
                MessageBox.Show("Coordinator name is required to assign to a faculty");
                return;
            }

            var coordinators = _facultyController.GetCoordinatorSDs(_coordinatorName);

            if (coordinators == null) {
                MessageBox.Show("No coordinators found");
                return;
            }

            cmbCoordinator.DataSource = coordinators;
        }

        private void createBtn_Click(object sender, EventArgs e) {
            // get faculty name and check duplicate
            _facultyName = txtFacultyName.Text;

            if (string.IsNullOrWhiteSpace(_facultyName)) {
                MessageBox.Show("Faculty name is required.");
                return;
            }

            var result = _facultyController.CheckDuplicateFacultyName(_facultyName);

            if (result.Error) {
                MessageBox.Show(result.Message);
                return;
            }

            // check if coordinator id is selected.
            _coordinatorId = (int)cmbCoordinator.SelectedValue;

            if (_coordinatorId == 0) {
                MessageBox.Show("Error: Select a coordinator");
                return;
            }

            result = _facultyController.CreateFaculty(_facultyName, _coordinatorId);
            MessageBox.Show(result.Message);
        }

        private void cmbCoordinator_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
