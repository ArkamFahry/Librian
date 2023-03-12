namespace librian_desktop.Pages.ManageUsers
{
    partial class ViewUsers
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
            FlowPanelUserView = new FlowLayoutPanel();
            SearchBoxUser = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // FlowPanelUserView
            // 
            FlowPanelUserView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowPanelUserView.AutoScroll = true;
            FlowPanelUserView.BackColor = Color.Transparent;
            FlowPanelUserView.Location = new Point(19, 85);
            FlowPanelUserView.Name = "FlowPanelUserView";
            FlowPanelUserView.Size = new Size(1020, 550);
            FlowPanelUserView.TabIndex = 2;
            // 
            // SearchBoxUser
            // 
            SearchBoxUser.AllowPromptAsInput = true;
            SearchBoxUser.AnimateReadOnly = false;
            SearchBoxUser.AsciiOnly = false;
            SearchBoxUser.BackgroundImageLayout = ImageLayout.None;
            SearchBoxUser.BeepOnError = false;
            SearchBoxUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            SearchBoxUser.Depth = 0;
            SearchBoxUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SearchBoxUser.HidePromptOnLeave = false;
            SearchBoxUser.HideSelection = true;
            SearchBoxUser.InsertKeyMode = InsertKeyMode.Default;
            SearchBoxUser.LeadingIcon = null;
            SearchBoxUser.Location = new Point(19, 19);
            SearchBoxUser.Mask = "";
            SearchBoxUser.MaxLength = 32767;
            SearchBoxUser.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            SearchBoxUser.Name = "SearchBoxUser";
            SearchBoxUser.PasswordChar = '\0';
            SearchBoxUser.PrefixSuffixText = null;
            SearchBoxUser.PromptChar = '_';
            SearchBoxUser.ReadOnly = false;
            SearchBoxUser.RejectInputOnFirstFailure = false;
            SearchBoxUser.ResetOnPrompt = true;
            SearchBoxUser.ResetOnSpace = true;
            SearchBoxUser.RightToLeft = RightToLeft.No;
            SearchBoxUser.SelectedText = "";
            SearchBoxUser.SelectionLength = 0;
            SearchBoxUser.SelectionStart = 0;
            SearchBoxUser.ShortcutsEnabled = true;
            SearchBoxUser.Size = new Size(1020, 48);
            SearchBoxUser.SkipLiterals = true;
            SearchBoxUser.TabIndex = 3;
            SearchBoxUser.TabStop = false;
            SearchBoxUser.TextAlign = HorizontalAlignment.Left;
            SearchBoxUser.TextMaskFormat = MaskFormat.IncludeLiterals;
            SearchBoxUser.TrailingIcon = null;
            SearchBoxUser.UseSystemPasswordChar = false;
            SearchBoxUser.ValidatingType = null;
            SearchBoxUser.TextChanged += SearchBoxUser_TextChanged;
            // 
            // ViewUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(SearchBoxUser);
            Controls.Add(FlowPanelUserView);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ViewUsers";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "ViewUsers";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel FlowPanelUserView;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox SearchBoxUser;
    }
}