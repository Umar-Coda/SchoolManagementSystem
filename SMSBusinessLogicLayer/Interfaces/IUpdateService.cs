namespace SMSBusinessLogicLayer.Interfaces {
    public interface IUpdateService {
        string UpdateClass(Class @class);
        string UpdateCourse(Course course);
        string UpdateFaculty(Faculty faculty);
        string UpdateFee(Fee fee);
        string UpdateStudent(Student student);
        string UpdateTeacher(Teacher teacher);
        string UpdateCoordinator(Coordinator coordinator);
        string UpdateSubject(Subject subject);
        string UpdateTimetable(Timetable timetable);
        string UpdateAnnouncement(Announcement announcement);
        string UpdateAttendance(Attendance attendance);
        string UpdateRole(Role role);
    }
}
