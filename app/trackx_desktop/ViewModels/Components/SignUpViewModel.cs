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
        [ObservableProperty] private string _signUpPassword;
        [ObservableProperty] private string _signUpEmail;

        [RelayCommand]
        public void SignUp()
        {

        }
    }
}
