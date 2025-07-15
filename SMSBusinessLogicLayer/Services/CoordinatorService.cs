namespace SMSBusinessLogicLayer.Services;
public class CoordinatorService : ICoordinatorService{
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ICoordinatorRepository _coordinatorRepository;

    private Dictionary<NameKey, List<Coordinator>> _coordinatorGridData;
    private Dictionary<int, string> _coordinatorDropDownData;

    public CoordinatorService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
        _coordinatorRepository = _repositoryFactory.GetCoordinatorRepository();

        _coordinatorGridData = _coordinatorRepository.GetCoordinatorGridData();
        _coordinatorDropDownData = new Dictionary<int, string>();
    }

    public Dictionary<NameKey, List<Coordinator>> GetCoordinatorGridData() => _coordinatorGridData;

    // Dictionary: coordinatorId --> int, fullname --> string
    public Dictionary<int, string> GetCoordinatorDropDownData(string searchItem) {
        var coordinators = _coordinatorGridData.Values.SelectMany(list => list);

        foreach (var coordinator in coordinators) {
            var fullName = $"{coordinator.Firstname} {coordinator.Lastname}";

            if (string.IsNullOrWhiteSpace(searchItem)
                || coordinator.Firstname.Contains(searchItem, StringComparison.OrdinalIgnoreCase)
                || coordinator.Lastname.Contains(searchItem, StringComparison.OrdinalIgnoreCase)) {

                if (!_coordinatorDropDownData.ContainsKey(coordinator.CoordinatorId)) {
                    _coordinatorDropDownData[coordinator.CoordinatorId] = fullName;
                }
            }
        }

        return _coordinatorDropDownData;
    }

    public void Refresh() {
        _coordinatorGridData = _coordinatorRepository.GetCoordinatorGridData();
    }
}