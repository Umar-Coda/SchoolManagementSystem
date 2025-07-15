namespace SMSDataLayer.Repositories;
public class TimetableRepository : BaseRepository<Timetable>, ITimetableRepository {
    private readonly DbSet<TeacherClass> _teacherClassSet;
    private readonly DbSet<SlotTracking> _slotTrackingSet;

    public TimetableRepository(SchoolContext context) : base(context) {
        _teacherClassSet = context.Set<TeacherClass>();
        _slotTrackingSet = context.Set<SlotTracking>();
    }

    public List<TeacherClass> GetTeacherClassAssignment(List<int> teacherIds) {
        return _teacherClassSet
            .Include(tc => tc.Teacher)
            .Include(tc => tc.Class)
            .Where(tc => teacherIds.Contains(tc.TeacherId))
            .ToList();
    }

    public void SaveTimetable(List<Timetable> timetables) {
        _dbSet.AddRange(timetables);
        _context.SaveChanges();
    }

    public void SaveSlotTracking(List<SlotTracking> slotTrackings) {
        _slotTrackingSet.AddRange(slotTrackings);
        _context.SaveChanges();
    }
}
