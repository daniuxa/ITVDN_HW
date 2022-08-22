namespace ProjectDomain
{
    public class Authors
    {
        public int Id { get; set; }
        
        public string FName { get; set; }
        public int SomeNum { get; set; }
        public int MyProperty { get; set; }
        public string? LName { get; set; }
        public List<Books>? books { get; set; }

        public Authors()
        {
            books = new List<Books>();
        }
    }
}