namespace CarShowroomDomain
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string FName { get; set; } = String.Empty;
        public string MName { get; set; } = String.Empty;
        public string LName { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; } = null!;
        public int DepartmentId { get; set; }

        //public List<Department> HeadOfDepartments { get; set; }
        public List<Order> Orders { get; set; } = new();
        public List<CarShowroom> CarShowrooms { get; set; } = new();
    }
}
