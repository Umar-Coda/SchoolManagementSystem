namespace SMSBusinessLogicLayer.Interfaces;
public interface ICourseService
{
    public Dictionary<Course, string> GetCourseGridData();
    //public Dictionary<int, string> GetCourseDropDownData(string searchItem);
    public HashSet<string> GetCourseCodes();
    public void Refresh();
}
