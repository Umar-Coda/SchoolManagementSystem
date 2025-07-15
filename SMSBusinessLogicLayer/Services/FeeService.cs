using SMSBusinessLogicLayer.FeeCalculations;

namespace SMSBusinessLogicLayer.Services;
public class FeeService : IFeeService {
    private readonly IRepositoryFactory _repositoryFactory;
    
    public FeeService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
    }

    public FeeDTO GetFeeSummary(int feeId, IFeeCalculator feeCalculator) {
        var feeRepo = _repositoryFactory.GetFeeRepository();

        try {
            var fee = feeRepo.Get(feeId);

            if (fee == null)
                return new FeeDTO { Message = "Fee not found" };

            return new FeeDTO { 
                Summary = feeCalculator.Calculate(fee),
                Message = "Success"
            };
        } catch (Exception ex) {
            return new FeeDTO { Message = ex.Message };
        }
    }
}
