namespace SchoolManagementSystemDesktop.Controllers.AdminControllers;
public class CourseController {
    private readonly ICourseService _courseService;
    private readonly IFacultyService _facultyService;
    private readonly IEntityCreationService _entityCreationService;

    public CourseController(ICourseService courseService, IFacultyService faultyService, 
        IEntityCreationService entityCreationService) {
        _courseService = courseService;
        _facultyService = faultyService;
        _entityCreationService = entityCreationService;
    }

    public OperationResult CreateCourse(string courseCode, string courseName, int facultyId) {
        var result = _entityCreationService.AddCourse(new Course {
            CourseCode = courseCode,
            CourseName = courseName,
            FacultyId = facultyId
        });

        _courseService.Refresh();

        return result;
    }

    public List<CourseGridData> LoadCourseData(string searchItem) {
        Dictionary<Course, string> courseData = _courseService.GetCourseGridData();

        var result = courseData
            .Where(kv => string.IsNullOrEmpty(searchItem) ||
                            kv.Key.CourseCode.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                            kv.Key.CourseName.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                            kv.Value.Contains(searchItem, StringComparison.OrdinalIgnoreCase))
            .Select(kv => new CourseGridData {
                CourseCode = kv.Key.CourseCode,
                CourseName = kv.Key.CourseName,
                FacultyName = kv.Value
            })
            .ToList();

        return result;
    }

    //public OperationResult ValidateCourse(Course course) {

    //}

    public List<FacultySD> GetFacultySDs() {
        Dictionary<int, string> dropDownData = _facultyService.GetFacultyDropDownData();

        var result = dropDownData.Select(kv => new FacultySD {
            FacultyId = kv.Key,
            FacultyName = kv.Value,
        }).ToList();

        return result;
    }
}
