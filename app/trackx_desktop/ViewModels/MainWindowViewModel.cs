using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using trackx_desktop.ViewModels.Components;

namespace trackx_desktop.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] private bool _isLoginControl = true;

        [ObservableProperty] private bool _isSignUpControl;

        [ObservableProperty] private string _formHeadingContent = "Login";

        [ObservableProperty] private string _switchHintContent = "Not Signed Up";

        [ObservableProperty] private string _switchButtonContent = "Go To SignUp";

        [ObservableProperty] public LoginViewModel loginViewModel;

        [ObservableProperty] public SignUpViewModel signUpViewModel;

        public MainWindowViewModel()
        {
            loginViewModel = new LoginViewModel();
            signUpViewModel = new SignUpViewModel();
        }

        [RelayCommand]
        public void LoginOrSignUpPageSwitch()
        {
            if (IsLoginControl)
            {
                IsSignUpControl = true;
                IsLoginControl = false;
                FormHeadingContent = "SignUp";
                SwitchHintContent = "Already Signed Up";
                SwitchButtonContent = "Go To Login";
            }
            else
            {
                IsSignUpControl = false;
                IsLoginControl = true;
                FormHeadingContent = "Login";
                SwitchHintContent = "Not Signed Up";
                SwitchButtonContent = "Go To SignUp";
            }
        }
    }
}