namespace SMSDataLayer.Interfaces {
    public interface ICoordinatorRepository : IRepository<Coordinator> {
        //public string GetCoordinatorName(string id);
        public Dictionary<NameKey, List<Coordinator>> GetCoordinatorGridData();
        public void Update(Coordinator coordinator, Coordinator newCoordinator);
        public string GetCoordinatorName(int coordinatorId);
    }
}
