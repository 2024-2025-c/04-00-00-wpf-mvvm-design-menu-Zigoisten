using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;
        private TeacherViewModel _teacherViewModel;
        private ParentViewModel _parentViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
            _currentSchoolCitizensTeacherView = new StudentViewModel();
            _teacherViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel)
        {
            _studentViewModel = studentViewModel;

            _currentSchoolCitizensChildView= new StudentViewModel();
        }

        public SchoolCitizensViewModel(TeacherViewModel teacherViewModel)
        {
            _teacherViewModel= teacherViewModel;

            _currentSchoolCitizensTeacherView = new TeacherViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensTeacherView;

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensParentView;
    }
}
