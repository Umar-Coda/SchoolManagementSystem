namespace SMSBusinessLogicLayer.FeeCalculations;
public interface IFeeCalculator {
    FeeSummary Calculate(Fee fee);
}

