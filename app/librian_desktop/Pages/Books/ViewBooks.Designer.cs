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
            BooksSearchBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
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
            // BooksSearchBox
            // 
            BooksSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BooksSearchBox.AnimateReadOnly = false;
            BooksSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            BooksSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            BooksSearchBox.BackgroundImageLayout = ImageLayout.None;
            BooksSearchBox.CharacterCasing = CharacterCasing.Normal;
            BooksSearchBox.Depth = 0;
            BooksSearchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            BooksSearchBox.HideSelection = true;
            BooksSearchBox.LeadingIcon = null;
            BooksSearchBox.Location = new Point(20, 22);
            BooksSearchBox.MaxLength = 32767;
            BooksSearchBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            BooksSearchBox.Name = "BooksSearchBox";
            BooksSearchBox.PasswordChar = '\0';
            BooksSearchBox.PrefixSuffixText = null;
            BooksSearchBox.ReadOnly = false;
            BooksSearchBox.RightToLeft = RightToLeft.No;
            BooksSearchBox.SelectedText = "";
            BooksSearchBox.SelectionLength = 0;
            BooksSearchBox.SelectionStart = 0;
            BooksSearchBox.ShortcutsEnabled = true;
            BooksSearchBox.Size = new Size(1020, 48);
            BooksSearchBox.TabIndex = 2;
            BooksSearchBox.TabStop = false;
            BooksSearchBox.TextAlign = HorizontalAlignment.Left;
            BooksSearchBox.TrailingIcon = null;
            BooksSearchBox.UseSystemPasswordChar = false;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(BooksSearchBox);
            Controls.Add(FlowPanelBookView);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ViewBooks";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "ViewBooks";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel FlowPanelBookView;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 BooksSearchBox;
    }
}