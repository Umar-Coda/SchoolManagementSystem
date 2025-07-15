namespace SMSModels.Models.Structs;

public readonly struct FeeSummary {
    public decimal AmountDue { get; }
    public decimal AmountPaid { get; }

    public decimal Balance => AmountDue - AmountPaid;

    public FeeSummary(decimal amountDue, decimal amountPaid) {
        AmountDue = amountDue;
        AmountPaid = amountPaid;
    }
}
