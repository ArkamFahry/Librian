using librian_desktop.Data.MainDb;
using librian_desktop.Pages.Books;
using librian_desktop.Pages.Home;
using librian_desktop.Pages.ManageUsers;
using librian_desktop.Pages.Profile;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop
{
    public partial class DashBoard : MaterialForm
    {
        private User _user;

        public DashBoard()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        public DashBoard(User user)
        {
            _user = user;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DashBoardRenderPanle.Controls.Add(childForm);
            DashBoardRenderPanle.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (_user.Role != "admin")
            {
                BtnManageBooks.Enabled = false;
                BtnManageBooks.Visible = false;
                BtnManageUsers.Enabled = false;
                BtnManageUsers.Visible = false;
            }

            OpenChildForm(new UserHome());
            Text = "Home";
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserHome());
            Text = "Home";
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewBooks());
            Text = "Books";
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserProfile(_user));
            Text = "Profile";
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewUsers());
            Text = "Manage Users";
        }

        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            Text = "Manage Books";
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = (Home)Application.OpenForms["Home"];
            home.Show();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            var home = (Home)Application.OpenForms["Home"];
            home.Show();
            Close();
        }
    }
}
