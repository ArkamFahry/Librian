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
            var home = (Home)Application.OpenForms["Home"];
            home.Hide();
            var dashBoard = new DashBoard();
            dashBoard.Show();
        }
    }
}
