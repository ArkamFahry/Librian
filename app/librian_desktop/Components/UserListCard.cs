using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private DateTime _userCreatedAt;
        private DateTime? _userUpdatedAt;

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
        public DateTime UserCreatedAt
        {
            get => _userCreatedAt;
            set
            {
                _userCreatedAt = value;
                var createdAt = value.ToString();
                LabelCreatedAt.Text = createdAt;
            }
        }

        [Category("Custom Props")]
        public DateTime? UserUpdatedAt
        {
            get => _userUpdatedAt;
            set
            {
                _userUpdatedAt = value;
                var updatedAt = value.ToString();
                LabelCreatedAt.Text = updatedAt;
            }
        }
    }
}
