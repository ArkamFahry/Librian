namespace librian_desktop.Auth
{
    partial class Login
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
            TxtLoginEmail = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            TxtLoginPassword = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            BtnLogin = new MaterialSkin2DotNet.Controls.MaterialButton();
            LblEmailError = new Label();
            LblPasswordError = new Label();
            BtnShowPassword = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // TxtLoginEmail
            // 
            TxtLoginEmail.AllowPromptAsInput = true;
            TxtLoginEmail.AnimateReadOnly = false;
            TxtLoginEmail.AsciiOnly = false;
            TxtLoginEmail.BackgroundImageLayout = ImageLayout.None;
            TxtLoginEmail.BeepOnError = false;
            TxtLoginEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtLoginEmail.Depth = 0;
            TxtLoginEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtLoginEmail.HidePromptOnLeave = false;
            TxtLoginEmail.HideSelection = true;
            TxtLoginEmail.InsertKeyMode = InsertKeyMode.Default;
            TxtLoginEmail.LeadingIcon = null;
            TxtLoginEmail.Location = new Point(17, 81);
            TxtLoginEmail.Mask = "";
            TxtLoginEmail.MaxLength = 32767;
            TxtLoginEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtLoginEmail.Name = "TxtLoginEmail";
            TxtLoginEmail.PasswordChar = '\0';
            TxtLoginEmail.PrefixSuffixText = null;
            TxtLoginEmail.PromptChar = '_';
            TxtLoginEmail.ReadOnly = false;
            TxtLoginEmail.RejectInputOnFirstFailure = false;
            TxtLoginEmail.ResetOnPrompt = true;
            TxtLoginEmail.ResetOnSpace = true;
            TxtLoginEmail.RightToLeft = RightToLeft.No;
            TxtLoginEmail.SelectedText = "";
            TxtLoginEmail.SelectionLength = 0;
            TxtLoginEmail.SelectionStart = 0;
            TxtLoginEmail.ShortcutsEnabled = true;
            TxtLoginEmail.Size = new Size(367, 48);
            TxtLoginEmail.SkipLiterals = true;
            TxtLoginEmail.TabIndex = 0;
            TxtLoginEmail.TabStop = false;
            TxtLoginEmail.TextAlign = HorizontalAlignment.Left;
            TxtLoginEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtLoginEmail.TrailingIcon = null;
            TxtLoginEmail.UseSystemPasswordChar = false;
            TxtLoginEmail.ValidatingType = null;
            // 
            // TxtLoginPassword
            // 
            TxtLoginPassword.AllowPromptAsInput = true;
            TxtLoginPassword.AnimateReadOnly = false;
            TxtLoginPassword.AsciiOnly = false;
            TxtLoginPassword.BackgroundImageLayout = ImageLayout.None;
            TxtLoginPassword.BeepOnError = false;
            TxtLoginPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtLoginPassword.Depth = 0;
            TxtLoginPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtLoginPassword.HidePromptOnLeave = false;
            TxtLoginPassword.HideSelection = true;
            TxtLoginPassword.InsertKeyMode = InsertKeyMode.Default;
            TxtLoginPassword.LeadingIcon = null;
            TxtLoginPassword.Location = new Point(17, 219);
            TxtLoginPassword.Mask = "";
            TxtLoginPassword.MaxLength = 32767;
            TxtLoginPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtLoginPassword.Name = "TxtLoginPassword";
            TxtLoginPassword.PasswordChar = '●';
            TxtLoginPassword.PrefixSuffixText = null;
            TxtLoginPassword.PromptChar = '*';
            TxtLoginPassword.ReadOnly = false;
            TxtLoginPassword.RejectInputOnFirstFailure = false;
            TxtLoginPassword.ResetOnPrompt = true;
            TxtLoginPassword.ResetOnSpace = true;
            TxtLoginPassword.RightToLeft = RightToLeft.No;
            TxtLoginPassword.SelectedText = "";
            TxtLoginPassword.SelectionLength = 0;
            TxtLoginPassword.SelectionStart = 0;
            TxtLoginPassword.ShortcutsEnabled = true;
            TxtLoginPassword.Size = new Size(367, 48);
            TxtLoginPassword.SkipLiterals = true;
            TxtLoginPassword.TabIndex = 1;
            TxtLoginPassword.TabStop = false;
            TxtLoginPassword.TextAlign = HorizontalAlignment.Left;
            TxtLoginPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtLoginPassword.TrailingIcon = null;
            TxtLoginPassword.UseSystemPasswordChar = false;
            TxtLoginPassword.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 59);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 197);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.AutoSize = false;
            BtnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLogin.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnLogin.Depth = 0;
            BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnLogin.HighEmphasis = true;
            BtnLogin.Icon = null;
            BtnLogin.Location = new Point(128, 339);
            BtnLogin.Margin = new Padding(4, 6, 4, 6);
            BtnLogin.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnLogin.Name = "BtnLogin";
            BtnLogin.NoAccentTextColor = Color.Empty;
            BtnLogin.Size = new Size(140, 40);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnLogin.UseAccentColor = false;
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LblEmailError
            // 
            LblEmailError.AutoSize = true;
            LblEmailError.BackColor = Color.Transparent;
            LblEmailError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailError.ForeColor = Color.Red;
            LblEmailError.Location = new Point(17, 132);
            LblEmailError.Name = "LblEmailError";
            LblEmailError.Size = new Size(0, 20);
            LblEmailError.TabIndex = 13;
            // 
            // LblPasswordError
            // 
            LblPasswordError.AutoSize = true;
            LblPasswordError.BackColor = Color.Transparent;
            LblPasswordError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPasswordError.ForeColor = Color.Red;
            LblPasswordError.Location = new Point(17, 270);
            LblPasswordError.Name = "LblPasswordError";
            LblPasswordError.Size = new Size(0, 20);
            LblPasswordError.TabIndex = 14;
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.BackColor = Color.Transparent;
            BtnShowPassword.ForeColor = Color.Transparent;
            BtnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowPassword.IconColor = Color.Black;
            BtnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnShowPassword.IconSize = 25;
            BtnShowPassword.Location = new Point(353, 231);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(25, 25);
            BtnShowPassword.TabIndex = 19;
            BtnShowPassword.UseVisualStyleBackColor = false;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 427);
            Controls.Add(BtnShowPassword);
            Controls.Add(LblPasswordError);
            Controls.Add(LblEmailError);
            Controls.Add(BtnLogin);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TxtLoginPassword);
            Controls.Add(TxtLoginEmail);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Login";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "Login";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtLoginEmail;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtLoginPassword;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnLogin;
        private Label LblEmailError;
        private Label LblPasswordError;
        private FontAwesome.Sharp.IconButton BtnShowPassword;
    }
}