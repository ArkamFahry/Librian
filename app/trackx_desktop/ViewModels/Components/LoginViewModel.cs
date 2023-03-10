using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace trackx_desktop.ViewModels.Components
{
    public partial class LoginViewModel : ViewModelBase
    {
        [ObservableProperty] private string _loginEmail;
        [ObservableProperty] private string _loginPassword;

        [ObservableProperty] private string _loginEmailError;
        [ObservableProperty] private string _loginPasswordError;

        [RelayCommand]
        public void Login()
        {
            LoginEmailError = string.IsNullOrEmpty(LoginEmail) ? "Email Cannot Be Empty !" : "";

            LoginPasswordError = string.IsNullOrEmpty(LoginPassword) ? "Password Cannot Be Empty !" : "";
        }
    }
}
