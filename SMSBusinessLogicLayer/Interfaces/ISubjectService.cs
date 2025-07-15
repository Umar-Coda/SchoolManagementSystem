namespace SMSBusinessLogicLayer.Interfaces {
    public interface ISubjectService {
        public HashSet<string> GetSubjectCodes();
        public Dictionary<string, string> GetSubjectGridData();
        public void Refresh();
    }
}
