namespace SMSBusinessLogicLayer.Services {
    public class FacultyService : IFacultyService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IFacultyRepository _facultyRepository;

        private HashSet<string> _facultyNames;
        private Dictionary<Faculty, string> _facultyGridData;

        public FacultyService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
            _facultyRepository = _repositoryFactory.GetFacultyRepository();

            _facultyGridData = _facultyRepository.GetFacultyGridData();
            _facultyNames = _facultyRepository.GetFacultyNames();
        }

        // Dictionary<facultyId (int), facultyName (string)>
        public Dictionary<int, string> GetFacultyDropDownData() => _facultyGridData.ToDictionary(faculty => faculty.Key.FacultyId, 
            faculty => faculty.Key.FacultyName);

        public Dictionary<Faculty, string> GetFacultyGridData() => _facultyGridData;

        public HashSet<string> GetFacultyNames() => _facultyNames;

        public void Refresh() {
            _facultyGridData = _facultyRepository.GetFacultyGridData();
        }
    }
}
