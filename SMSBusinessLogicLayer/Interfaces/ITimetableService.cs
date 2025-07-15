namespace SMSBusinessLogicLayer.Interfaces;
public interface ITimetableService {
    public List<Timetable> GenerateTimetable(TimetableRequestDTO request);
}

