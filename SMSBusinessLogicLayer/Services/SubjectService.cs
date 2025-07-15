namespace SMSBusinessLogicLayer.Services {
    public class SubjectService : ISubjectService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ISubjectRepository _subjectRepository;

        private HashSet<string> _subjectCodes;
        private Dictionary<string, string> _subjectGridData;

        public SubjectService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
            _subjectRepository = _repositoryFactory.GetSubjectRepository();

            _subjectCodes = _subjectRepository.GetSubjectCodes();
            _subjectGridData = _subjectRepository.GetSubjectGridData();
        }

        public HashSet<string> GetSubjectCodes() => _subjectCodes;

        public Dictionary<string, string> GetSubjectGridData() => _subjectGridData;

        public void Refresh() {
            _subjectCodes = _subjectRepository.GetSubjectCodes();
            _subjectGridData = _subjectRepository.GetSubjectGridData();
        }
    }
}
