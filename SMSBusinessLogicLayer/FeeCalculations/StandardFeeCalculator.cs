namespace SMSBusinessLogicLayer.FeeCalculations;
public class StandardFeeCalculator : IFeeCalculator {
    public FeeSummary Calculate(Fee fee)
        => new FeeSummary(fee.AmountDue, fee.AmountPaid);
}