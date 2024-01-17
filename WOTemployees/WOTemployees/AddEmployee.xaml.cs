using WOTemployees.ViewModels;

namespace WOTemployees;

public partial class AddEmployee : ContentPage
{
	public AddEmployee(AddEmployeeViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}