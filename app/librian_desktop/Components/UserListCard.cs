using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librian_desktop.Pages.ManageUsers;

namespace librian_desktop.Components
{
    public partial class UserListCard : UserControl
    {
        private string _userId;
        private string _userName;
        private string _userEmail;
        private Image _userProfilePicture;
        private string _userCreatedAt;
        private string? _userAccessRevokedAt = "Access Available";
        private string _userRole = "user";
        private string? _userUpdatedAt = "Not Updated";

        public UserListCard()
        {
            InitializeComponent();
        }

        private void UserListCard_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            var editUser = new EditUser(_userId);
            editUser.ShowDialog();
        }

        private void BtnUserInfo_Click(object sender, EventArgs e)
        {
            var userInfo = new UserInfo(_userId);
            userInfo.ShowDialog();
        }

        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                LblName.Text = value;
            }
        }

        public string UserEmail
        {
            get => _userEmail;
            set
            {
                _userEmail = value;
                LblEmail.Text = value;
            }
        }

        public string UserRole
        {
            get => _userRole;
            set
            {
                _userRole = value;
                LblRole.Text = value;
            }
        }

        public string? UserAccessRevokedAt
        {
            get => _userAccessRevokedAt;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _userAccessRevokedAt = value;
                    LblAccessStatus.Text = "Access Available";
                    LblAccessStatus.ForeColor = Color.Green;
                    LblAccessStatus.IconColor = Color.Green;
                }
                else
                {
                    _userAccessRevokedAt = value;
                    LblAccessStatus.Text = "Access Revoked";
                    LblAccessStatus.ForeColor = Color.Red;
                    LblAccessStatus.IconColor = Color.Red;
                }
            }
        }

        [Category("Custom Props")]
        public Image UserProfilePicture
        {
            get => _userProfilePicture;
            set
            {
                _userProfilePicture = value;
                ProfilePicture.Image = value;
            }
        }

        [Category("Custom Props")]
        public string UserCreatedAt
        {
            get => _userCreatedAt;
            set
            {
                _userCreatedAt = value;
                LblCreatedAt.Text = $"Created At : {value}";
            }
        }

        [Category("Custom Props")]
        public string? UserUpdatedAt
        {
            get => _userUpdatedAt;
            set
            {
                _userUpdatedAt = value;
                LblUpdatedAt.Text = value;
                LblUpdatedAt.Text = string.IsNullOrEmpty(value) ? "Not Updated" : $"Updated At : {value}";
            }
        }
    }
}
