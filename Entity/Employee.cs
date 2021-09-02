namespace Entity
{
    public class Employee : BaseEntity
    {        
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public CompanyInfo Company { get; set; }
    }
}
