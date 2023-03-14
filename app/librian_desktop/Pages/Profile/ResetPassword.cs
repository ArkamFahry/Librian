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
using CheckPasswordStrength;
using librian_desktop.Data.MainDb;
using FontAwesome.Sharp;
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;

namespace librian_desktop.Pages.Profile
{
    public partial class ResetPassword : MaterialForm
    {
        private User? _user;

        public ResetPassword()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        public ResetPassword(User user)
        {
            _user = user;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void ResetPassword_Load(object sender, EventArgs e)
        {
            var userRepo = new UserRepo();
            if (_user != null) _user = await userRepo.GetUserByIdAsync(_user.Id);
        }

        private void BtnShowOldPassword_Click(object sender, EventArgs e)
        {
            if (TxtOldPassword.PasswordChar == '●')
            {
                TxtOldPassword.PasswordChar = '\0';
                BtnShowOldPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                TxtOldPassword.PasswordChar = '●';
                BtnShowOldPassword.IconChar = IconChar.Eye;
            }
        }

        private void BtnShowNewPassword_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.PasswordChar == '●')
            {
                TxtNewPassword.PasswordChar = '\0';
                BtnShowNewPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                TxtNewPassword.PasswordChar = '●';
                BtnShowNewPassword.IconChar = IconChar.Eye;
            }
        }

        private async void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            await PasswordReset();
        }

        private async Task PasswordReset()
        {
            var crypto = new Crypto();
            var userRepo = new UserRepo();

            if (crypto.VerifyPassword(TxtOldPassword.Text.Trim(), _user.PasswordHash))
            {
                LblOldPasswordError.Text = string.Empty;

                if (TxtNewPassword.Text.Trim().PasswordStrength().Id < 2)
                {
                    LblNewPasswordError.Text = "Password Is To Week !";
                }
                else
                {
                    _user.PasswordHash = crypto.HashPassword(TxtNewPassword.Text.Trim());
                    var updateResponse = await userRepo.UpdateUserAsync(_user);

                    DialogResult messageBoxResult;
                    if (updateResponse)
                    {
                        messageBoxResult = MaterialMessageBox.Show(this, "Password Update Successful !", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (messageBoxResult == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        messageBoxResult = MaterialMessageBox.Show(this, "Password Update Failed ! Please Try Again", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        if (messageBoxResult == DialogResult.OK)
                        {
                            ResetInputFields();
                            ResetErrorFields();
                        }
                    }
                }

            }
            else
            {
                LblOldPasswordError.Text = "Wrong Password !";
            }
        }

        private void ResetInputFields()
        {
            TxtOldPassword.Text = string.Empty;
            TxtNewPassword.Text = string.Empty;
        }

        private void ResetErrorFields()
        {
            LblOldPasswordError.Text = string.Empty;
            LblNewPasswordError.Text = string.Empty;
        }
    }
}
