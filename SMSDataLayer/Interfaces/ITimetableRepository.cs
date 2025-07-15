namespace SMSDataLayer.Interfaces;
public interface ITimetableRepository : IRepository<Timetable> {
    public List<TeacherClass> GetTeacherClassAssignment(List<int> teacherIds);
    public void SaveTimetable(List<Timetable> timetables);
    public void SaveSlotTracking(List<SlotTracking> slotTrackings);
}
