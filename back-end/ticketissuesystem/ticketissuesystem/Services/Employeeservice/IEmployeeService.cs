
using ticketissuesystem.Models;

namespace ticketissuesystem.Services.Employeeservice
{
    public interface IEmployeeService
    {

        Task<ServiceResponse <List<GetEmployeeDto>>> GetAllEmployee();
        Task<ServiceResponse <GetEmployeeDto>> GetEmployeeById(int id);

        Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmplyeeDto updateEmplyee);

        Task<ServiceResponse<List<GetEmployeeDto>>>AddEmployee(AddEmployeeDto Employee);

        Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployee(int id);
       
    }
}
