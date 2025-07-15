namespace SMSBusinessLogicLayer.Interfaces {
    public interface IFacultyService {
        public Dictionary<int, string> GetFacultyDropDownData();
        public Dictionary<Faculty, string> GetFacultyGridData();
        public HashSet<string> GetFacultyNames();
        public void Refresh();
    }
}
