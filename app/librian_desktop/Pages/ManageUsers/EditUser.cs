using librian_desktop.Data.MainDb;
using librian_desktop.Data.MainDb.Roles;
using librian_desktop.Data.MainDb.Users;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Pages.ManageUsers
{
    public partial class EditUser : MaterialForm
    {
        private string _userId;

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
            var user = await userRepo.GetUserByIdAsync(_userId);

            if (user == null) return;
            TxtUpdateUserName.Text = user.Name;
            TxtUpdateEmail.Text = user.Email;
            CmbUpdateRole.Text = user.Role;

            if (user.AccessRevoked == null)
            {
                SwcRevokeAccess.Checked = false;
                SwcRevokeAccess.BackColor = Color.Green;
            }
            else
            {
                SwcRevokeAccess.Checked = true;
                SwcRevokeAccess.BackColor = Color.Red;
            }

            CmbUpdateRole.SelectedIndex = CmbUpdateRole.FindString(user.Role);
        }
    }
}
