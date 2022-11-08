namespace CarShowroomDomain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; } = String.Empty;

        public List<HeadManager> HeadManagers { get; set; } = new();

        public List<Worker> Workers { get; set; } = new();
    }
}
