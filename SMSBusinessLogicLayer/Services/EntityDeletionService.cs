using SMSModels.Models;

namespace SMSBusinessLogicLayer.Services;

public class EntityDeletionService : IEntityDeletionService {
    private readonly IRepositoryFactory _repositoryFactory;

    public EntityDeletionService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
    }

    public string DeleteAnnouncement(Announcement announcement) {
        string message = string.Empty;

        try {
            var announcementRepo = _repositoryFactory.GetAnnouncementRepository();
            announcementRepo.Delete(announcement);
            message = "Announcement deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteAttendance(Attendance attendance) {
        string message = string.Empty;

        try {
            var attendanceRepo = _repositoryFactory.GetAttendanceRepository();
            attendanceRepo.Delete(attendance);
            message = "Attendance record deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteClass(Class @class) {
        string message = string.Empty;

        try {
            var classRepo = _repositoryFactory.GetClassRepository();
            classRepo.Delete(@class);
            message = "Class deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteCoordinator(Coordinator coordinator) {
        string message = string.Empty;

        try {
            var coordinatorRepo = _repositoryFactory.GetCoordinatorRepository();
            coordinatorRepo.Delete(coordinator);
            message = "Coordinator deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteCourse(Course course) {
        string message = string.Empty;

        try {
            var courseRepo = _repositoryFactory.GetCourseRepository();
            courseRepo.Delete(course);
            message = "Course deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteFaculty(Faculty faculty) {
        string message = string.Empty;

        try {
            var facultyRepo = _repositoryFactory.GetFacultyRepository();
            facultyRepo.Delete(faculty);
            message = "Faculty deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteFee(Fee fee) {
        string message = string.Empty;

        try {
            var feeRepo = _repositoryFactory.GetFeeRepository();
            feeRepo.Delete(fee);
            message = "Fee deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteRole(Role role) {
        string message = string.Empty;

        try {
            var roleRepo = _repositoryFactory.GetRoleRepository();
            roleRepo.Delete(role);
            message = "Role deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteStudent(Student student) {
        string message = string.Empty;

        try {
            var studentRepo = _repositoryFactory.GetStudentRepository();
            studentRepo.Delete(student);
            message = "Student deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteSubject(Subject subject) {
        string message = string.Empty;

        try {
            var subjectRepo = _repositoryFactory.GetSubjectRepository();
            subjectRepo.Delete(subject);
            message = "Subject deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteTeacher(Teacher teacher) {
        string message = string.Empty;

        try {
            var teacherRepo = _repositoryFactory.GetTeacherRepository();
            teacherRepo.Delete(teacher);
            message = "Teacher deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }

    public string DeleteTimetable(Timetable timetable) {
        string message = string.Empty;

        try {
            var timetableRepo = _repositoryFactory.GetTimetableRepository();
            timetableRepo.Delete(timetable);
            message = "Timetable deleted successfully";
        } catch (Exception ex) {
            message = ex.Message;
        }

        return message;
    }
}

