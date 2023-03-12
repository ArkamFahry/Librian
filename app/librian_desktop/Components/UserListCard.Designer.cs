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
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // LabelUserName
            // 
            LabelUserName.AutoSize = true;
            LabelUserName.Depth = 0;
            LabelUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUserName.Location = new Point(336, 12);
            LabelUserName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(78, 19);
            LabelUserName.TabIndex = 6;
            LabelUserName.Text = "User Name";
            LabelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProfilePicture.BackColor = Color.Transparent;
            ProfilePicture.Location = new Point(3, 1);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(204, 147);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 5;
            ProfilePicture.TabStop = false;
            // 
            // LabelCreatedAt
            // 
            LabelCreatedAt.AutoSize = true;
            LabelCreatedAt.Depth = 0;
            LabelCreatedAt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelCreatedAt.Location = new Point(335, 79);
            LabelCreatedAt.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelCreatedAt.Name = "LabelCreatedAt";
            LabelCreatedAt.Size = new Size(74, 19);
            LabelCreatedAt.TabIndex = 8;
            LabelCreatedAt.Text = "Created At";
            LabelCreatedAt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelUpdatedAt
            // 
            LabelUpdatedAt.AutoSize = true;
            LabelUpdatedAt.Depth = 0;
            LabelUpdatedAt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUpdatedAt.Location = new Point(335, 116);
            LabelUpdatedAt.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUpdatedAt.Name = "LabelUpdatedAt";
            LabelUpdatedAt.Size = new Size(79, 19);
            LabelUpdatedAt.TabIndex = 9;
            LabelUpdatedAt.Text = "Updated At";
            LabelUpdatedAt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelUserEmail
            // 
            LabelUserEmail.AutoSize = true;
            LabelUserEmail.Depth = 0;
            LabelUserEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelUserEmail.Location = new Point(335, 44);
            LabelUserEmail.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelUserEmail.Name = "LabelUserEmail";
            LabelUserEmail.Size = new Size(76, 19);
            LabelUserEmail.TabIndex = 10;
            LabelUserEmail.Text = "User Email";
            LabelUserEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(221, 12);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(51, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Name :";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(221, 44);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(49, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Email :";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(221, 79);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(78, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "CreatedAt :";
            materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(221, 117);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(83, 19);
            materialLabel4.TabIndex = 14;
            materialLabel4.Text = "UpdatedAt :";
            // 
            // UserListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 42, 48);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(LabelUserEmail);
            Controls.Add(LabelUpdatedAt);
            Controls.Add(LabelCreatedAt);
            Controls.Add(LabelUserName);
            Controls.Add(ProfilePicture);
            Name = "UserListCard";
            Size = new Size(995, 150);
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
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
    }
}
