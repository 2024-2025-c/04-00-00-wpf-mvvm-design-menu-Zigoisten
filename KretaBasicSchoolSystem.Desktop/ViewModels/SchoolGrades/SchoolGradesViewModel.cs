using CommunityToolkit.Mvvm.ComponentModel;
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
        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;
    }
}
