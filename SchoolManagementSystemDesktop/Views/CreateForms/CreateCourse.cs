using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystemDesktop.Views.CreateForms {
    public partial class CreateCourse : Form {
        private readonly CourseController _courseController;

        private string _courseCode;
        private string _courseName;
        private int _facultyId;

        public CreateCourse(CourseController courseController) {
            InitializeComponent();
            _courseController = courseController;
            PopulateDropDownList();
        }

        private void lblFacultyName_Click(object sender, EventArgs e) {

        }

        private void createBtn_Click(object sender, EventArgs e) {
            _courseCode = txtCourseCode.Text;
            _courseName = txtCourseName.Text;

            _facultyId = (int)cmbFaculty.SelectedValue;

            if (_facultyId == 0) {
                MessageBox.Show("Error. Please select a faculty");
                return;
            }

            var result = _courseController.CreateCourse(_courseCode, _courseName, _facultyId);
            MessageBox.Show(result.Message);
        }

        private void PopulateDropDownList() {
            cmbFaculty.DataSource = _courseController.GetFacultySDs();
        }
    }
}
