
namespace SMSDataLayer.Repositories;
public class FacultyRepository : BaseRepository<Faculty>, IFacultyRepository {
    private readonly IRepositoryFactory _repositoryFactory;
    // private readonly ICoordinatorRepository _coordinatorRepository;

    public FacultyRepository(SchoolContext context, IRepositoryFactory repositoryFactory) : base(context) {
        _repositoryFactory = repositoryFactory;
        // _coordinatorRepository = _repositoryFactory.GetCoordinatorRepository();
    }

    public string? FindDuplicateFacultyName(string facultyName) {
        return _dbSet.Where(faculty => faculty.FacultyName == facultyName)
            .Select(faculty => facultyName).FirstOrDefault();
    }

    public Dictionary<Faculty, string> GetFacultyGridData() {
        var data = new Dictionary<Faculty, string>();

        data = _dbSet
            .Include(faculty => faculty.Coordinator)
            .ToDictionary(
                faculty => faculty,
                faculty => $"{faculty.Coordinator.Firstname} {faculty.Coordinator.Lastname}"
            );

        return data;
    }

    public HashSet<string> GetFacultyNames() {
        var data = new HashSet<string>();
        data = _dbSet.Select(faculty => faculty.FacultyName).ToHashSet();
        return data;
    }
}
