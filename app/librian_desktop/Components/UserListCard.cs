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

namespace librian_desktop.Components
{
    public partial class UserListCard : UserControl
    {
        public UserListCard()
        {
            InitializeComponent();
        }

        private string _userId;
        private string _userName;
        private string _userEmail;
        private Image _userProfilePicture;
        private string _userCreatedAt;
        private string? _userUpdatedAt = "Not Updated";

        [Category("Custom Props")]
        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }

        [Category("Custom Props")]
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                LabelUserName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string UserEmail
        {
            get => _userEmail;
            set
            {
                _userEmail = value;
                LabelUserEmail.Text = value;
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
                LabelCreatedAt.Text = value;
            }
        }

        [Category("Custom Props")]
        public string? UserUpdatedAt
        {
            get => _userUpdatedAt;
            set
            {
                _userUpdatedAt = value;
                LabelUpdatedAt.Text = value;
            }
        }
    }
}
