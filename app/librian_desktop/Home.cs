using librian_desktop.Auth;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
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
            AuthDisplayPanel.Controls.Add(childForm);
            AuthDisplayPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }

        private void BtnChangeAuthPage_Click(object sender, EventArgs e)
        {
            if (Text != "SignUp")
            {
                Text = "SignUp";
                OpenChildForm(new SignUp());
                BtnChangeAuthPage.Text = "Go To Login";
            }
            else
            {
                Text = "Login";
                OpenChildForm(new Login());
                BtnChangeAuthPage.Text = "Go To SignUp";
            }
        }
    }
}