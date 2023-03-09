using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace trackx_desktop.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] private bool _isLoginPage = true;

        [ObservableProperty] private bool _isSignUpPage;

        [ObservableProperty] private string _formHeadingContent = "Login";

        [ObservableProperty] private string _switchHintContent = "Not Signed Up";

        [ObservableProperty] private string _switchButtonContent = "Go To SignUp";

        [RelayCommand]
        public void LoginOrSignUpPageSwitch()
        {
            if (IsLoginPage)
            {
                IsSignUpPage = true;
                IsLoginPage = false;
                FormHeadingContent = "SignUp";
                SwitchHintContent = "Already Signed Up";
                SwitchButtonContent = "Go To Login";
            }
            else
            {
                IsSignUpPage = false;
                IsLoginPage = true;
                FormHeadingContent = "Login";
                SwitchHintContent = "Not Signed Up";
                SwitchButtonContent = "Go To SignUp";
            }
        }
    }
}