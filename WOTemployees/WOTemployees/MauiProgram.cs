﻿using Microsoft.Extensions.Logging;
using WOTemployees.Services;
using WOTemployees.ViewModels;

namespace WOTemployees;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		// Services
		builder.Services.AddSingleton<IEmployeeService, EmployeeService>();

		// Views
		builder.Services.AddSingleton<EmployeesList>();
        builder.Services.AddTransient<AddEmployee>();
        builder.Services.AddTransient<StudentListPage>();
        builder.Services.AddTransient<StudentsDetailsPage>();


        // View Models
        builder.Services.AddSingleton<EmployeesViewModel>();	
        builder.Services.AddTransient<AddEmployeeViewModel>();
        builder.Services.AddTransient<StudentsListPageViewModel>();
        builder.Services.AddTransient<StudentsDetailsPageViewModel>();

        return builder.Build();
	}
}
