namespace librian_desktop.Auth
{
    partial class SignUp
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
            BtnSignUp = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtSignUpEmail = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            TxtSignUpUserName = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtSignUpPassword = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            LblUserNameError = new Label();
            LblEmailError = new Label();
            LblPasswordError = new Label();
            BtnShowPassword = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // BtnSignUp
            // 
            BtnSignUp.AutoSize = false;
            BtnSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSignUp.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnSignUp.Depth = 0;
            BtnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSignUp.HighEmphasis = true;
            BtnSignUp.Icon = null;
            BtnSignUp.Location = new Point(128, 364);
            BtnSignUp.Margin = new Padding(4, 6, 4, 6);
            BtnSignUp.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.NoAccentTextColor = Color.Empty;
            BtnSignUp.Size = new Size(140, 40);
            BtnSignUp.TabIndex = 9;
            BtnSignUp.Text = "SignUp";
            BtnSignUp.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnSignUp.UseAccentColor = false;
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(18, 136);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Email";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 18);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(78, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "User Name";
            // 
            // TxtSignUpEmail
            // 
            TxtSignUpEmail.AllowPromptAsInput = true;
            TxtSignUpEmail.AnimateReadOnly = false;
            TxtSignUpEmail.AsciiOnly = false;
            TxtSignUpEmail.BackgroundImageLayout = ImageLayout.None;
            TxtSignUpEmail.BeepOnError = false;
            TxtSignUpEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpEmail.Depth = 0;
            TxtSignUpEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSignUpEmail.HidePromptOnLeave = false;
            TxtSignUpEmail.HideSelection = true;
            TxtSignUpEmail.InsertKeyMode = InsertKeyMode.Default;
            TxtSignUpEmail.LeadingIcon = null;
            TxtSignUpEmail.Location = new Point(18, 158);
            TxtSignUpEmail.Mask = "";
            TxtSignUpEmail.MaxLength = 32767;
            TxtSignUpEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtSignUpEmail.Name = "TxtSignUpEmail";
            TxtSignUpEmail.PasswordChar = '\0';
            TxtSignUpEmail.PrefixSuffixText = null;
            TxtSignUpEmail.PromptChar = '_';
            TxtSignUpEmail.ReadOnly = false;
            TxtSignUpEmail.RejectInputOnFirstFailure = false;
            TxtSignUpEmail.ResetOnPrompt = true;
            TxtSignUpEmail.ResetOnSpace = true;
            TxtSignUpEmail.RightToLeft = RightToLeft.No;
            TxtSignUpEmail.SelectedText = "";
            TxtSignUpEmail.SelectionLength = 0;
            TxtSignUpEmail.SelectionStart = 0;
            TxtSignUpEmail.ShortcutsEnabled = true;
            TxtSignUpEmail.Size = new Size(366, 48);
            TxtSignUpEmail.SkipLiterals = true;
            TxtSignUpEmail.TabIndex = 6;
            TxtSignUpEmail.TabStop = false;
            TxtSignUpEmail.TextAlign = HorizontalAlignment.Left;
            TxtSignUpEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpEmail.TrailingIcon = null;
            TxtSignUpEmail.UseSystemPasswordChar = false;
            TxtSignUpEmail.ValidatingType = null;
            // 
            // TxtSignUpUserName
            // 
            TxtSignUpUserName.AllowPromptAsInput = true;
            TxtSignUpUserName.AnimateReadOnly = false;
            TxtSignUpUserName.AsciiOnly = false;
            TxtSignUpUserName.BackgroundImageLayout = ImageLayout.None;
            TxtSignUpUserName.BeepOnError = false;
            TxtSignUpUserName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpUserName.Depth = 0;
            TxtSignUpUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSignUpUserName.HidePromptOnLeave = false;
            TxtSignUpUserName.HideSelection = true;
            TxtSignUpUserName.InsertKeyMode = InsertKeyMode.Default;
            TxtSignUpUserName.LeadingIcon = null;
            TxtSignUpUserName.Location = new Point(18, 40);
            TxtSignUpUserName.Mask = "";
            TxtSignUpUserName.MaxLength = 32767;
            TxtSignUpUserName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtSignUpUserName.Name = "TxtSignUpUserName";
            TxtSignUpUserName.PasswordChar = '\0';
            TxtSignUpUserName.PrefixSuffixText = null;
            TxtSignUpUserName.PromptChar = '_';
            TxtSignUpUserName.ReadOnly = false;
            TxtSignUpUserName.RejectInputOnFirstFailure = false;
            TxtSignUpUserName.ResetOnPrompt = true;
            TxtSignUpUserName.ResetOnSpace = true;
            TxtSignUpUserName.RightToLeft = RightToLeft.No;
            TxtSignUpUserName.SelectedText = "";
            TxtSignUpUserName.SelectionLength = 0;
            TxtSignUpUserName.SelectionStart = 0;
            TxtSignUpUserName.ShortcutsEnabled = true;
            TxtSignUpUserName.Size = new Size(366, 48);
            TxtSignUpUserName.SkipLiterals = true;
            TxtSignUpUserName.TabIndex = 5;
            TxtSignUpUserName.TabStop = false;
            TxtSignUpUserName.TextAlign = HorizontalAlignment.Left;
            TxtSignUpUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpUserName.TrailingIcon = null;
            TxtSignUpUserName.UseSystemPasswordChar = false;
            TxtSignUpUserName.ValidatingType = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(18, 247);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(71, 19);
            materialLabel3.TabIndex = 11;
            materialLabel3.Text = "Password";
            // 
            // TxtSignUpPassword
            // 
            TxtSignUpPassword.AllowPromptAsInput = true;
            TxtSignUpPassword.AnimateReadOnly = false;
            TxtSignUpPassword.AsciiOnly = false;
            TxtSignUpPassword.BackgroundImageLayout = ImageLayout.None;
            TxtSignUpPassword.BeepOnError = false;
            TxtSignUpPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpPassword.Depth = 0;
            TxtSignUpPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSignUpPassword.HidePromptOnLeave = false;
            TxtSignUpPassword.HideSelection = true;
            TxtSignUpPassword.InsertKeyMode = InsertKeyMode.Default;
            TxtSignUpPassword.LeadingIcon = null;
            TxtSignUpPassword.Location = new Point(18, 269);
            TxtSignUpPassword.Mask = "";
            TxtSignUpPassword.MaxLength = 32767;
            TxtSignUpPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtSignUpPassword.Name = "TxtSignUpPassword";
            TxtSignUpPassword.PasswordChar = '●';
            TxtSignUpPassword.PrefixSuffixText = null;
            TxtSignUpPassword.PromptChar = '*';
            TxtSignUpPassword.ReadOnly = false;
            TxtSignUpPassword.RejectInputOnFirstFailure = false;
            TxtSignUpPassword.ResetOnPrompt = true;
            TxtSignUpPassword.ResetOnSpace = true;
            TxtSignUpPassword.RightToLeft = RightToLeft.No;
            TxtSignUpPassword.SelectedText = "";
            TxtSignUpPassword.SelectionLength = 0;
            TxtSignUpPassword.SelectionStart = 0;
            TxtSignUpPassword.ShortcutsEnabled = true;
            TxtSignUpPassword.Size = new Size(366, 48);
            TxtSignUpPassword.SkipLiterals = true;
            TxtSignUpPassword.TabIndex = 10;
            TxtSignUpPassword.TabStop = false;
            TxtSignUpPassword.TextAlign = HorizontalAlignment.Left;
            TxtSignUpPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtSignUpPassword.TrailingIcon = null;
            TxtSignUpPassword.UseSystemPasswordChar = false;
            TxtSignUpPassword.ValidatingType = null;
            // 
            // LblUserNameError
            // 
            LblUserNameError.AutoSize = true;
            LblUserNameError.BackColor = Color.Transparent;
            LblUserNameError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserNameError.ForeColor = Color.Red;
            LblUserNameError.Location = new Point(18, 91);
            LblUserNameError.Name = "LblUserNameError";
            LblUserNameError.Size = new Size(0, 20);
            LblUserNameError.TabIndex = 12;
            // 
            // LblEmailError
            // 
            LblEmailError.AutoSize = true;
            LblEmailError.BackColor = Color.Transparent;
            LblEmailError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailError.ForeColor = Color.Red;
            LblEmailError.Location = new Point(18, 209);
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
            LblPasswordError.Location = new Point(18, 320);
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
            BtnShowPassword.Location = new Point(354, 281);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(25, 25);
            BtnShowPassword.TabIndex = 18;
            BtnShowPassword.UseVisualStyleBackColor = false;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 427);
            Controls.Add(BtnShowPassword);
            Controls.Add(LblPasswordError);
            Controls.Add(LblEmailError);
            Controls.Add(LblUserNameError);
            Controls.Add(materialLabel3);
            Controls.Add(TxtSignUpPassword);
            Controls.Add(BtnSignUp);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TxtSignUpEmail);
            Controls.Add(TxtSignUpUserName);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "SignUp";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton BtnSignUp;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtSignUpEmail;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtSignUpUserName;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtSignUpPassword;
        private Label LblUserNameError;
        private Label LblEmailError;
        private Label LblPasswordError;
        private FontAwesome.Sharp.IconButton BtnShowPassword;
    }
}