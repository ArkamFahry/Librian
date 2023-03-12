namespace librian_desktop.Pages.Books
{
    partial class ViewBooks
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
            FlowPanelBookView = new FlowLayoutPanel();
            SearchBoxBooks = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // FlowPanelBookView
            // 
            FlowPanelBookView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowPanelBookView.AutoScroll = true;
            FlowPanelBookView.BackColor = Color.Transparent;
            FlowPanelBookView.Location = new Point(20, 87);
            FlowPanelBookView.Name = "FlowPanelBookView";
            FlowPanelBookView.Size = new Size(1020, 550);
            FlowPanelBookView.TabIndex = 1;
            // 
            // SearchBoxBooks
            // 
            SearchBoxBooks.AllowPromptAsInput = true;
            SearchBoxBooks.AnimateReadOnly = false;
            SearchBoxBooks.AsciiOnly = false;
            SearchBoxBooks.BackgroundImageLayout = ImageLayout.None;
            SearchBoxBooks.BeepOnError = false;
            SearchBoxBooks.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            SearchBoxBooks.Depth = 0;
            SearchBoxBooks.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SearchBoxBooks.HidePromptOnLeave = false;
            SearchBoxBooks.HideSelection = true;
            SearchBoxBooks.InsertKeyMode = InsertKeyMode.Default;
            SearchBoxBooks.LeadingIcon = null;
            SearchBoxBooks.Location = new Point(20, 19);
            SearchBoxBooks.Mask = "";
            SearchBoxBooks.MaxLength = 32767;
            SearchBoxBooks.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            SearchBoxBooks.Name = "SearchBoxBooks";
            SearchBoxBooks.PasswordChar = '\0';
            SearchBoxBooks.PrefixSuffixText = null;
            SearchBoxBooks.PromptChar = '_';
            SearchBoxBooks.ReadOnly = false;
            SearchBoxBooks.RejectInputOnFirstFailure = false;
            SearchBoxBooks.ResetOnPrompt = true;
            SearchBoxBooks.ResetOnSpace = true;
            SearchBoxBooks.RightToLeft = RightToLeft.No;
            SearchBoxBooks.SelectedText = "";
            SearchBoxBooks.SelectionLength = 0;
            SearchBoxBooks.SelectionStart = 0;
            SearchBoxBooks.ShortcutsEnabled = true;
            SearchBoxBooks.Size = new Size(1020, 48);
            SearchBoxBooks.SkipLiterals = true;
            SearchBoxBooks.TabIndex = 4;
            SearchBoxBooks.TabStop = false;
            SearchBoxBooks.TextAlign = HorizontalAlignment.Left;
            SearchBoxBooks.TextMaskFormat = MaskFormat.IncludeLiterals;
            SearchBoxBooks.TrailingIcon = null;
            SearchBoxBooks.UseSystemPasswordChar = false;
            SearchBoxBooks.ValidatingType = null;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1060, 655);
            Controls.Add(SearchBoxBooks);
            Controls.Add(FlowPanelBookView);
            ForeColor = Color.Black;
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ViewBooks";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "ViewBooks";
            TextShade = MaterialSkin2DotNet.TextShade.BLACK;
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel FlowPanelBookView;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox SearchBoxBooks;
    }
}