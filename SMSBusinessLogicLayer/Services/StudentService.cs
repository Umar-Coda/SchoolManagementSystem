namespace SMSBusinessLogicLayer.Services {
    public class StudentService : IStudentService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IStudentRepository _studentRepository;

        private Dictionary<Student, StudentDTO> _studentGridData;
        private Dictionary<int, string> _studentDropDownData;

        public StudentService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
            _studentRepository = _repositoryFactory.GetStudentRepository();

            _studentGridData = _studentRepository.GetStudentGridData();
            _studentDropDownData = new Dictionary<int, string>();
        }

        public Dictionary<Student, StudentDTO> GetStudentGridData() => _studentGridData;

        // Dictionary: studentId --> fullname
        public Dictionary<int, string> GetStudentDropDownData(string searchItem) {
            _studentDropDownData.Clear();

            var filteredStudents = _studentGridData.Keys.Where(student =>
                string.IsNullOrWhiteSpace(searchItem) ||
                student.Firstname.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                student.Lastname.Contains(searchItem, StringComparison.OrdinalIgnoreCase));

            foreach (var student in filteredStudents) {
                var fullName = $"{student.Firstname} {student.Lastname}";
                if (!_studentDropDownData.ContainsKey(student.StudentId)) {
                    _studentDropDownData[student.StudentId] = fullName;
                }
            }

            return _studentDropDownData;
        }

        public void Refresh() {
            _studentGridData = _studentRepository.GetStudentGridData();
            _studentDropDownData.Clear();
        }
    }

}
