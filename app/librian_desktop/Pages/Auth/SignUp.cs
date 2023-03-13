using MaterialSkin2DotNet;
using CheckPasswordStrength;
using librian_desktop.Data.MainDb;
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;
using MaterialSkin2DotNet.Controls;
using FontAwesome.Sharp;

namespace librian_desktop.Auth
{
    public partial class SignUp : MaterialForm
    {
        public SignUp()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void BtnSignUp_Click(object sender, EventArgs e)
        {
            await AuthSignUp();
        }

        public async Task AuthSignUp()
        {
            var checkIfEmailExist = new CheckIfEmailExits();
            var crypto = new Crypto();
            var userRepo = new UserRepo();

            if (string.IsNullOrEmpty(TxtSignUpUserName.Text))
            {
                LblUserNameError.Text = "User Name Cannot Be Empty !";
            }
            else if (string.IsNullOrEmpty(TxtSignUpEmail.Text.Trim().ToLower()))
            {
                LblEmailError.Text = "Email Cannot Be Empty !";
            }
            else if (string.IsNullOrEmpty(TxtSignUpPassword.Text.Trim()))
            {
                LblPasswordError.Text = "Password Cannot Be Empty !";
            }
            else if (await checkIfEmailExist.EmailExits(TxtSignUpEmail.Text.Trim().ToLower()))
            {
                LblEmailError.Text = "Email Already Exists !";
            }
            else if (TxtSignUpPassword.Text.Trim().PasswordStrength().Id < 2)
            {
                LblPasswordError.Text = "Password Is To Week !";
            }
            else
            {
                var createUser = new User
                {
                    Name = TxtSignUpUserName.Text,
                    Email = TxtSignUpEmail.Text.Trim().ToLower(),
                    PasswordHash = crypto.HashPassword(TxtSignUpPassword.Text.Trim())
                };
                await userRepo.CreateUserAsync(createUser);
                var createdUser = await userRepo.GetUserByEmailAsync(createUser.Email);

                if (createdUser == null) return;
                ResetInputFields();
                ResetErrorFields();
                var home = (Home)Application.OpenForms["Home"];
                home.Hide();
                var dashBoard = new DashBoard(createdUser);
                dashBoard.Show();
            }
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtSignUpPassword.PasswordChar == '●')
            {
                TxtSignUpPassword.PasswordChar = '\0';
                BtnShowPassword.IconChar = IconChar.EyeSlash;
            }
            else
            {
                TxtSignUpPassword.PasswordChar = '●';
                BtnShowPassword.IconChar = IconChar.Eye;
            }
        }

        private void ResetInputFields()
        {
            TxtSignUpUserName.Text = string.Empty;
            TxtSignUpEmail.Text = string.Empty;
            TxtSignUpPassword.Text = string.Empty;
        }

        private void ResetErrorFields()
        {
            LblUserNameError.Text = string.Empty;
            LblEmailError.Text = string.Empty;
            LblPasswordError.Text = string.Empty;
        }
    }
}
