using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTemployees.Models;
using WOTemployees.Services;

namespace WOTemployees.ViewModels
{
    [QueryProperty(nameof(AddEmployee), "AddEmployee")]
    public partial class AddEmployeeViewModel : ObservableObject
    {

        [ObservableProperty]
        private Employee employeeDetails = new Employee();

        [ICommand]
        public async void AddEmployee()
        {
            var response = await _employeeService.AddEmployee(employeeDetails);
            if (response > 0) 
            {
                await Shell.Current.DisplayAlert("Record Added", "Employee Details Successfully submited", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Added", "Something went wrong with the Employees Details ", "OK");
            }
        }

        private readonly IEmployeeService _employeeService;

        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
    }
}
