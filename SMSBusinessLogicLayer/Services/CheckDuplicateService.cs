namespace SMSBusinessLogicLayer.Services {
    internal class CheckDuplicateService : ICheckDuplicateService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ISubjectService _subjectService;
        private readonly IUserAccountService _userAccountService;
        private readonly IFacultyService _facultyService;
        private readonly ICourseService _courseService;

        public CheckDuplicateService(IRepositoryFactory repositoryFactory, ISubjectService subjectService,
            IUserAccountService userAccountService, IFacultyService facultyService, ICourseService courseService)
        {
            _repositoryFactory = repositoryFactory;
            _subjectService = subjectService;
            _userAccountService = userAccountService;
            _facultyService = facultyService;
            _courseService = courseService;
        }

        public bool CheckDuplicateCourseCode(string courseCode)
        {
            HashSet<string> courseCodes = _courseService.GetCourseCodes();

            if (courseCodes.Contains(courseCode))
                return true;

            return false;
        }

        public bool CheckDuplicateFacultyName(string facultyName) {
            HashSet<string> facultyNames = _facultyService.GetFacultyNames();

            if (facultyNames.Contains(facultyName))
                return true;

            return false;
        }

        public bool CheckDuplicateSubjectCode(string subjectCode) {
            HashSet<string> codes = _subjectService.GetSubjectCodes();

            if (codes.Contains(subjectCode))
                return true;

            return false;
        }

        public bool CheckDuplicateUsername(string username)
        {
            HashSet<string> usernames = _userAccountService.GetUsernames();

            if (usernames.Contains(username))
                return true;

            return false;
        }
    }
}
