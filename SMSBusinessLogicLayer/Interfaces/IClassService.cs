namespace SMSBusinessLogicLayer.Interfaces;
public interface IClassService {
    public Dictionary<Class, ClassDTO> GetClassGridData();
    public HashSet<string> GetClassCodes();
    public Dictionary<int, string> GetClassDropDownData();
}

