namespace SMSBusinessLogicLayer.Interfaces;
public interface IEntityDeletionService {
    public string DeleteSubject(Subject subject);
    public string DeleteCoordinator(Coordinator coordinator);
    public string DeleteTeacher(Teacher teacher);
    public string DeleteStudent(Student student);
    public string DeleteCourse(Course course);
    public string DeleteRole(Role role);
    public string DeleteAnnouncement(Announcement announcement);
    public string DeleteClass(Class @class);
    public string DeleteAttendance(Attendance attendance);
    public string DeleteTimetable(Timetable timetable);
    public string DeleteFaculty(Faculty faculty);
    public string DeleteFee(Fee fee);
}
