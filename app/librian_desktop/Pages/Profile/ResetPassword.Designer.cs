namespace librian_desktop.Pages.Profile
{
    partial class ResetPassword
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
            BtnShowNewPassword = new FontAwesome.Sharp.IconButton();
            LblNewPasswordError = new Label();
            BtnUpdatePassword = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtNewPassword = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            BtnShowOldPassword = new FontAwesome.Sharp.IconButton();
            LblOldPasswordError = new Label();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtOldPassword = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // BtnShowNewPassword
            // 
            BtnShowNewPassword.BackColor = Color.Transparent;
            BtnShowNewPassword.ForeColor = Color.Transparent;
            BtnShowNewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowNewPassword.IconColor = Color.Black;
            BtnShowNewPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnShowNewPassword.IconSize = 25;
            BtnShowNewPassword.Location = new Point(406, 205);
            BtnShowNewPassword.Name = "BtnShowNewPassword";
            BtnShowNewPassword.Size = new Size(25, 25);
            BtnShowNewPassword.TabIndex = 24;
            BtnShowNewPassword.UseVisualStyleBackColor = false;
            BtnShowNewPassword.Click += BtnShowNewPassword_Click;
            // 
            // LblNewPasswordError
            // 
            LblNewPasswordError.AutoSize = true;
            LblNewPasswordError.BackColor = Color.Transparent;
            LblNewPasswordError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblNewPasswordError.ForeColor = Color.Red;
            LblNewPasswordError.Location = new Point(15, 244);
            LblNewPasswordError.Name = "LblNewPasswordError";
            LblNewPasswordError.Size = new Size(0, 20);
            LblNewPasswordError.TabIndex = 23;
            // 
            // BtnUpdatePassword
            // 
            BtnUpdatePassword.AutoSize = false;
            BtnUpdatePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnUpdatePassword.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnUpdatePassword.Depth = 0;
            BtnUpdatePassword.HighEmphasis = true;
            BtnUpdatePassword.Icon = null;
            BtnUpdatePassword.Location = new Point(143, 281);
            BtnUpdatePassword.Margin = new Padding(4, 6, 4, 6);
            BtnUpdatePassword.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnUpdatePassword.Name = "BtnUpdatePassword";
            BtnUpdatePassword.NoAccentTextColor = Color.Empty;
            BtnUpdatePassword.Size = new Size(170, 36);
            BtnUpdatePassword.TabIndex = 22;
            BtnUpdatePassword.Text = "Update";
            BtnUpdatePassword.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnUpdatePassword.UseAccentColor = false;
            BtnUpdatePassword.UseVisualStyleBackColor = true;
            BtnUpdatePassword.Click += BtnUpdatePassword_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(15, 162);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 21;
            materialLabel1.Text = "New Password";
            // 
            // TxtNewPassword
            // 
            TxtNewPassword.AllowPromptAsInput = true;
            TxtNewPassword.AnimateReadOnly = false;
            TxtNewPassword.AsciiOnly = false;
            TxtNewPassword.BackgroundImageLayout = ImageLayout.None;
            TxtNewPassword.BeepOnError = false;
            TxtNewPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtNewPassword.Depth = 0;
            TxtNewPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtNewPassword.HidePromptOnLeave = false;
            TxtNewPassword.HideSelection = true;
            TxtNewPassword.InsertKeyMode = InsertKeyMode.Default;
            TxtNewPassword.LeadingIcon = null;
            TxtNewPassword.Location = new Point(15, 193);
            TxtNewPassword.Mask = "";
            TxtNewPassword.MaxLength = 32767;
            TxtNewPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtNewPassword.Name = "TxtNewPassword";
            TxtNewPassword.PasswordChar = '●';
            TxtNewPassword.PrefixSuffixText = null;
            TxtNewPassword.PromptChar = '_';
            TxtNewPassword.ReadOnly = false;
            TxtNewPassword.RejectInputOnFirstFailure = false;
            TxtNewPassword.ResetOnPrompt = true;
            TxtNewPassword.ResetOnSpace = true;
            TxtNewPassword.RightToLeft = RightToLeft.No;
            TxtNewPassword.SelectedText = "";
            TxtNewPassword.SelectionLength = 0;
            TxtNewPassword.SelectionStart = 0;
            TxtNewPassword.ShortcutsEnabled = true;
            TxtNewPassword.Size = new Size(421, 48);
            TxtNewPassword.SkipLiterals = true;
            TxtNewPassword.TabIndex = 20;
            TxtNewPassword.TabStop = false;
            TxtNewPassword.TextAlign = HorizontalAlignment.Left;
            TxtNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtNewPassword.TrailingIcon = null;
            TxtNewPassword.UseSystemPasswordChar = false;
            TxtNewPassword.ValidatingType = null;
            // 
            // BtnShowOldPassword
            // 
            BtnShowOldPassword.BackColor = Color.Transparent;
            BtnShowOldPassword.ForeColor = Color.Transparent;
            BtnShowOldPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowOldPassword.IconColor = Color.Black;
            BtnShowOldPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnShowOldPassword.IconSize = 25;
            BtnShowOldPassword.Location = new Point(406, 88);
            BtnShowOldPassword.Name = "BtnShowOldPassword";
            BtnShowOldPassword.Size = new Size(25, 25);
            BtnShowOldPassword.TabIndex = 28;
            BtnShowOldPassword.UseVisualStyleBackColor = false;
            BtnShowOldPassword.Click += BtnShowOldPassword_Click;
            // 
            // LblOldPasswordError
            // 
            LblOldPasswordError.AutoSize = true;
            LblOldPasswordError.BackColor = Color.Transparent;
            LblOldPasswordError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblOldPasswordError.ForeColor = Color.Red;
            LblOldPasswordError.Location = new Point(15, 127);
            LblOldPasswordError.Name = "LblOldPasswordError";
            LblOldPasswordError.Size = new Size(0, 20);
            LblOldPasswordError.TabIndex = 27;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, 45);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(99, 19);
            materialLabel2.TabIndex = 26;
            materialLabel2.Text = "Old Password";
            // 
            // TxtOldPassword
            // 
            TxtOldPassword.AllowPromptAsInput = true;
            TxtOldPassword.AnimateReadOnly = false;
            TxtOldPassword.AsciiOnly = false;
            TxtOldPassword.BackgroundImageLayout = ImageLayout.None;
            TxtOldPassword.BeepOnError = false;
            TxtOldPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtOldPassword.Depth = 0;
            TxtOldPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtOldPassword.HidePromptOnLeave = false;
            TxtOldPassword.HideSelection = true;
            TxtOldPassword.InsertKeyMode = InsertKeyMode.Default;
            TxtOldPassword.LeadingIcon = null;
            TxtOldPassword.Location = new Point(15, 76);
            TxtOldPassword.Mask = "";
            TxtOldPassword.MaxLength = 32767;
            TxtOldPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtOldPassword.Name = "TxtOldPassword";
            TxtOldPassword.PasswordChar = '●';
            TxtOldPassword.PrefixSuffixText = null;
            TxtOldPassword.PromptChar = '_';
            TxtOldPassword.ReadOnly = false;
            TxtOldPassword.RejectInputOnFirstFailure = false;
            TxtOldPassword.ResetOnPrompt = true;
            TxtOldPassword.ResetOnSpace = true;
            TxtOldPassword.RightToLeft = RightToLeft.No;
            TxtOldPassword.SelectedText = "";
            TxtOldPassword.SelectionLength = 0;
            TxtOldPassword.SelectionStart = 0;
            TxtOldPassword.ShortcutsEnabled = true;
            TxtOldPassword.Size = new Size(421, 48);
            TxtOldPassword.SkipLiterals = true;
            TxtOldPassword.TabIndex = 25;
            TxtOldPassword.TabStop = false;
            TxtOldPassword.TextAlign = HorizontalAlignment.Left;
            TxtOldPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtOldPassword.TrailingIcon = null;
            TxtOldPassword.UseSystemPasswordChar = false;
            TxtOldPassword.ValidatingType = null;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 350);
            Controls.Add(BtnShowOldPassword);
            Controls.Add(LblOldPasswordError);
            Controls.Add(materialLabel2);
            Controls.Add(TxtOldPassword);
            Controls.Add(BtnShowNewPassword);
            Controls.Add(LblNewPasswordError);
            Controls.Add(BtnUpdatePassword);
            Controls.Add(materialLabel1);
            Controls.Add(TxtNewPassword);
            FormStyle = FormStyles.ActionBar_None;
            Name = "ResetPassword";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetPassword";
            Load += ResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnShowNewPassword;
        private Label LblNewPasswordError;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnUpdatePassword;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtNewPassword;
        private FontAwesome.Sharp.IconButton BtnShowOldPassword;
        private Label LblOldPasswordError;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtOldPassword;
    }
}