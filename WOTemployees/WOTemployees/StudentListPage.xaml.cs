using WOTemployees.ViewModels;

namespace WOTemployees;

public partial class StudentListPage : ContentPage
{
	public StudentListPage(StudentsListPageViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext= viewModel;
	}
}