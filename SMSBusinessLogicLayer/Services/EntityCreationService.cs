
using SMSBusinessLogicLayer.Interfaces;

namespace SMSBusinessLogicLayer.Services {
    /// <summary>
    /// Handles the creation of entity records
    /// </summary>
    public class EntityCreationService : IEntityCreationService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ISubjectService _subjectService;
        private readonly IFacultyService _facultyService;
        private readonly ICourseService _courseService;
        private readonly IClassService _classService;

        public EntityCreationService(IRepositoryFactory repositoryFactory, ISubjectService subjectService, 
            IFacultyService facultyService, ICourseService courseService, IClassService classService) {
            _repositoryFactory = repositoryFactory;
            _subjectService = subjectService;
            _facultyService = facultyService;
            _courseService = courseService;
            _classService = classService;
        }

        public OperationResult AddCourse(Course course)
        {
            ICourseRepository courseRepo = _repositoryFactory.GetCourseRepository();
            string message = string.Empty;

            try {
                courseRepo.Add(course);
                // _courseService.Refresh();
                message = "Course added successfully";
            } catch (Exception ex) {
                message = $"Failed to add course: {ex.Message}";
            }

            return new OperationResult { Message = message };
        }

        public OperationResult AddFaculty(Faculty faculty) {
            var facultyRepo = _repositoryFactory.GetFacultyRepository();
            string message = string.Empty;

            try {
                facultyRepo.Add(faculty);
                // _facultyService.Refresh();
                message = "Faculty added successfully";
            } catch (Exception ex) {
                message = $"Failed to add faculty: {ex.Message}";
            }

            return new OperationResult { Message = message };
        }

        public OperationResult AddSubject(Subject subject) {
            var subjectRepo = _repositoryFactory.GetSubjectRepository();
            var result = new OperationResult();

            try {
                subjectRepo.Add(subject);
                _subjectService.Refresh();
                result.Message = "Subject Added Successfully";
            } catch (Exception ex) {
                result.Message = $"Error while adding subject : {ex.Message}"; 
            }

            return result;
        }

        public OperationResult AddClass(Class @class) {
            var classRepo = _repositoryFactory.GetClassRepository();
            string message = string.Empty;

            try {
                classRepo.Add(@class);
                // _classService.Refresh()
                message = "Class added successfully";
            } catch (Exception ex) {
                message = $"Failed to add class {ex.Message}";
            }

            return new OperationResult { Message = message };
        }
    }
}
