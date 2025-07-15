using System.ComponentModel;

namespace SchoolManagementSystemDesktop.UserControls.Admin;
public partial class CoordinatorControl : UserControl {
    private readonly CoordinatorController _coordinatorController;
    private readonly PersonRegistrationValidation _validator;

    public CoordinatorControl(CoordinatorController coordinatorController,
        PersonRegistrationValidation validator) {
        InitializeComponent();
        coordinatorDVG.AutoGenerateColumns = false;

        _coordinatorController = coordinatorController;
        _validator = validator;

        LoadCoordinatorGrid();
    }

    private void addBtn_Click(object sender, EventArgs e) {
        var createCoordinatorView = new CreateCoordinator(_validator, _coordinatorController);
        try {
            createCoordinatorView.Show();
        } catch (Exception ex) {
            MessageBox.Show($"Error opening form: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void editBtn_Click(object sender, EventArgs e) {
        var editCoordinatorView = new EditCoordinator();
        try {
            editCoordinatorView.Show();
        } catch (Exception ex) {
            MessageBox.Show($"Error opening form: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void deleteBtn_Click(object sender, EventArgs e) {

    }

    private void searchBtn_Click(object sender, EventArgs e) {
        string searchItem = txtSearch.Text.Trim().ToLower();
        var coordinatorDTOs = _coordinatorController.LoadCoordinatorData(searchItem);
        List<CoordinatorGridData> coordinators = new List<CoordinatorGridData>();

        foreach (var coordinatorDTO in coordinatorDTOs) {
            coordinators.Add(new CoordinatorGridData {
                Name = coordinatorDTO.Firstname + " " + coordinatorDTO.Lastname,
                HireDate = coordinatorDTO.HireDate,
                Gender = coordinatorDTO.Gender,
                Email = coordinatorDTO.Email,
                BirthDate = coordinatorDTO.BirthDate,
                PhoneNumber = coordinatorDTO.PhoneNumber
            });
        }

        UpdateCoordinatorGrid(coordinators);
    }

    private void LoadCoordinatorGrid() {
        var coordinatorDTOs = _coordinatorController.LoadCoordinatorData(string.Empty);

        List<CoordinatorGridData> coordinators = new List<CoordinatorGridData>();

        foreach (var coordinatorDTO in coordinatorDTOs) {
            coordinators.Add(new CoordinatorGridData {
                Name = coordinatorDTO.Firstname + " " + coordinatorDTO.Lastname,
                HireDate = coordinatorDTO.HireDate,
                Gender = coordinatorDTO.Gender,
                Email = coordinatorDTO.Email,
                BirthDate = coordinatorDTO.BirthDate,
                PhoneNumber = coordinatorDTO.PhoneNumber
            });
        }

        UpdateCoordinatorGrid(coordinators);
    }

    private void UpdateCoordinatorGrid(List<CoordinatorGridData> coordinators) {
        var bindingList = new BindingList<CoordinatorGridData>(coordinators);
        coordinatorDVG.DataSource = null;
        coordinatorDVG.DataSource = bindingList;
    }
}