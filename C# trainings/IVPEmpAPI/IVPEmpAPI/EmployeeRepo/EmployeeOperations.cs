using EmpDataAccess.Data;
using EmpModels.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace IVPEmpAPI.EmployeeRepo;

public class EmployeeOperations : IEmployee
{
    AppDbContext _context;
    public EmployeeOperations(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Employee>> GetAllEmployees()
    {
        var employees = await _context.Employees.ToListAsync();

        return employees;
    }

    public async Task<Employee> GetEmployeeByID(int ID)
    {
        return await _context.Employees.FindAsync(ID);
    }

    public async Task<int> AddEmployee(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();

        return employee.EID;
    }

    public async Task<string> DeleteEmployee(int id)
    {
        var data = await _context.Employees.FindAsync(id);

        _context.Employees.Remove(data);
        await _context.SaveChangesAsync();

        return "Employee Deleted Successfully";
    }

    public async Task<string> UpdateEmployee(Employee employee, int id)
    {
        var data = await _context.Employees.FindAsync(id);

        if (data != null)
        {
            data.Name = employee.Name;
            data.Salary = employee.Salary;
            data.Designation = employee.Designation;

            await _context.SaveChangesAsync();

            return "Employee Data has been updated successfully";
        }
        else
        {
            return "No Such Employee Exists.";
        }
    }

    public async Task<string> UpdateEmployeeSalary(int id, JsonPatchDocument patch)
    {
        var data = await _context.Employees.FindAsync(id);

        if (data != null)
        {
            patch.ApplyTo(data);
            await _context.SaveChangesAsync();

            return "Salary has been updated.";
        }
        else
        {
            return "No such Employee exists.";
        }
    }
}
