using EmailValidation;
using librian_desktop.Data.MainDb;
using librian_desktop.Data.MainDb.Roles;
using librian_desktop.Data.MainDb.Users;
using librian_desktop.Utils;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Pages.ManageUsers
{
    public partial class EditUser : MaterialForm
    {
        private readonly string _userId;
        private User? _user;

        public EditUser()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        public EditUser(string userId)
        {
            _userId = userId;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void EditUser_Load(object sender, EventArgs e)
        {
            await PopulateRolesComboBox();

            await PopulateUserFields();
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateUser();
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            if (_user == null) return;
            var resetPassword = new ResetPassword(_user.Id);
            resetPassword.ShowDialog();
        }

        private async Task PopulateRolesComboBox()
        {
            var roleRepo = new RoleRepo();
            var roles = await roleRepo.GetRolesAsync();

            foreach (var role in roles)
            {
                CmbUpdateRole.Items.Add(role.Id);
            }
        }

        public async Task PopulateUserFields()
        {
            var userRepo = new UserRepo();
            _user = await userRepo.GetUserByIdAsync(_userId);

            if (_user == null) return;
            TxtUpdateUserName.Text = _user.Name;
            TxtUpdateEmail.Text = _user.Email;
            CmbUpdateRole.Text = _user.Role;

            if (_user.AccessRevoked == null)
            {
                SwcRevokeAccess.Checked = false;
                SwcRevokeAccess.BackColor = Color.Green;
            }
            else
            {
                SwcRevokeAccess.Checked = true;
                SwcRevokeAccess.BackColor = Color.Red;
            }

            CmbUpdateRole.SelectedIndex = CmbUpdateRole.FindString(_user.Role);
        }

        private async Task UpdateUser()
        {
            var updateResponse = false;
            DialogResult messageBoxResult;
            var checkIfEmailExist = new CheckIfEmailExits();
            var userRepo = new UserRepo();

            if (_user == null) return;
            _user.Name = TxtUpdateUserName.Text;
            _user.Role = CmbUpdateRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(TxtUpdateUserName.Text))
            {
                LblUserNameError.Text = "User Name Cannot Be Empty !";
            }
            else if (string.IsNullOrEmpty(TxtUpdateEmail.Text))
            {
                LblEmailError.Text = "Email Cannot Be Empty !";
            }
            else if (!EmailValidator.Validate(TxtUpdateEmail.Text.Trim().ToLower()))
            {
                LblEmailError.Text = "Email Address Invalid !";
            }
            else if (_user.Email != TxtUpdateEmail.Text)
            {
                if (await checkIfEmailExist.EmailExits(TxtUpdateEmail.Text.ToLower()))
                {
                    LblEmailError.Text = "Email Already Exists !";
                }
                else if (!EmailValidator.Validate(TxtUpdateEmail.Text.Trim().ToLower()))
                {
                    LblEmailError.Text = "Email Address Invalid !";
                }
                else
                {
                    _user.Email = TxtUpdateEmail.Text;

                    if (_user.AccessRevoked != null)
                    {
                        _user.AccessRevoked = SwcRevokeAccess.Checked ? _user.AccessRevoked : null;
                    }
                    else
                    {
                        if (SwcRevokeAccess.Checked)
                        {
                            _user.AccessRevoked = DateTime.Now;
                        }
                        else
                        {
                            _user.AccessRevoked = null;
                        }
                    }

                    updateResponse = await userRepo.UpdateUserAsync(_user);
                }
            }
            else
            {
                if (_user.AccessRevoked != null)
                {
                    _user.AccessRevoked = SwcRevokeAccess.Checked ? _user.AccessRevoked : null;
                }
                else
                {
                    if (SwcRevokeAccess.Checked)
                    {
                        _user.AccessRevoked = DateTime.Now;
                    }
                    else
                    {
                        _user.AccessRevoked = null;
                    }
                }

                updateResponse = await userRepo.UpdateUserAsync(_user);
            }

            if (updateResponse)
            {
                messageBoxResult = MaterialMessageBox.Show(this, "User Update Successful !", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (messageBoxResult == DialogResult.OK)
                {
                    ResetInputFields();
                    ResetErrorFields();
                }
            }
            else
            {
                messageBoxResult = MaterialMessageBox.Show(this, "User Update Failed ! Please Try Again", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (messageBoxResult == DialogResult.OK)
                {
                    ResetInputFields();
                    ResetErrorFields();
                }
            }
        }

        private async void ResetInputFields()
        {
            await PopulateUserFields();
        }

        private void ResetErrorFields()
        {
            LblEmailError.Text = string.Empty;
            LblUserNameError.Text = string.Empty;
        }
    }
}   
