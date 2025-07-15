
namespace SMSBusinessLogicLayer.Interfaces {
    public interface IPersonRegistrationService {
        public OperationResult RegisterCoordinator(Coordinator coordinator);
        public OperationResult RegisterTeacher(Teacher teacher);
        public OperationResult RegisterStudent(Student student);
    }
}
