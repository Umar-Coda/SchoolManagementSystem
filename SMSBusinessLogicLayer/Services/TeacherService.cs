namespace SMSBusinessLogicLayer.Services {
    public class TeacherService : ITeacherService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ITeacherRepository _teacherRepository;

        private Dictionary<NameKey, List<Teacher>> _teacherGridData;
        private Dictionary<int, string> _teacherDropDownData;

        public TeacherService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
            _teacherRepository = _repositoryFactory.GetTeacherRepository();

            _teacherGridData = _teacherRepository.GetTeacherGridData();
            _teacherDropDownData = new Dictionary<int, string>();
        }

        public Dictionary<NameKey, List<Teacher>> GetTeacherGridData() => _teacherGridData;

        // Dictionary: teacherId --> fullname
        public Dictionary<int, string> GetTeacherDropDownData(string searchItem) {
            var teachers = _teacherGridData.Values.SelectMany(list => list);

            foreach (var teacher in teachers) {
                var fullName = $"{teacher.Firstname} {teacher.Lastname}";

                if (string.IsNullOrWhiteSpace(searchItem)
                    || teacher.Firstname.Contains(searchItem, StringComparison.OrdinalIgnoreCase)
                    || teacher.Lastname.Contains(searchItem, StringComparison.OrdinalIgnoreCase)) {

                    if (!_teacherDropDownData.ContainsKey(teacher.TeacherId)) {
                        _teacherDropDownData[teacher.TeacherId] = fullName;
                    }
                }
            }

            return _teacherDropDownData;
        }

        public void Refresh() {
            _teacherGridData = _teacherRepository.GetTeacherGridData();
            _teacherDropDownData.Clear();
        }
    }

}
