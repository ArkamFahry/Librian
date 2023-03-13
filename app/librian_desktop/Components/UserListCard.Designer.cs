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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LblUpdatedAt = new Label();
            LblCreatedAt = new Label();
            LblEmail = new Label();
            LblName = new Label();
            BtnUserInfo = new FontAwesome.Sharp.IconPictureBox();
            BtnEditUser = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnUserInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnEditUser).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicture
            // 
            ProfilePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProfilePicture.BackColor = Color.Transparent;
            ProfilePicture.Location = new Point(3, 1);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(204, 145);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 5;
            ProfilePicture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 11);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(227, 45);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(227, 80);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Created At :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(227, 113);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 9;
            label4.Text = "Updated At :";
            // 
            // LblUpdatedAt
            // 
            LblUpdatedAt.AutoSize = true;
            LblUpdatedAt.ForeColor = Color.White;
            LblUpdatedAt.Location = new Point(321, 113);
            LblUpdatedAt.Name = "LblUpdatedAt";
            LblUpdatedAt.Size = new Size(67, 15);
            LblUpdatedAt.TabIndex = 13;
            LblUpdatedAt.Text = "Updated At";
            // 
            // LblCreatedAt
            // 
            LblCreatedAt.AutoSize = true;
            LblCreatedAt.ForeColor = Color.White;
            LblCreatedAt.Location = new Point(321, 80);
            LblCreatedAt.Name = "LblCreatedAt";
            LblCreatedAt.Size = new Size(63, 15);
            LblCreatedAt.TabIndex = 12;
            LblCreatedAt.Text = "Created At";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.ForeColor = Color.White;
            LblEmail.Location = new Point(321, 45);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 11;
            LblEmail.Text = "Email";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.ForeColor = Color.White;
            LblName.Location = new Point(321, 11);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 10;
            LblName.Text = "Name";
            // 
            // BtnUserInfo
            // 
            BtnUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUserInfo.BackColor = Color.Transparent;
            BtnUserInfo.ForeColor = SystemColors.ControlText;
            BtnUserInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            BtnUserInfo.IconColor = SystemColors.ControlText;
            BtnUserInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUserInfo.Location = new Point(948, 11);
            BtnUserInfo.Name = "BtnUserInfo";
            BtnUserInfo.Size = new Size(32, 32);
            BtnUserInfo.TabIndex = 14;
            BtnUserInfo.TabStop = false;
            BtnUserInfo.Click += BtnUserInfo_Click;
            // 
            // BtnEditUser
            // 
            BtnEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditUser.BackColor = Color.Transparent;
            BtnEditUser.ForeColor = SystemColors.ControlText;
            BtnEditUser.IconChar = FontAwesome.Sharp.IconChar.Pen;
            BtnEditUser.IconColor = SystemColors.ControlText;
            BtnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditUser.Location = new Point(903, 11);
            BtnEditUser.Name = "BtnEditUser";
            BtnEditUser.Size = new Size(32, 32);
            BtnEditUser.TabIndex = 15;
            BtnEditUser.TabStop = false;
            BtnEditUser.Click += BtnEditUser_Click;
            // 
            // UserListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 42, 48);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(BtnEditUser);
            Controls.Add(BtnUserInfo);
            Controls.Add(LblUpdatedAt);
            Controls.Add(LblCreatedAt);
            Controls.Add(LblEmail);
            Controls.Add(LblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProfilePicture);
            Name = "UserListCard";
            Size = new Size(993, 148);
            MouseEnter += UserListCard_MouseEnter;
            MouseLeave += UserListCard_MouseLeave;
            MouseHover += UserListCard_MouseHover;
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnUserInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnEditUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ProfilePicture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblUpdatedAt;
        private Label LblCreatedAt;
        private Label LblEmail;
        private Label LblName;
        private FontAwesome.Sharp.IconPictureBox BtnUserInfo;
        private FontAwesome.Sharp.IconPictureBox BtnEditUser;
    }
}
