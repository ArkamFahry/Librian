namespace librian_desktop.Pages.Profile
{
    partial class UserProfile
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
            LblUserNameError = new Label();
            LblEmailError = new Label();
            BtnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ProfilePicture = new PictureBox();
            BtnResetPassword = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtUserName = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            TxtEmail = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // LblUserNameError
            // 
            LblUserNameError.AutoSize = true;
            LblUserNameError.BackColor = Color.Transparent;
            LblUserNameError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserNameError.ForeColor = Color.Red;
            LblUserNameError.Location = new Point(351, 107);
            LblUserNameError.Name = "LblUserNameError";
            LblUserNameError.Size = new Size(0, 20);
            LblUserNameError.TabIndex = 31;
            // 
            // LblEmailError
            // 
            LblEmailError.AutoSize = true;
            LblEmailError.BackColor = Color.Transparent;
            LblEmailError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailError.ForeColor = Color.Red;
            LblEmailError.Location = new Point(351, 245);
            LblEmailError.Name = "LblEmailError";
            LblEmailError.Size = new Size(0, 20);
            LblEmailError.TabIndex = 30;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnUpdate.AutoSize = false;
            BtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnUpdate.Depth = 0;
            BtnUpdate.HighEmphasis = true;
            BtnUpdate.Icon = null;
            BtnUpdate.Location = new Point(857, 586);
            BtnUpdate.Margin = new Padding(4, 6, 4, 6);
            BtnUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.NoAccentTextColor = Color.Empty;
            BtnUpdate.Size = new Size(175, 36);
            BtnUpdate.TabIndex = 28;
            BtnUpdate.Text = "Update";
            BtnUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnUpdate.UseAccentColor = false;
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(22, 25);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(100, 19);
            materialLabel4.TabIndex = 27;
            materialLabel4.Text = "Profile Picture";
            // 
            // ProfilePicture
            // 
            ProfilePicture.Location = new Point(22, 47);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(294, 286);
            ProfilePicture.TabIndex = 26;
            ProfilePicture.TabStop = false;
            // 
            // BtnResetPassword
            // 
            BtnResetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnResetPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnResetPassword.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnResetPassword.Depth = 0;
            BtnResetPassword.HighEmphasis = true;
            BtnResetPassword.Icon = null;
            BtnResetPassword.Location = new Point(884, 297);
            BtnResetPassword.Margin = new Padding(4, 6, 4, 6);
            BtnResetPassword.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnResetPassword.Name = "BtnResetPassword";
            BtnResetPassword.NoAccentTextColor = Color.Empty;
            BtnResetPassword.Size = new Size(148, 36);
            BtnResetPassword.TabIndex = 25;
            BtnResetPassword.Text = "Reset Password";
            BtnResetPassword.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnResetPassword.UseAccentColor = false;
            BtnResetPassword.UseVisualStyleBackColor = true;
            BtnResetPassword.Click += BtnResetPassword_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(351, 172);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 19);
            materialLabel2.TabIndex = 21;
            materialLabel2.Text = "Email";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(351, 25);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(78, 19);
            materialLabel1.TabIndex = 20;
            materialLabel1.Text = "User Name";
            // 
            // TxtUserName
            // 
            TxtUserName.AllowPromptAsInput = true;
            TxtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtUserName.AnimateReadOnly = false;
            TxtUserName.AsciiOnly = false;
            TxtUserName.BackgroundImageLayout = ImageLayout.None;
            TxtUserName.BeepOnError = false;
            TxtUserName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtUserName.Depth = 0;
            TxtUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtUserName.HidePromptOnLeave = false;
            TxtUserName.HideSelection = true;
            TxtUserName.InsertKeyMode = InsertKeyMode.Default;
            TxtUserName.LeadingIcon = null;
            TxtUserName.Location = new Point(351, 47);
            TxtUserName.Mask = "";
            TxtUserName.MaxLength = 32767;
            TxtUserName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PasswordChar = '\0';
            TxtUserName.PrefixSuffixText = null;
            TxtUserName.PromptChar = '_';
            TxtUserName.ReadOnly = false;
            TxtUserName.RejectInputOnFirstFailure = false;
            TxtUserName.ResetOnPrompt = true;
            TxtUserName.ResetOnSpace = true;
            TxtUserName.RightToLeft = RightToLeft.No;
            TxtUserName.SelectedText = "";
            TxtUserName.SelectionLength = 0;
            TxtUserName.SelectionStart = 0;
            TxtUserName.ShortcutsEnabled = true;
            TxtUserName.Size = new Size(681, 48);
            TxtUserName.SkipLiterals = true;
            TxtUserName.TabIndex = 18;
            TxtUserName.TabStop = false;
            TxtUserName.TextAlign = HorizontalAlignment.Left;
            TxtUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtUserName.TrailingIcon = null;
            TxtUserName.UseSystemPasswordChar = false;
            TxtUserName.ValidatingType = null;
            // 
            // TxtEmail
            // 
            TxtEmail.AllowPromptAsInput = true;
            TxtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmail.AnimateReadOnly = false;
            TxtEmail.AsciiOnly = false;
            TxtEmail.BackgroundImageLayout = ImageLayout.None;
            TxtEmail.BeepOnError = false;
            TxtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtEmail.Depth = 0;
            TxtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtEmail.HidePromptOnLeave = false;
            TxtEmail.HideSelection = true;
            TxtEmail.InsertKeyMode = InsertKeyMode.Default;
            TxtEmail.LeadingIcon = null;
            TxtEmail.Location = new Point(351, 194);
            TxtEmail.Mask = "";
            TxtEmail.MaxLength = 32767;
            TxtEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PasswordChar = '\0';
            TxtEmail.PrefixSuffixText = null;
            TxtEmail.PromptChar = '_';
            TxtEmail.ReadOnly = false;
            TxtEmail.RejectInputOnFirstFailure = false;
            TxtEmail.ResetOnPrompt = true;
            TxtEmail.ResetOnSpace = true;
            TxtEmail.RightToLeft = RightToLeft.No;
            TxtEmail.SelectedText = "";
            TxtEmail.SelectionLength = 0;
            TxtEmail.SelectionStart = 0;
            TxtEmail.ShortcutsEnabled = true;
            TxtEmail.Size = new Size(681, 48);
            TxtEmail.SkipLiterals = true;
            TxtEmail.TabIndex = 32;
            TxtEmail.TabStop = false;
            TxtEmail.TextAlign = HorizontalAlignment.Left;
            TxtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtEmail.TrailingIcon = null;
            TxtEmail.UseSystemPasswordChar = false;
            TxtEmail.ValidatingType = null;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(TxtEmail);
            Controls.Add(LblUserNameError);
            Controls.Add(LblEmailError);
            Controls.Add(BtnUpdate);
            Controls.Add(materialLabel4);
            Controls.Add(ProfilePicture);
            Controls.Add(BtnResetPassword);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TxtUserName);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "UserProfile";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "UserProfile";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUserNameError;
        private Label LblEmailError;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnUpdate;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
        private PictureBox ProfilePicture;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnResetPassword;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtUserName;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtEmail;
    }
}