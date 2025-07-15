using SMSModels.Models.Structs;

namespace SMSModels.DTOs;
public class TimetableRequestDTO {
    public int SemesterId { get; set; }
    public List<int> TeacherIds { get; set; } = [];
    public List<int> ClassIds { get; set; } = [];
    public List<TimeSlot> AvailableTimeSlots { get; set; } = [];
}
