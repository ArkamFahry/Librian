using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Pages.ManageBooks
{
    public partial class ViewBooks : MaterialForm
    {
        public ViewBooks()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
