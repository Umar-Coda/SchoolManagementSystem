namespace SMSBusinessLogicLayer.Services;

public class CourseService : ICourseService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ICourseRepository _courseRepository;
    private HashSet<string> _courseCodes;
    private Dictionary<Course, string> _courseGridData;
    //private Dictionary<int, string> _courseDropDownData;

    public CourseService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
        _courseRepository = _repositoryFactory.GetCourseRepository();
        
        _courseCodes = _courseRepository.GetCourseCodes();
        _courseGridData = _courseRepository.GetCourseGridData();
        // _courseDropDownData = new Dictionary<int, string>();
    }

    // Dictionary<CourseCode (int), Course>
    public Dictionary<Course, string> GetCourseGridData() => _courseGridData;

    //public Dictionary<int, string> GetCourseDropDownData(string searchItem) {
    //     _courseDropDownData = _courseGridData
    //        .Where(kv => string.IsNullOrEmpty(searchItem) ||
    //                kv.Key.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
    //                kv.Value.CourseName.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
    //                kv.Value.Faculty.FacultyName.Contains(searchItem, StringComparison.OrdinalIgnoreCase))
    //        .ToDictionary(
    //            kv => kv.Value.CourseId,
    //            kv => $"{kv.Value.CourseCode} - {kv.Value.CourseName} ({kv.Value.Faculty.FacultyName})"
    //        );

    //    return _courseDropDownData;
    //}

    public HashSet<string> GetCourseCodes() => _courseCodes;

    public void Refresh() {
        _courseCodes = _courseRepository.GetCourseCodes();
        _courseGridData = _courseRepository.GetCourseGridData();
    }
}
