
using SMSBusinessLogicLayer.DTOs;

namespace SMSControllers.AdminControllers {
    public class SubjectController {
        private readonly ISearchService _searchService;
        private readonly IEntityCreationService _creationService;
        private readonly ICheckDuplicateService _checkDuplicateService;

        public SubjectController(ISearchService searchService,
                                 IEntityCreationService creationService,
                                 ICheckDuplicateService checkDuplicateService) {
            _searchService = searchService;
            _creationService = creationService;
            _checkDuplicateService = checkDuplicateService;
        }

        public List<Subject> LoadSubjectData(string searchItem)
            => _searchService.SearchSubjects(searchItem);

        public OperationResult CreateSubject(Subject subject) {
            if (CheckSubjectCodeDuplicate(subject.SubjectCode))
                return new OperationResult {
                    Message = "Subject Code already exists"
                };

            var result = _creationService.AddSubject(subject);
            _searchService.RefreshSubjectSearch();

            return result;
        }

        private bool CheckSubjectCodeDuplicate(string subjectCode)
            => _checkDuplicateService.CheckDuplicateSubjectCode(subjectCode);
    }
}
