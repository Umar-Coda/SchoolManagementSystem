namespace SMSBusinessLogicLayer.FeeCalculations;
public class DiscountFeeCalculator : IFeeCalculator {
    private readonly decimal _discountPercent;

    public DiscountFeeCalculator(decimal discountPercent = 0.10m) {
        _discountPercent = discountPercent;
    }

    public FeeSummary Calculate(Fee fee) {
        var discountedAmountDue = fee.AmountDue * (1 - _discountPercent);
        return new FeeSummary(discountedAmountDue, fee.AmountPaid);
    }
}

