using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTemployees.Models;

namespace WOTemployees.Services
{
    public class EmployeeService : IEmployeeService
    {
        public SQLiteAsyncConnection _dbConnection;
        
        public EmployeeService() 
        {
            SetupDatabase();

        
        }
           
        private async void SetupDatabase()
        {
            if (_dbConnection == null)
            {
            string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db3");
            _dbConnection = new SQLiteAsyncConnection(dbpath);
            await _dbConnection.CreateTableAsync<Employee>();
            }
        }
        public Task<int> AddEmployee(Employee employee)
        {
            return _dbConnection.InsertAsync(employee);
        }

        public Task<int> DeleteEmployee(Employee employee)
        {
            return _dbConnection.DeleteAsync(employee);
        }

        public Task<List<Employee>> GetEmployeesList()
        {
            var employeeslist = _dbConnection.Table<Employee>().ToListAsync();
            return employeeslist;
        }

        public Task<int> UpdateEmployee(Employee employee)
        {
            return _dbConnection.UpdateAsync(employee);
        }

    }
}
