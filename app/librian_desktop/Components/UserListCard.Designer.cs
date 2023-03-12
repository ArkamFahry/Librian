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
            LabelUserName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ProfilePicture = new PictureBox();
            LabelCreatedAt = new MaterialSkin2DotNet.Controls.MaterialLabel();
            LabelUpdatedAt = new MaterialSkin2DotNet.Controls.MaterialLabel();
            LabelUserEmail = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // LabelUserName
            // 
            LabelUserName.AutoSize = true;
            LabelUserName.Depth = 0;
            LabelUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUserName.Location = new Point(221, 13);
            LabelUserName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(78, 19);
            LabelUserName.TabIndex = 6;
            LabelUserName.Text = "User Name";
            // 
            // ProfilePicture
            // 
            ProfilePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProfilePicture.BackColor = Color.Transparent;
            ProfilePicture.Location = new Point(3, 1);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(204, 197);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 5;
            ProfilePicture.TabStop = false;
            // 
            // LabelCreatedAt
            // 
            LabelCreatedAt.AutoSize = true;
            LabelCreatedAt.Depth = 0;
            LabelCreatedAt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCreatedAt.Location = new Point(221, 110);
            LabelCreatedAt.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelCreatedAt.Name = "LabelCreatedAt";
            LabelCreatedAt.Size = new Size(74, 19);
            LabelCreatedAt.TabIndex = 8;
            LabelCreatedAt.Text = "Created At";
            // 
            // LabelUpdatedAt
            // 
            LabelUpdatedAt.AutoSize = true;
            LabelUpdatedAt.Depth = 0;
            LabelUpdatedAt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUpdatedAt.Location = new Point(221, 156);
            LabelUpdatedAt.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUpdatedAt.Name = "LabelUpdatedAt";
            LabelUpdatedAt.Size = new Size(79, 19);
            LabelUpdatedAt.TabIndex = 9;
            LabelUpdatedAt.Text = "Updated At";
            // 
            // LabelUserEmail
            // 
            LabelUserEmail.AutoSize = true;
            LabelUserEmail.Depth = 0;
            LabelUserEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUserEmail.Location = new Point(221, 63);
            LabelUserEmail.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUserEmail.Name = "LabelUserEmail";
            LabelUserEmail.Size = new Size(76, 19);
            LabelUserEmail.TabIndex = 10;
            LabelUserEmail.Text = "User Email";
            // 
            // UserListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(LabelUserEmail);
            Controls.Add(LabelUpdatedAt);
            Controls.Add(LabelCreatedAt);
            Controls.Add(LabelUserName);
            Controls.Add(ProfilePicture);
            Name = "UserListCard";
            Size = new Size(995, 200);
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialLabel LabelUserName;
        private PictureBox ProfilePicture;
        private MaterialSkin2DotNet.Controls.MaterialLabel LabelCreatedAt;
        private MaterialSkin2DotNet.Controls.MaterialLabel LabelUpdatedAt;
        private MaterialSkin2DotNet.Controls.MaterialLabel LabelUserEmail;
    }
}
