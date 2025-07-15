
using SchoolManagementSystemDesktop.AdminControllers;
using System.ComponentModel;

namespace SchoolManagementSystemDesktop.UserControls.Admin;
public partial class FacultyControl : UserControl {
    private readonly FacultyController _facultyController;

    public FacultyControl(FacultyController facultyController) {
        InitializeComponent();
        _facultyController = facultyController;
        LoadFacultyGrid();
    }

    private void mainLayout_Paint(object sender, PaintEventArgs e) {

    }

    private void FacultyControl_Resize(object sender, EventArgs e) {
        facultyDVG.Height = this.Height - (header.Height + operationLayout.Height + 40); // 40 is padding

        // Adjust button widths equally within the FlowLayoutPanel
        int buttonCount = buttonLayout.Controls.Count;
        int totalButtonLayoutWidth = buttonLayout.Width;
        int buttonWidth = buttonCount > 0 ? totalButtonLayoutWidth / buttonCount - 10 : 150;

        foreach (Control btn in buttonLayout.Controls) {
            btn.Width = buttonWidth;
            btn.Height = 60;
        }

        // Ensure the DataGridView columns scale properly
        facultyDVG.Columns[0].Width = facultyDVG.Width / 2;
        facultyDVG.Columns[1].Width = facultyDVG.Width / 2;
    }

    private void searchBtn_Click(object sender, EventArgs e) {
        string searchItem = txtSearchBar.Text.Trim().ToLower();
        var faculties = _facultyController.LoadFacultyData(searchItem);
        UpdateFacultyGrid(faculties);
    }

    private void LoadFacultyGrid() {
        var faculties = _facultyController.LoadFacultyData(string.Empty);
        UpdateFacultyGrid(faculties);
    }

    private void UpdateFacultyGrid(List<FacultyGridData> faculties) {
        var bindingList = new BindingList<FacultyGridData>(faculties);
        facultyDVG.DataSource = null;
        facultyDVG.DataSource = bindingList;
    }

    private void addBtn_Click(object sender, EventArgs e) {
        var createFacultyForm = new CreateFaculty(_facultyController);

        try {
            createFacultyForm.Show();
        } catch (Exception ex) {
            MessageBox.Show($"Failed to open form: {ex.Message}");
        }
    }

    private void editBtn_Click(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {

    }
}
