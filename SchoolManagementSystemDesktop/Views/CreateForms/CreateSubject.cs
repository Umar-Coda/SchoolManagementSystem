
namespace SchoolManagementSystemDesktop.Views.CreateForms {
    public partial class CreateSubject : Form {
        private Subject _subject;
        private SubjectController _subjectController;

        public CreateSubject(SubjectController controller) {
            InitializeComponent();
            _subject = new Subject();
            _subjectController = controller;
        }

        private void lblSubjectCode_Click(object sender, EventArgs e) {

        }

        private void lblSubjectName_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            _subject.SubjectCode = txtSubjectCode.Text.Trim();
            _subject.SubjectName = txtSubjectName.Text.Trim();

            bool isInputValid = InputValidation(_subject.SubjectCode, _subject.SubjectName);

            if (!isInputValid)
                return;

            var result = _subjectController.CreateSubject(_subject);

            MessageBox.Show(result.Message);
        }

        private bool InputValidation(string code, string name) {
            if (string.IsNullOrEmpty(code) && string.IsNullOrEmpty(name)) {
                MessageBox.Show("Subject code and subject name are required");
                return false;
            }

            if (!string.IsNullOrEmpty(code) && string.IsNullOrEmpty(name)) {
                MessageBox.Show("Subject name is required");
                return false;
            }

            if (string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(name)) {
                MessageBox.Show("Subject code is required");
                return false;
            }

            return true;
        }
    }
}
