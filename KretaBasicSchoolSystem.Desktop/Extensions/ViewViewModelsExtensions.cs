﻿using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.Users;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.Users;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // School Citizens
            // Students
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });

            // School Citizens
            // Teachers
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });

            // School Citizens
            // Parents
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });

            // School Class
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });

            // Subjects
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            // Grades
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });

            // Grades
            // Curent Class
            services.AddSingleton<CurrentClassViewModel>();
            services.AddSingleton<CurrentClassView>(s => new CurrentClassView()
            {
                DataContext = s.GetRequiredService<CurrentClassViewModel>()
            });

            //Grades
            //Taught Classes
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton<TaughtClassesView>(s => new TaughtClassesView()
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()
            });

            //Grades
            //Semester End
            services.AddSingleton<SemesterEndViewModel>();
            services.AddSingleton<SemesterEndView>(s => new SemesterEndView()
            {
                DataContext = s.GetRequiredService<SemesterEndViewModel>
            });

            //Grades
            //School Year End
            services.AddSingleton<SchoolYearEndViewModel>();
            services.AddSingleton<SchoolYearEndView>(s => new SchoolYearEndView()
            {
                DataContext = s.GetRequiredService<SchoolYearEndViewModel>
            });

            //Users
            services.AddSingleton<UsersViewModel>();
            services.AddSingleton<UsersView>(s => new UsersView()
            {
                DataContext = s.GetRequiredService<UsersViewModel>
            });

            //Users
            //User
            services.AddSingleton<UserViewModel>();
            services.AddSingleton<UserView>(s => new UserView()
            {
                DataContext = s.GetRequiredService<UserViewModel>
            });

            //Users
            //Admin
            services.AddSingleton<AdminViewModel>();
            services.AddSingleton<AdminView>(s => new AdminView()
            {
                DataContext = s.GetRequiredService<AdminViewModel>
            });

            //Users
            services.AddSingleton<SellerViewModel>();
            services.AddSingleton<SellerView>(s => new SellerView()
            {
                DataContext = s.GetRequiredService<SellerViewModel>
            });
        }
    }
}
