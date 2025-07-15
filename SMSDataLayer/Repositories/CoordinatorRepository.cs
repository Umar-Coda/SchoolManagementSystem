namespace SMSDataLayer.Repositories;
/// <summary>
/// Handle specific database operations related to entity Coordinators
/// </summary>
public class CoordinatorRepository : BaseRepository<Coordinator>, ICoordinatorRepository {
    public CoordinatorRepository(SchoolContext context) : base(context) { }

    public Dictionary<NameKey, List<Coordinator>> GetCoordinatorGridData() {
        var data = new Dictionary<NameKey, List<Coordinator>>();
        data = _dbSet.GroupBy(coordinator => new NameKey(coordinator.Firstname, coordinator.Lastname))
            .ToDictionary(g => g.Key, g => g.ToList());
        return data;
    }

    public string GetCoordinatorName(int coordinatorId) {
        var coordinatorName = _dbSet.Where(coordinator => coordinator.CoordinatorId == coordinatorId)
            .Select(coordinator => $"{coordinator.Firstname} {coordinator.Lastname}").FirstOrDefault();

        return coordinatorName;
    }

    public void Update(Coordinator coordinator, Coordinator newCoordinator) {
        throw new NotImplementedException();
    }
}
