using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementTool.Dto
{
    public class EmployeeDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]        
        public int PhoneNumber { get; set; }

        [Required]
        public CompanyInfoDto Company { get; set; }
    }
}
