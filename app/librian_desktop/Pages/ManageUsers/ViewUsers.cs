using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librian_desktop.Components;
using librian_desktop.Data.SearchDb.Users;
using MaterialSkin2DotNet.Controls;

namespace librian_desktop.Pages.ManageUsers
{
    public partial class ViewUsers : MaterialForm
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        public async Task PopulateUserPanel()
        {
            var userList = new UserIndexRepo();

            var users = userList.GetUsers(UserSearchBox.Text);

            if (users == null) return;
            if (users.Result.Count() <= 0) return;
            var userListCard = new UserListCard[users.Result.Count()];

            for (var i = 0; i <= users.Result.Count(); i++)
            {
                var user = users.Result.ElementAt(i);
                userListCard[i] = new UserListCard();
                userListCard[i].UserId = user.Id;
                userListCard[i].UserName = user.Name;
                userListCard[i].UserEmail = user.Email;
                userListCard[i].UserCreatedAt = user.CreatedAt;
                userListCard[i].UserUpdatedAt = user.UpdatedAt;
                FlowPanelUserView.Controls.Add(userListCard[i]);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await PopulateUserPanel();
        }
    }
}
