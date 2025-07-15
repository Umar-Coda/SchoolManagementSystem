
namespace SMSDataLayer.Interfaces {
    public interface IFacultyRepository : IRepository<Faculty> {
        public string FindDuplicateFacultyName(string facultyName);
        public Dictionary<Faculty, string> GetFacultyGridData();
       // public Dictionary<int, string> GetFacultyDropDownData();
        public HashSet<string> GetFacultyNames();
    }
}
