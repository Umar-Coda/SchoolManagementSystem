
namespace SMSDataLayer.Repositories;
public class FeeRepository : BaseRepository<Fee>, IFeeRepository {
    public FeeRepository(SchoolContext context) : base(context) {
    }
}

