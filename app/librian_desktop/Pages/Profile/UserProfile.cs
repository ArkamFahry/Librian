using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librian_desktop.Data.MainDb;
using librian_desktop.Data.MainDb.Users;

namespace librian_desktop.Pages.Profile
{
    public partial class UserProfile : MaterialForm
    {
        private User? _user;

        public UserProfile()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        public UserProfile(User user)
        {
            _user = user;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void UserProfile_Load(object sender, EventArgs e)
        {
            var userRepo = new UserRepo();
            if (_user == null) return;
            _user = await userRepo.GetUserByIdAsync(_user.Id);

            TxtUserName.Text = _user?.Name;
            TxtEmail.Text = _user?.Email;
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            if (_user == null) return;
            var resetPassword = new ResetPassword(_user);
            resetPassword.ShowDialog();
        }
    }
}
