namespace SMSDataLayer.Interfaces;

public interface IClassRepository : IRepository<Class> {
    public Dictionary<Class, ClassDTO> GetClassGridData();
    public HashSet<string> GetClassCodes();
    public void Update(Class @class);
}
