namespace librian_desktop.Pages.ManageUsers
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            TxtUpdateUserName = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            TxtUpdateEmail = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            CmbUpdateRole = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            SwcRevokeAccess = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            BtnResetPassword = new MaterialSkin2DotNet.Controls.MaterialButton();
            ProfilePicture = new PictureBox();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            BtnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            CmbRoleError = new Label();
            LblEmailError = new Label();
            LblUserNameError = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // TxtUpdateUserName
            // 
            TxtUpdateUserName.AllowPromptAsInput = true;
            TxtUpdateUserName.AnimateReadOnly = false;
            TxtUpdateUserName.AsciiOnly = false;
            TxtUpdateUserName.BackgroundImageLayout = ImageLayout.None;
            TxtUpdateUserName.BeepOnError = false;
            TxtUpdateUserName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtUpdateUserName.Depth = 0;
            TxtUpdateUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtUpdateUserName.HidePromptOnLeave = false;
            TxtUpdateUserName.HideSelection = true;
            TxtUpdateUserName.InsertKeyMode = InsertKeyMode.Default;
            TxtUpdateUserName.LeadingIcon = null;
            TxtUpdateUserName.Location = new Point(335, 91);
            TxtUpdateUserName.Mask = "";
            TxtUpdateUserName.MaxLength = 32767;
            TxtUpdateUserName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtUpdateUserName.Name = "TxtUpdateUserName";
            TxtUpdateUserName.PasswordChar = '\0';
            TxtUpdateUserName.PrefixSuffixText = null;
            TxtUpdateUserName.PromptChar = '_';
            TxtUpdateUserName.ReadOnly = false;
            TxtUpdateUserName.RejectInputOnFirstFailure = false;
            TxtUpdateUserName.ResetOnPrompt = true;
            TxtUpdateUserName.ResetOnSpace = true;
            TxtUpdateUserName.RightToLeft = RightToLeft.No;
            TxtUpdateUserName.SelectedText = "";
            TxtUpdateUserName.SelectionLength = 0;
            TxtUpdateUserName.SelectionStart = 0;
            TxtUpdateUserName.ShortcutsEnabled = true;
            TxtUpdateUserName.Size = new Size(646, 48);
            TxtUpdateUserName.SkipLiterals = true;
            TxtUpdateUserName.TabIndex = 0;
            TxtUpdateUserName.TabStop = false;
            TxtUpdateUserName.TextAlign = HorizontalAlignment.Left;
            TxtUpdateUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtUpdateUserName.TrailingIcon = null;
            TxtUpdateUserName.UseSystemPasswordChar = false;
            TxtUpdateUserName.ValidatingType = null;
            // 
            // TxtUpdateEmail
            // 
            TxtUpdateEmail.AllowPromptAsInput = true;
            TxtUpdateEmail.AnimateReadOnly = false;
            TxtUpdateEmail.AsciiOnly = false;
            TxtUpdateEmail.BackgroundImageLayout = ImageLayout.None;
            TxtUpdateEmail.BeepOnError = false;
            TxtUpdateEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtUpdateEmail.Depth = 0;
            TxtUpdateEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtUpdateEmail.HidePromptOnLeave = false;
            TxtUpdateEmail.HideSelection = true;
            TxtUpdateEmail.InsertKeyMode = InsertKeyMode.Default;
            TxtUpdateEmail.LeadingIcon = null;
            TxtUpdateEmail.Location = new Point(335, 209);
            TxtUpdateEmail.Mask = "";
            TxtUpdateEmail.MaxLength = 32767;
            TxtUpdateEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtUpdateEmail.Name = "TxtUpdateEmail";
            TxtUpdateEmail.PasswordChar = '\0';
            TxtUpdateEmail.PrefixSuffixText = null;
            TxtUpdateEmail.PromptChar = '_';
            TxtUpdateEmail.ReadOnly = false;
            TxtUpdateEmail.RejectInputOnFirstFailure = false;
            TxtUpdateEmail.ResetOnPrompt = true;
            TxtUpdateEmail.ResetOnSpace = true;
            TxtUpdateEmail.RightToLeft = RightToLeft.No;
            TxtUpdateEmail.SelectedText = "";
            TxtUpdateEmail.SelectionLength = 0;
            TxtUpdateEmail.SelectionStart = 0;
            TxtUpdateEmail.ShortcutsEnabled = true;
            TxtUpdateEmail.Size = new Size(646, 48);
            TxtUpdateEmail.SkipLiterals = true;
            TxtUpdateEmail.TabIndex = 1;
            TxtUpdateEmail.TabStop = false;
            TxtUpdateEmail.TextAlign = HorizontalAlignment.Left;
            TxtUpdateEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtUpdateEmail.TrailingIcon = null;
            TxtUpdateEmail.UseSystemPasswordChar = false;
            TxtUpdateEmail.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(335, 69);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(78, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "User Name";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(335, 187);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Email";
            // 
            // CmbUpdateRole
            // 
            CmbUpdateRole.AutoResize = false;
            CmbUpdateRole.BackColor = Color.FromArgb(80, 80, 80);
            CmbUpdateRole.Depth = 0;
            CmbUpdateRole.DrawMode = DrawMode.OwnerDrawVariable;
            CmbUpdateRole.DropDownHeight = 174;
            CmbUpdateRole.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbUpdateRole.DropDownWidth = 121;
            CmbUpdateRole.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbUpdateRole.ForeColor = Color.FromArgb(222, 255, 255, 255);
            CmbUpdateRole.FormattingEnabled = true;
            CmbUpdateRole.IntegralHeight = false;
            CmbUpdateRole.ItemHeight = 43;
            CmbUpdateRole.Location = new Point(335, 328);
            CmbUpdateRole.MaxDropDownItems = 4;
            CmbUpdateRole.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            CmbUpdateRole.Name = "CmbUpdateRole";
            CmbUpdateRole.Size = new Size(646, 49);
            CmbUpdateRole.StartIndex = 0;
            CmbUpdateRole.TabIndex = 5;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(335, 306);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(32, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Role";
            // 
            // SwcRevokeAccess
            // 
            SwcRevokeAccess.AutoSize = true;
            SwcRevokeAccess.Depth = 0;
            SwcRevokeAccess.Location = new Point(818, 418);
            SwcRevokeAccess.Margin = new Padding(0);
            SwcRevokeAccess.MouseLocation = new Point(-1, -1);
            SwcRevokeAccess.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            SwcRevokeAccess.Name = "SwcRevokeAccess";
            SwcRevokeAccess.Ripple = true;
            SwcRevokeAccess.Size = new Size(163, 37);
            SwcRevokeAccess.TabIndex = 7;
            SwcRevokeAccess.Text = "Revoke Access";
            SwcRevokeAccess.UseVisualStyleBackColor = true;
            // 
            // BtnResetPassword
            // 
            BtnResetPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnResetPassword.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnResetPassword.Depth = 0;
            BtnResetPassword.HighEmphasis = true;
            BtnResetPassword.Icon = null;
            BtnResetPassword.Location = new Point(335, 419);
            BtnResetPassword.Margin = new Padding(4, 6, 4, 6);
            BtnResetPassword.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnResetPassword.Name = "BtnResetPassword";
            BtnResetPassword.NoAccentTextColor = Color.Empty;
            BtnResetPassword.Size = new Size(148, 36);
            BtnResetPassword.TabIndex = 8;
            BtnResetPassword.Text = "Reset Password";
            BtnResetPassword.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnResetPassword.UseAccentColor = false;
            BtnResetPassword.UseVisualStyleBackColor = true;
            BtnResetPassword.Click += BtnResetPassword_Click;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Location = new Point(18, 91);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(294, 286);
            ProfilePicture.TabIndex = 9;
            ProfilePicture.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(18, 69);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(100, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Profile Picture";
            // 
            // BtnUpdate
            // 
            BtnUpdate.AutoSize = false;
            BtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnUpdate.Depth = 0;
            BtnUpdate.HighEmphasis = true;
            BtnUpdate.Icon = null;
            BtnUpdate.Location = new Point(806, 484);
            BtnUpdate.Margin = new Padding(4, 6, 4, 6);
            BtnUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.NoAccentTextColor = Color.Empty;
            BtnUpdate.Size = new Size(175, 36);
            BtnUpdate.TabIndex = 11;
            BtnUpdate.Text = "Update";
            BtnUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnUpdate.UseAccentColor = false;
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // CmbRoleError
            // 
            CmbRoleError.AutoSize = true;
            CmbRoleError.BackColor = Color.Transparent;
            CmbRoleError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CmbRoleError.ForeColor = Color.Red;
            CmbRoleError.Location = new Point(335, 380);
            CmbRoleError.Name = "CmbRoleError";
            CmbRoleError.Size = new Size(0, 20);
            CmbRoleError.TabIndex = 15;
            // 
            // LblEmailError
            // 
            LblEmailError.AutoSize = true;
            LblEmailError.BackColor = Color.Transparent;
            LblEmailError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailError.ForeColor = Color.Red;
            LblEmailError.Location = new Point(335, 260);
            LblEmailError.Name = "LblEmailError";
            LblEmailError.Size = new Size(0, 20);
            LblEmailError.TabIndex = 16;
            // 
            // LblUserNameError
            // 
            LblUserNameError.AutoSize = true;
            LblUserNameError.BackColor = Color.Transparent;
            LblUserNameError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserNameError.ForeColor = Color.Red;
            LblUserNameError.Location = new Point(335, 142);
            LblUserNameError.Name = "LblUserNameError";
            LblUserNameError.Size = new Size(0, 20);
            LblUserNameError.TabIndex = 17;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 550);
            Controls.Add(LblUserNameError);
            Controls.Add(LblEmailError);
            Controls.Add(CmbRoleError);
            Controls.Add(BtnUpdate);
            Controls.Add(materialLabel4);
            Controls.Add(ProfilePicture);
            Controls.Add(BtnResetPassword);
            Controls.Add(SwcRevokeAccess);
            Controls.Add(materialLabel3);
            Controls.Add(CmbUpdateRole);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TxtUpdateEmail);
            Controls.Add(TxtUpdateUserName);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditUser";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditUser";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtUpdateUserName;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtUpdateEmail;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialComboBox CmbUpdateRole;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialSwitch SwcRevokeAccess;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnResetPassword;
        private PictureBox ProfilePicture;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnUpdate;
        private Label CmbRoleError;
        private Label LblEmailError;
        private Label LblUserNameError;
    }
}