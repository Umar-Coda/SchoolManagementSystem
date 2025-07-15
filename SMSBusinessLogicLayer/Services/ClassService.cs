namespace SMSBusinessLogicLayer.Services;

public class ClassService : IClassService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly HashSet<string> _classCodes;
    private readonly Dictionary<Class, ClassDTO> _classGridData;

    public ClassService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
        _classCodes = _repositoryFactory.GetClassRepository().GetClassCodes();
        _classGridData = _repositoryFactory.GetClassRepository().GetClassGridData();
    }

    public HashSet<string> GetClassCodes()
        => _classCodes;

    public Dictionary<Class, ClassDTO> GetClassGridData()
        => _classGridData;

    public Dictionary<int, string> GetClassDropDownData()
        => _classGridData.ToDictionary(
            @class => @class.Key.ClassId,
            @class => @class.Key.ClassCode);
}
