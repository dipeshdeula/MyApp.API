using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _appContext;
        public EmployeeRepository(ApplicationDbContext appContext) {
            _appContext = appContext;
        }

        public async Task<IEnumerable<EmployeeEntity>>GetEmployees()
        {
            return await _appContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id)
        {
            return await _appContext.Employees.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee)
        {
            employee.Id = Guid.NewGuid();
            _appContext.Employees.Add(employee);
            await _appContext.SaveChangesAsync();
            return employee;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity employee) 
        {
            var employeeData = await _appContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employeeData !=null)
            {
                employeeData.Name = employee.Name;
                employeeData.Email = employee.Email;
                employeeData.Phone = employee.Phone;

                await _appContext.SaveChangesAsync();
                return employeeData;

            }

            return employee;

        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            var employeeData = await _appContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employeeData != null)
            {
                _appContext.Employees.Remove(employeeData);
               return await _appContext.SaveChangesAsync() > 0;
              
            }

            return false;
        }
    }
}
