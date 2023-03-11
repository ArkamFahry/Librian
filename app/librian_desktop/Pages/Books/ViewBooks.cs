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
using librian_desktop.Components;

namespace librian_desktop.Pages.Books
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

            PopulateBookView();
        }

        private void PopulateBookView()
        {
            BookListCard[] cards = new BookListCard[10];

            for (int i = 0; i < 8; i++)
            {
                cards[i] = new BookListCard();
                cards[i].BookId = "1";
                cards[i].BookName = "hello";
                cards[i].BookDescription = "non";
                cards[i].BookCoverImage = Image.FromFile("D:\\Projects\\Nibm\\Gad\\Librian\\app\\librian_desktop\\Assets\\librian-logo.ico");
                FlowPanelBookView.Controls.Add(cards[i]);
            }
        }
    }
}
