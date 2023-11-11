using Microsoft.AspNetCore.Mvc;
using ticketissuesystem.Dtos.Employees;
using ticketissuesystem.Services.Employeeservice;

namespace ticketissuesystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }



        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>> GetAll()
        {
            return Ok(await _employeeService.GetAllEmployee());

        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>>AddteEmployee(AddEmployeeDto addEmployee)
        {
            return  Ok(await _employeeService.AddEmployee(addEmployee));
        }



        [HttpGet("Getemployee/{id}")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeDto>>>GetEmployee(int id)
        {
            return Ok(await _employeeService.GetEmployeeById(id));
        }


       [HttpPut]
       public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>> UpdatedEmployee(UpdateEmplyeeDto updateEmplyee)
        {
            var response = await _employeeService.UpdateEmployee(updateEmplyee);
            if(response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
           
            
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeDto>>> DeleteEmployee(int id)
        {
            var response = await _employeeService.DeleteEmployee(id);
            if(response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
