namespace SMSBusinessLogicLayer.Interfaces {
    public interface ITeacherService {
        Dictionary<NameKey, List<Teacher>> GetTeacherGridData();

        Dictionary<int, string> GetTeacherDropDownData(string searchItem);

        void Refresh();
    }
}
