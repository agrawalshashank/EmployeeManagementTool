using EmployeeManagementTool.Dto;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace EmployeeManagementTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeController>
        [HttpGet("GetAllEmployees")]
        public IActionResult Get()
        {
            return Ok(_employeeService.GetAllEmployees());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("GetEmployee/{employeeName}")]
        public IActionResult Get(int id)
        {
            return Ok(_employeeService.GetEmployee(id));
        }

        // POST api/<EmployeeController>
        [HttpPost("CreateEmployee")]
        public IActionResult Post([FromBody] EmployeeDto employeedto)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _employeeService.CreateEmployee(CreateEmployeeObject(employeedto));
            return Ok();
        }

        private static Employee CreateEmployeeObject(EmployeeDto employeedto)
        {
            //We can use automapper also
            return new Employee
            {
                Name = employeedto.Name,
                Designation = employeedto.Designation,
                Company = new CompanyInfo { Name = employeedto.Company.Name, Address = employeedto.Company.Address },
                Email = employeedto.Email,
                PhoneNumber = employeedto.PhoneNumber
            };
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("UpdateEmployee/{employeeName}")]
        public IActionResult Put(int id, [FromBody] EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            _employeeService.UpdateEmployee(id, CreateEmployeeObject(employeeDto));
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("DeleteEmployee/{employeeName}")]
        public IActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
