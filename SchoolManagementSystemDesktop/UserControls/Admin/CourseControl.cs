
using SchoolManagementSystemDesktop.AdminControllers;
using System.ComponentModel;

namespace SchoolManagementSystemDesktop.UserControls.Admin;
public partial class CourseControl : UserControl {
    private readonly CourseController _courseController;

    public CourseControl(CourseController courseController) {
        InitializeComponent();
        _courseController = courseController;
        LoadCourseGrid();
    }

    private void searchBtn_Click(object sender, EventArgs e) {
        string searchItem = txtSearch.Text.Trim().ToLower();
        var courses = _courseController.LoadCourseData(searchItem);
        UpdateCourseGrid(courses);
    }

    private void LoadCourseGrid() {
        var courses = _courseController.LoadCourseData(string.Empty);
        UpdateCourseGrid(courses);
    }

    private void UpdateCourseGrid(List<CourseGridData> courses) {
        var bindingList = new BindingList<CourseGridData>(courses);
        courseDvg.DataSource = null;
        courseDvg.DataSource = bindingList;
    }

    private void addBtn_Click(object sender, EventArgs e) {
        var createCourseView = new CreateCourse(_courseController);

        try {
            createCourseView.Show();
        } catch (Exception ex) {
            MessageBox.Show($"Failed to open form: {ex.Message}");
        }
    }

    private void editBtn_Click(object sender, EventArgs e) {

    }

    private void deleteBtn_Click(object sender, EventArgs e) {

    }
}
