using FontAwesome.Sharp;
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Auth
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            await AuthLogin();
        }

        private async Task AuthLogin()
        {
            var userRepo = new UserRepo();
            var crypto = new Crypto();

            if (string.IsNullOrEmpty(TxtLoginEmail.Text.Trim().ToLower()))
            {
                LblEmailError.Text = "Email Cannot Be Empty !";
            }
            else if (string.IsNullOrEmpty(TxtLoginPassword.Text.Trim()))
            {
                LblPasswordError.Text = "Password Cannot Be Empty !";
            }
            else
            {
                ResetErrorFields();

                var user = await userRepo.GetUserByEmailAsync(TxtLoginEmail.Text.Trim().ToLower());

                if (user != null)
                {
                    if (user.AccessRevoked == null)
                    {
                        var passwordCheck = crypto.VerifyPassword(TxtLoginPassword.Text.Trim(), user.PasswordHash);
                        if (passwordCheck)
                        {
                            ResetInputFields();
                            ResetErrorFields();
                            var home = (Home)Application.OpenForms["Home"];
                            home.Hide();
                            var dashBoard = new DashBoard(user);
                            dashBoard.Show();
                        }
                        else
                        {
                            LblPasswordError.Text = "Wrong Password !";
                        }
                    }
                    else
                    {
                        MaterialMessageBox.Show(this, "Your Access Has Been Revoked ! Contact The Administrator",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblEmailError.Text = "Email Dosen't Exist !";
                }
            }
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtLoginPassword.PasswordChar == '●')
            {
                TxtLoginPassword.PasswordChar = '\0';
                BtnShowPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                TxtLoginPassword.PasswordChar = '●';
                BtnShowPassword.IconChar = IconChar.Eye;
            }
        }

        private void ResetInputFields()
        {
            TxtLoginEmail.Text = string.Empty;
            TxtLoginPassword.Text = string.Empty;
        }

        private void ResetErrorFields()
        {
            LblEmailError.Text = string.Empty;
            LblPasswordError.Text = string.Empty;
        }
    }
}
