using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementTool.Dto
{
    public class CompanyInfoDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}