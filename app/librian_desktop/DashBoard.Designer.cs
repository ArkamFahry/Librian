namespace librian_desktop
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            PnlSideBar = new Panel();
            BtnSignOut = new FontAwesome.Sharp.IconButton();
            BtnManageBooks = new FontAwesome.Sharp.IconButton();
            BtnManageUsers = new FontAwesome.Sharp.IconButton();
            BtnProfile = new FontAwesome.Sharp.IconButton();
            BtnBooks = new FontAwesome.Sharp.IconButton();
            BtnHome = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            DashBoardRenderPanle = new Panel();
            PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlSideBar
            // 
            PnlSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PnlSideBar.BackColor = Color.FromArgb(8, 36, 39);
            PnlSideBar.Controls.Add(BtnSignOut);
            PnlSideBar.Controls.Add(BtnManageBooks);
            PnlSideBar.Controls.Add(BtnManageUsers);
            PnlSideBar.Controls.Add(BtnProfile);
            PnlSideBar.Controls.Add(BtnBooks);
            PnlSideBar.Controls.Add(BtnHome);
            PnlSideBar.Location = new Point(-1, 65);
            PnlSideBar.Name = "PnlSideBar";
            PnlSideBar.Size = new Size(220, 655);
            PnlSideBar.TabIndex = 0;
            // 
            // BtnSignOut
            // 
            BtnSignOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSignOut.BackColor = Color.FromArgb(8, 36, 39);
            BtnSignOut.FlatAppearance.BorderSize = 0;
            BtnSignOut.FlatStyle = FlatStyle.Popup;
            BtnSignOut.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSignOut.ForeColor = Color.White;
            BtnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            BtnSignOut.IconColor = Color.White;
            BtnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSignOut.IconSize = 32;
            BtnSignOut.Location = new Point(0, 600);
            BtnSignOut.Name = "BtnSignOut";
            BtnSignOut.Size = new Size(217, 51);
            BtnSignOut.TabIndex = 5;
            BtnSignOut.Text = "Logout";
            BtnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSignOut.UseVisualStyleBackColor = false;
            BtnSignOut.Click += BtnSignOut_Click;
            // 
            // BtnManageBooks
            // 
            BtnManageBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnManageBooks.BackColor = Color.FromArgb(2, 42, 48);
            BtnManageBooks.FlatStyle = FlatStyle.Popup;
            BtnManageBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnManageBooks.ForeColor = Color.White;
            BtnManageBooks.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            BtnManageBooks.IconColor = Color.White;
            BtnManageBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnManageBooks.IconSize = 32;
            BtnManageBooks.Location = new Point(0, 198);
            BtnManageBooks.Name = "BtnManageBooks";
            BtnManageBooks.Size = new Size(220, 51);
            BtnManageBooks.TabIndex = 4;
            BtnManageBooks.Text = "Mange Books";
            BtnManageBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnManageBooks.UseVisualStyleBackColor = false;
            BtnManageBooks.Click += BtnManageBooks_Click;
            // 
            // BtnManageUsers
            // 
            BtnManageUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnManageUsers.BackColor = Color.FromArgb(2, 42, 48);
            BtnManageUsers.FlatStyle = FlatStyle.Popup;
            BtnManageUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnManageUsers.ForeColor = Color.White;
            BtnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            BtnManageUsers.IconColor = Color.White;
            BtnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnManageUsers.IconSize = 32;
            BtnManageUsers.Location = new Point(0, 148);
            BtnManageUsers.Name = "BtnManageUsers";
            BtnManageUsers.Size = new Size(220, 51);
            BtnManageUsers.TabIndex = 3;
            BtnManageUsers.Text = "Mange Users";
            BtnManageUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnManageUsers.UseVisualStyleBackColor = false;
            BtnManageUsers.Click += BtnManageUsers_Click;
            // 
            // BtnProfile
            // 
            BtnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnProfile.BackColor = Color.FromArgb(2, 42, 48);
            BtnProfile.FlatStyle = FlatStyle.Popup;
            BtnProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProfile.ForeColor = Color.White;
            BtnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            BtnProfile.IconColor = Color.White;
            BtnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnProfile.IconSize = 32;
            BtnProfile.Location = new Point(0, 98);
            BtnProfile.Name = "BtnProfile";
            BtnProfile.Size = new Size(220, 51);
            BtnProfile.TabIndex = 2;
            BtnProfile.Text = "Profile";
            BtnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProfile.UseVisualStyleBackColor = false;
            BtnProfile.Click += BtnProfile_Click;
            // 
            // BtnBooks
            // 
            BtnBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnBooks.BackColor = Color.FromArgb(2, 42, 48);
            BtnBooks.FlatStyle = FlatStyle.Popup;
            BtnBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBooks.ForeColor = Color.White;
            BtnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnBooks.IconColor = Color.White;
            BtnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBooks.IconSize = 32;
            BtnBooks.Location = new Point(0, 48);
            BtnBooks.Name = "BtnBooks";
            BtnBooks.Size = new Size(220, 51);
            BtnBooks.TabIndex = 1;
            BtnBooks.Text = "Books";
            BtnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBooks.UseVisualStyleBackColor = false;
            BtnBooks.Click += BtnBooks_Click;
            // 
            // BtnHome
            // 
            BtnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnHome.BackColor = Color.FromArgb(2, 42, 48);
            BtnHome.FlatStyle = FlatStyle.Popup;
            BtnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHome.ForeColor = Color.White;
            BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            BtnHome.IconColor = Color.White;
            BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnHome.IconSize = 32;
            BtnHome.Location = new Point(0, -1);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(220, 51);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "Home";
            BtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.librian_logo;
            pictureBox1.Location = new Point(1224, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DashBoardRenderPanle
            // 
            DashBoardRenderPanle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DashBoardRenderPanle.BackColor = Color.FromArgb(2, 42, 48);
            DashBoardRenderPanle.Location = new Point(219, 65);
            DashBoardRenderPanle.Name = "DashBoardRenderPanle";
            DashBoardRenderPanle.Size = new Size(1060, 655);
            DashBoardRenderPanle.TabIndex = 2;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(DashBoardRenderPanle);
            Controls.Add(pictureBox1);
            Controls.Add(PnlSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashBoard";
            Text = "DashBoard";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            FormClosing += DashBoard_FormClosing;
            Load += DashBoard_Load;
            PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlSideBar;
        private FontAwesome.Sharp.IconButton BtnHome;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnManageUsers;
        private FontAwesome.Sharp.IconButton BtnProfile;
        private FontAwesome.Sharp.IconButton BtnBooks;
        private Panel DashBoardRenderPanle;
        private FontAwesome.Sharp.IconButton BtnManageBooks;
        private FontAwesome.Sharp.IconButton BtnSignOut;
    }
}