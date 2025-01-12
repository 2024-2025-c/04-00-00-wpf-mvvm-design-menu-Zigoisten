using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.Users;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Users
{
    public partial class UsersViewModel: BaseViewModel
    {
        private UserViewModel _userViewModel;
        private AdminViewModel _adminViewModel;
        private SellerViewModel _sellerViewModel;

        public UsersViewModel()
        {
            _currentUsersChildView = new UserViewModel();
            _userViewModel = new UserViewModel();
            _adminViewModel = new AdminViewModel();
            _sellerViewModel = new SellerViewModel();
        }

        public UsersViewModel(UserViewModel userViewModel, AdminViewModel adminViewModel, SellerViewModel sellerViewModel)
        {
            _currentUsersChildView = userViewModel;

            _userViewModel = userViewModel;
            _adminViewModel = adminViewModel;
            _sellerViewModel = sellerViewModel;
        }


        [ObservableProperty]
        private BaseViewModel _currentUsersChildView;

        [RelayCommand]
        public void ShowUserView()
        {
            CurrentUsersChildView = _userViewModel;
        }

        [RelayCommand]
        public void ShowAdminView()
        {
            CurrentUsersChildView = _adminViewModel;
        }

        [RelayCommand]
        public void ShowSellerView()
        {
            CurrentUsersChildView = _sellerViewModel;
        }
    }
}
