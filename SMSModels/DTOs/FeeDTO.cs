using SMSModels.Models.Structs;

namespace SMSModels.DTOs;
public class FeeDTO {
    public FeeSummary Summary { get; set; }
    public string Message { get; set; }
}
