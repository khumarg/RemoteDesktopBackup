using EmpModels.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace IVPEmpAPI.EmployeeRepo
{
    public interface IEmployee
    {
        public Task<List<Employee>> GetAllEmployees();
        public Task<Employee> GetEmployeeByID(int ID);
        public Task<int> AddEmployee(Employee employee);
        public Task<string> DeleteEmployee(int id);
        public Task<string> UpdateEmployee(Employee employee, int id);
        public Task<string> UpdateEmployeeSalary(int id, JsonPatchDocument patch);
    }
}
