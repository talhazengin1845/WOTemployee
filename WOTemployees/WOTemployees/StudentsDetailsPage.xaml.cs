using WOTemployees.ViewModels;

namespace WOTemployees;

public partial class StudentsDetailsPage : ContentPage
{
	public StudentsDetailsPage(StudentsDetailsPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel; 
	}
}