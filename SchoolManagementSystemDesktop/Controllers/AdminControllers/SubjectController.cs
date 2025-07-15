namespace SchoolManagementSystemDesktop.AdminControllers {
    public class SubjectController {
        private readonly IEntityCreationService _creationService;
        private readonly ICheckDuplicateService _checkDuplicateService;
        private readonly ISubjectService _subjectService;

        public SubjectController(IEntityCreationService creationService,
                                 ICheckDuplicateService checkDuplicateService,
                                 ISubjectService subjectService) {
            _creationService = creationService;
            _checkDuplicateService = checkDuplicateService;
            _subjectService = subjectService;
        }

        public List<SubjectGridData> LoadSubjectData(string searchItem) {
            var subjects = _subjectService.GetSubjectGridData();

            var result = subjects
                .Where(kv => string.IsNullOrEmpty(searchItem) ||
                             kv.Key.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                             kv.Value.Contains(searchItem, StringComparison.OrdinalIgnoreCase))
                .Select(kv => new SubjectGridData {
                    SubjectCode = kv.Key,
                    SubjectName = kv.Value
                })
                .ToList();

            return result;
        }

        public OperationResult CreateSubject(Subject subject) {
            if (CheckSubjectCodeDuplicate(subject.SubjectCode))
                return new OperationResult { Message = "Subject Code already exists" };

            var result = _creationService.AddSubject(subject);

            return result;
        }

        private bool CheckSubjectCodeDuplicate(string subjectCode)
            => _checkDuplicateService.CheckDuplicateSubjectCode(subjectCode);
    }
}
