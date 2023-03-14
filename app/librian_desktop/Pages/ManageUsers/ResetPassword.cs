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
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;
using FontAwesome.Sharp;

namespace librian_desktop.Pages.ManageUsers
{
    public partial class ResetPassword : MaterialForm
    {
        private readonly string _userId;

        public ResetPassword()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        public ResetPassword(string userId)
        {
            _userId = userId;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            await PasswordReset();
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtNewPassword.PasswordChar == '●')
            {
                TxtNewPassword.PasswordChar = '\0';
                BtnShowPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                TxtNewPassword.PasswordChar = '●';
                BtnShowPassword.IconChar = IconChar.Eye;
            }
        }

        private async Task PasswordReset()
        {
            var crypto = new Crypto();
            var userRepo = new UserRepo();

            var user = await userRepo.GetUserByIdAsync(_userId);
            if (string.IsNullOrEmpty(TxtNewPassword.Text.Trim()))
            {
                LblPasswordError.Text = "Password Cannot Be Empty !";
            }
            else if (TxtNewPassword.Text.PasswordStrength().Id < 2)
            {
                LblPasswordError.Text = "Password Is To Week !";
            }
            else
            {
                if (user != null)
                    user.PasswordHash = crypto.HashPassword(TxtNewPassword.Text.Trim());
                var updateResponse = user != null && await userRepo.UpdateUserAsync(user);

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

        private void ResetInputFields()
        {
            TxtNewPassword.Text = string.Empty;
        }

        private void ResetErrorFields()
        {
            LblPasswordError.Text = string.Empty;
        }
    }
}
