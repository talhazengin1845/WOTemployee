namespace WOTemployees;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AddEmployee), typeof(AddEmployee));
        Routing.RegisterRoute(nameof(StudentListPage), typeof(StudentListPage));
        Routing.RegisterRoute(nameof(StudentsDetailsPage), typeof(StudentsDetailsPage));

    }
}
