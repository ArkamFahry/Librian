using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace trackx_desktop.ViewModels.Components
{
    public partial class SignUpViewModel : ViewModelBase
    {
        [ObservableProperty] private string _signUpUserName;
        [ObservableProperty] private string _signUpUserNameError;

        [ObservableProperty] private string _signUpPassword;
        [ObservableProperty] private string _signUpPasswordError;

        [ObservableProperty] private string _signUpEmail;
        [ObservableProperty] private string _signUpEmailError;

        [RelayCommand]
        public void SignUp()
        {
            SignUpUserNameError = string.IsNullOrEmpty(SignUpUserName) ? "User Name Cannot Be Empty !" : "";

            SignUpEmailError = string.IsNullOrEmpty(SignUpEmail) ? "Email Cannot Be Empty !" : "";

            SignUpPasswordError = string.IsNullOrEmpty(SignUpPassword) ? "Password Cannot Be Empty !" : "";
        }
    }
}
