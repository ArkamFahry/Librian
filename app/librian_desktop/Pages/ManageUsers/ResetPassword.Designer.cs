namespace librian_desktop.Pages.ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            TxtNewPassword = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            BtnUpdatePassword = new MaterialSkin2DotNet.Controls.MaterialButton();
            LblPasswordError = new Label();
            BtnShowPassword = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
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
            TxtNewPassword.Location = new Point(15, 91);
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
            TxtNewPassword.TabIndex = 0;
            TxtNewPassword.TabStop = false;
            TxtNewPassword.TextAlign = HorizontalAlignment.Left;
            TxtNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtNewPassword.TrailingIcon = null;
            TxtNewPassword.UseSystemPasswordChar = false;
            TxtNewPassword.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(15, 60);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "New Password";
            // 
            // BtnUpdatePassword
            // 
            BtnUpdatePassword.AutoSize = false;
            BtnUpdatePassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnUpdatePassword.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnUpdatePassword.Depth = 0;
            BtnUpdatePassword.HighEmphasis = true;
            BtnUpdatePassword.Icon = null;
            BtnUpdatePassword.Location = new Point(142, 188);
            BtnUpdatePassword.Margin = new Padding(4, 6, 4, 6);
            BtnUpdatePassword.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnUpdatePassword.Name = "BtnUpdatePassword";
            BtnUpdatePassword.NoAccentTextColor = Color.Empty;
            BtnUpdatePassword.Size = new Size(170, 36);
            BtnUpdatePassword.TabIndex = 2;
            BtnUpdatePassword.Text = "Update";
            BtnUpdatePassword.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnUpdatePassword.UseAccentColor = false;
            BtnUpdatePassword.UseVisualStyleBackColor = true;
            BtnUpdatePassword.Click += BtnUpdatePassword_Click;
            // 
            // LblPasswordError
            // 
            LblPasswordError.AutoSize = true;
            LblPasswordError.BackColor = Color.Transparent;
            LblPasswordError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPasswordError.ForeColor = Color.Red;
            LblPasswordError.Location = new Point(15, 142);
            LblPasswordError.Name = "LblPasswordError";
            LblPasswordError.Size = new Size(0, 20);
            LblPasswordError.TabIndex = 17;
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.BackColor = Color.Transparent;
            BtnShowPassword.ForeColor = Color.Transparent;
            BtnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowPassword.IconColor = Color.Black;
            BtnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnShowPassword.IconSize = 25;
            BtnShowPassword.Location = new Point(406, 105);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(25, 25);
            BtnShowPassword.TabIndex = 19;
            BtnShowPassword.UseVisualStyleBackColor = false;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 250);
            Controls.Add(BtnShowPassword);
            Controls.Add(LblPasswordError);
            Controls.Add(BtnUpdatePassword);
            Controls.Add(materialLabel1);
            Controls.Add(TxtNewPassword);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResetPassword";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtNewPassword;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnUpdatePassword;
        private Label LblPasswordError;
        private FontAwesome.Sharp.IconButton BtnShowPassword;
    }
}