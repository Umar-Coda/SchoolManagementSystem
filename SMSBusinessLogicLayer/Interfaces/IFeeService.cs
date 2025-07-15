using SMSBusinessLogicLayer.FeeCalculations;

namespace SMSBusinessLogicLayer.Interfaces;
public interface IFeeService {
    public FeeDTO GetFeeSummary(int feeId, IFeeCalculator feeCalculator);
}

