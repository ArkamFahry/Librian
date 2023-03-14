using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librian_desktop.Components;
using librian_desktop.Data.SearchDb.Users;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Pages.ManageUsers
{
    public partial class ViewUsers : MaterialForm
    {
        public ViewUsers()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey600, Primary.Grey300, Accent.Teal100, TextShade.WHITE);
        }

        private async void ViewUsers_Load(object sender, EventArgs e)
        {
            await PopulateUserPanel();
        }

        private async void SearchBoxUser_TextChanged(object sender, EventArgs e)
        {
            await PopulateUserPanel();
        }

        public async Task PopulateUserPanel()
        {
            var userList = new UserIndexRepo();

            FlowPanelUserView.Controls.Clear();

            var users = await userList.SearchUserIndex(SearchBoxUser.Text);
            var userListCard = new UserListCard[users.Count()];
            if (users.Count() > 0)
            {

                for (var i = 0; i < users.Count(); i++)
                {
                    var user = users.ElementAt(i);
                    userListCard[i] = new UserListCard();
                    userListCard[i].UserId = user.Id;
                    userListCard[i].UserName = user.Name;
                    userListCard[i].UserEmail = user.Email;
                    userListCard[i].UserRole = user.Role;
                    userListCard[i].UserAccessRevokedAt = user.AccessRevoked;
                    userListCard[i].UserCreatedAt = user.CreatedAt;
                    userListCard[i].UserUpdatedAt = user.UpdatedAt;
                    FlowPanelUserView.Controls.Add(userListCard[i]);
                }
            }
        }
    }
}
