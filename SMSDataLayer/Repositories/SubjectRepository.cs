namespace SMSDataLayer.Repositories {
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository {
        public SubjectRepository(SchoolContext context) : base(context) { }

        public Dictionary<string, string> GetSubjectGridData() {
            var data = new Dictionary<string, string>();

            data = _dbSet.ToDictionary(
                    subject => subject.SubjectCode,
                    subject => subject.SubjectName
                );

            return data;
        }

        public string FindDuplicateSubjectCode(string subjectCode) {
            return _dbSet
                .Where(s => s.SubjectCode.ToLower() == subjectCode.ToLower())
                .Select(s => s.SubjectCode)
                .FirstOrDefault() ?? string.Empty;
        }

        public HashSet<string> GetSubjectCodes() {
            var data = new HashSet<string>();
            data = _dbSet.Select(s => s.SubjectCode).ToHashSet();
            return data;
        }
    }
}
