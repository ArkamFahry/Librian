namespace librian_desktop.Components
{
    partial class UserListCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProfilePicture = new PictureBox();
            BtnEditUser = new FontAwesome.Sharp.IconButton();
            BtnUserInfo = new FontAwesome.Sharp.IconButton();
            LblAccessStatus = new FontAwesome.Sharp.IconButton();
            LblName = new FontAwesome.Sharp.IconButton();
            LblEmail = new FontAwesome.Sharp.IconButton();
            LblCreatedAt = new FontAwesome.Sharp.IconButton();
            LblUpdatedAt = new FontAwesome.Sharp.IconButton();
            LblRole = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicture
            // 
            ProfilePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProfilePicture.BackColor = Color.Transparent;
            ProfilePicture.Location = new Point(3, 1);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(205, 145);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 5;
            ProfilePicture.TabStop = false;
            // 
            // BtnEditUser
            // 
            BtnEditUser.BackColor = Color.FromArgb(2, 42, 48);
            BtnEditUser.FlatStyle = FlatStyle.Popup;
            BtnEditUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditUser.ForeColor = Color.White;
            BtnEditUser.IconChar = FontAwesome.Sharp.IconChar.Pen;
            BtnEditUser.IconColor = Color.White;
            BtnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditUser.IconSize = 24;
            BtnEditUser.Location = new Point(798, 13);
            BtnEditUser.Name = "BtnEditUser";
            BtnEditUser.Size = new Size(80, 30);
            BtnEditUser.TabIndex = 14;
            BtnEditUser.Text = "Edit";
            BtnEditUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditUser.UseVisualStyleBackColor = false;
            BtnEditUser.Click += BtnEditUser_Click;
            // 
            // BtnUserInfo
            // 
            BtnUserInfo.FlatStyle = FlatStyle.Popup;
            BtnUserInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUserInfo.ForeColor = Color.White;
            BtnUserInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            BtnUserInfo.IconColor = Color.White;
            BtnUserInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUserInfo.IconSize = 24;
            BtnUserInfo.Location = new Point(900, 13);
            BtnUserInfo.Name = "BtnUserInfo";
            BtnUserInfo.Size = new Size(80, 30);
            BtnUserInfo.TabIndex = 15;
            BtnUserInfo.Text = "Info";
            BtnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUserInfo.UseVisualStyleBackColor = true;
            BtnUserInfo.Click += BtnUserInfo_Click;
            // 
            // LblAccessStatus
            // 
            LblAccessStatus.FlatStyle = FlatStyle.Popup;
            LblAccessStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblAccessStatus.ForeColor = Color.Green;
            LblAccessStatus.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            LblAccessStatus.IconColor = Color.Green;
            LblAccessStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblAccessStatus.IconSize = 15;
            LblAccessStatus.ImageAlign = ContentAlignment.MiddleLeft;
            LblAccessStatus.Location = new Point(227, 108);
            LblAccessStatus.Name = "LblAccessStatus";
            LblAccessStatus.Size = new Size(552, 25);
            LblAccessStatus.TabIndex = 19;
            LblAccessStatus.Text = "Access Available";
            LblAccessStatus.TextAlign = ContentAlignment.MiddleLeft;
            LblAccessStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            LblAccessStatus.UseVisualStyleBackColor = true;
            // 
            // LblName
            // 
            LblName.FlatStyle = FlatStyle.Popup;
            LblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.ForeColor = Color.White;
            LblName.IconChar = FontAwesome.Sharp.IconChar.User;
            LblName.IconColor = Color.White;
            LblName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblName.IconSize = 15;
            LblName.ImageAlign = ContentAlignment.MiddleLeft;
            LblName.Location = new Point(227, 12);
            LblName.Name = "LblName";
            LblName.Size = new Size(552, 27);
            LblName.TabIndex = 20;
            LblName.Text = " User Name";
            LblName.TextImageRelation = TextImageRelation.ImageBeforeText;
            LblName.UseVisualStyleBackColor = true;
            // 
            // LblEmail
            // 
            LblEmail.FlatStyle = FlatStyle.Popup;
            LblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.ForeColor = Color.White;
            LblEmail.IconChar = FontAwesome.Sharp.IconChar.At;
            LblEmail.IconColor = Color.White;
            LblEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblEmail.IconSize = 15;
            LblEmail.ImageAlign = ContentAlignment.MiddleLeft;
            LblEmail.Location = new Point(227, 45);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(552, 27);
            LblEmail.TabIndex = 21;
            LblEmail.Text = " Email";
            LblEmail.TextImageRelation = TextImageRelation.ImageBeforeText;
            LblEmail.UseVisualStyleBackColor = true;
            // 
            // LblCreatedAt
            // 
            LblCreatedAt.FlatStyle = FlatStyle.Popup;
            LblCreatedAt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblCreatedAt.ForeColor = Color.White;
            LblCreatedAt.IconChar = FontAwesome.Sharp.IconChar.None;
            LblCreatedAt.IconColor = Color.Black;
            LblCreatedAt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblCreatedAt.Location = new Point(798, 77);
            LblCreatedAt.Name = "LblCreatedAt";
            LblCreatedAt.Size = new Size(182, 25);
            LblCreatedAt.TabIndex = 22;
            LblCreatedAt.Text = "created at";
            LblCreatedAt.TextAlign = ContentAlignment.MiddleLeft;
            LblCreatedAt.UseVisualStyleBackColor = true;
            // 
            // LblUpdatedAt
            // 
            LblUpdatedAt.FlatStyle = FlatStyle.Popup;
            LblUpdatedAt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblUpdatedAt.ForeColor = Color.White;
            LblUpdatedAt.IconChar = FontAwesome.Sharp.IconChar.None;
            LblUpdatedAt.IconColor = Color.Black;
            LblUpdatedAt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblUpdatedAt.Location = new Point(798, 108);
            LblUpdatedAt.Name = "LblUpdatedAt";
            LblUpdatedAt.Size = new Size(182, 25);
            LblUpdatedAt.TabIndex = 23;
            LblUpdatedAt.Text = "updated at";
            LblUpdatedAt.TextAlign = ContentAlignment.MiddleLeft;
            LblUpdatedAt.UseVisualStyleBackColor = true;
            // 
            // LblRole
            // 
            LblRole.FlatStyle = FlatStyle.Popup;
            LblRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.ForeColor = Color.White;
            LblRole.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            LblRole.IconColor = Color.White;
            LblRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LblRole.IconSize = 15;
            LblRole.ImageAlign = ContentAlignment.MiddleLeft;
            LblRole.Location = new Point(227, 76);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(552, 27);
            LblRole.TabIndex = 24;
            LblRole.Text = " Role";
            LblRole.TextImageRelation = TextImageRelation.ImageBeforeText;
            LblRole.UseVisualStyleBackColor = true;
            // 
            // UserListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 42, 48);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(LblRole);
            Controls.Add(LblUpdatedAt);
            Controls.Add(LblCreatedAt);
            Controls.Add(LblEmail);
            Controls.Add(LblName);
            Controls.Add(LblAccessStatus);
            Controls.Add(BtnUserInfo);
            Controls.Add(BtnEditUser);
            Controls.Add(ProfilePicture);
            Name = "UserListCard";
            Size = new Size(993, 148);
            Load += UserListCard_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox ProfilePicture;
        private FontAwesome.Sharp.IconButton BtnEditUser;
        private FontAwesome.Sharp.IconButton BtnUserInfo;
        private FontAwesome.Sharp.IconButton LblAccessStatus;
        private FontAwesome.Sharp.IconButton LblName;
        private FontAwesome.Sharp.IconButton LblEmail;
        private FontAwesome.Sharp.IconButton LblCreatedAt;
        private FontAwesome.Sharp.IconButton LblUpdatedAt;
        private FontAwesome.Sharp.IconButton LblRole;
    }
}
