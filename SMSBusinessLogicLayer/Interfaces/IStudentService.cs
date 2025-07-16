namespace SMSBusinessLogicLayer.Interfaces {
    public interface IStudentService {
        Dictionary<Student, StudentDTO> GetStudentGridData();

        Dictionary<int, string> GetStudentDropDownData(string searchItem);

        void Refresh();
    }
}
