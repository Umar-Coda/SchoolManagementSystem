namespace SMSBusinessLogicLayer.Interfaces;
public interface ICoordinatorService {
    public Dictionary<NameKey, List<Coordinator>> GetCoordinatorGridData();
    public Dictionary<int, string> GetCoordinatorDropDownData(string searchItem);
    public void Refresh();
}
