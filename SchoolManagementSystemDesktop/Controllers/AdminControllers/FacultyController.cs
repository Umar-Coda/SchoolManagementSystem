
namespace SchoolManagementSystemDesktop.AdminControllers;
public class FacultyController {
    private readonly IEntityCreationService _entityCreationService;
    private readonly ICheckDuplicateService _checkDuplicateService;
    private readonly IFacultyService _facultyService;
    private readonly ICoordinatorService _coordinatorService;

    public FacultyController(IEntityCreationService entityCreationService, 
        ICheckDuplicateService checkDuplicateService,
        IFacultyService facultyService,
        ICoordinatorService coordinatorService) {
        _entityCreationService = entityCreationService;
        _checkDuplicateService = checkDuplicateService;
        _facultyService = facultyService;
        _coordinatorService = coordinatorService;
    }

    public OperationResult CreateFaculty(string facultyName, int coordinatorId) {
        var result = _entityCreationService.AddFaculty(new Faculty {
            FacultyName = facultyName,
            CoordinatorId = coordinatorId
        });

        _facultyService.Refresh();

        return result;
    }

    public OperationResult CheckDuplicateFacultyName(string facultyName) {
        var isFacultyNameDuplicated = _checkDuplicateService.CheckDuplicateFacultyName(facultyName);

        if (isFacultyNameDuplicated)
            return new OperationResult { Message = "Faculty already exists", Error = true };

        return new OperationResult { 
            Message = string.Empty,
            Error = false
        };
    }

    public List<CoordinatorSD> GetCoordinatorSDs(string coordinatorName) {
        var dropDownData = _coordinatorService.GetCoordinatorDropDownData(coordinatorName);

        var result = dropDownData
            .Where(kv => string.IsNullOrWhiteSpace(coordinatorName) ||
                            kv.Value.Contains(coordinatorName, StringComparison.OrdinalIgnoreCase))
            .Select(kv => new CoordinatorSD {
                CoordinatorId = kv.Key,
                CoordinatorName = kv.Value
            })
            .ToList();

        return result;
    }

    public List<FacultyGridData> LoadFacultyData(string searchItem) {
        Dictionary<Faculty, string> facultyData = _facultyService.GetFacultyGridData();

        var result = facultyData
            .Where(kv => string.IsNullOrEmpty(searchItem) ||
                            kv.Key.FacultyName.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                            kv.Value.Contains(searchItem, StringComparison.OrdinalIgnoreCase))
            .Select(kv => new FacultyGridData {
                FacultyName = kv.Key.FacultyName,
                CoordinatorName = kv.Value
            })
            .ToList();

        return result;
    }
}
