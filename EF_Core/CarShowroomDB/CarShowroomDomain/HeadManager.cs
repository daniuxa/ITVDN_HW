namespace CarShowroomDomain
{
    public class HeadManager : Worker
    {
        public List<Department> ManagedDepartments { get; set; } = new();

        public string Email { get; set; } = String.Empty;
    }
}
