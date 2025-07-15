namespace SMSBusinessLogicLayer.Interfaces;
public interface IEntityCreationService {
    public OperationResult AddSubject(Subject subject);
    public OperationResult AddFaculty(Faculty faculty);
    public OperationResult AddCourse(Course course);
}
