﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTemployees.Models;

namespace WOTemployees.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesList();

        Task<int> AddEmployee(Employee employee);
        Task<int> DeleteEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employee);
    }
}
