using WOTemployees.ViewModels;

namespace WOTemployees;

public partial class EmployeesList : ContentPage
{
	public EmployeesViewModel _viewmodel;
	public EmployeesList(EmployeesViewModel viewModel)
	{
		InitializeComponent();
		_viewmodel = viewModel;
		this.BindingContext= viewModel;
	}

    protected override void OnAppearing() 
    {
        base.OnAppearing();
		{
			_viewmodel.GetEmployeesListCommand.Execute(null);
		}
    }
}