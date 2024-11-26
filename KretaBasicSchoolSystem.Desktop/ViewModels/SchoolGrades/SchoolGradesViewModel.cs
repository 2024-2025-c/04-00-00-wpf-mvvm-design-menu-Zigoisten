using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradesViewModel: BaseViewModel
    {
        private CurrentClassViewModel _currentClassViewModel;
        private TaughtClassesViewModel _taughtClassesViewModel;
        private SemesterEndViewModel _semesterEndViewModel;
        private SchoolYearEndViewModel _schoolYearEndViewModel;

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new CurrentClassViewModel();
            _currentClassViewModel = new CurrentClassViewModel();
            _taughtClassesViewModel = new TaughtClassesViewModel();
            _semesterEndViewModel = new SemesterEndViewModel();
            _schoolYearEndViewModel = new SchoolYearEndViewModel();
        }

        public SchoolGradesViewModel(CurrentClassViewModel currentClassViewModel, TaughtClassesViewModel taughtClassesViewModel, SemesterEndViewModel semesterEndViewModel, SchoolYearEndViewModel schoolYearEndViewModel)
        {
            _currentSchoolGradesChildView = currentClassViewModel;
            _currentClassViewModel = currentClassViewModel;
            _taughtClassesViewModel = taughtClassesViewModel;
            _semesterEndViewModel = semesterEndViewModel;
            _schoolYearEndViewModel = schoolYearEndViewModel;
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;

        [RelayCommand]
        public void ShowCurrentClassView()
        {
            CurrentSchoolGradesChildView = _currentClassViewModel;
        }

        [RelayCommand]
        public void ShowTaughtClassesView()
        {
            CurrentSchoolGradesChildView = _taughtClassesViewModel;
        }

        [RelayCommand]
        public void ShowSemesterEndView()
        {
            CurrentSchoolGradesChildView = _semesterEndViewModel;
        }

        [RelayCommand]
        public void ShowSchoolYearEndView()
        {
            CurrentSchoolGradesChildView = _schoolYearEndViewModel;
        }
    }
}
