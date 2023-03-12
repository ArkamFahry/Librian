using MaterialSkin2DotNet;
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
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;
using MaterialSkin2DotNet.Controls;

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

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            var checkIfEmailExist = new CheckIfEmailExits();

            if (string.IsNullOrEmpty(TxtSignUpUserName.Text))
            {
                LblUserNameError.Text = "User Name Cannot Be Empty !";
            }
            else if (string.IsNullOrEmpty(TxtSignUpEmail.Text.Trim()))
            {
                LblEmailError.Text = "Email Cannot Be Empty !";
            }
            else if (checkIfEmailExist.EmailExits(TxtSignUpEmail.Text.Trim()))
            {
                LblEmailError.Text = "User With Email Already Exists !";
            }
            else if (string.IsNullOrEmpty(TxtSignUpPassword.Text.Trim()))
            {
                LblPasswordError.Text = "Password Cannot Be Empty !";
            }
            else if (TxtSignUpPassword.Text.Trim().PasswordStrength().Id < 2)
            {
                LblPasswordError.Text = "Password Is To Week !";
            }
            else
            {
                var user = new User
                {
                    Name = TxtSignUpUserName.Text,
                    Email = TxtSignUpEmail.Text.Trim(),
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(TxtSignUpPassword.Text.Trim())
                };
                var signUpUser = new UserRepo();
                var createdUser = signUpUser.CreateUser(user);
                
                var home = (Home)Application.OpenForms["Home"];
                home.Hide();
                var dashBoard = new DashBoard();
                dashBoard.Show();
            }
        }
    }
}
