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
            BookSearchBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // BookSearchBox
            // 
            BookSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BookSearchBox.AnimateReadOnly = false;
            BookSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            BookSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            BookSearchBox.BackgroundImageLayout = ImageLayout.None;
            BookSearchBox.CharacterCasing = CharacterCasing.Normal;
            BookSearchBox.Depth = 0;
            BookSearchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            BookSearchBox.HideSelection = true;
            BookSearchBox.LeadingIcon = null;
            BookSearchBox.Location = new Point(61, 20);
            BookSearchBox.MaxLength = 32767;
            BookSearchBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            BookSearchBox.Name = "BookSearchBox";
            BookSearchBox.PasswordChar = '\0';
            BookSearchBox.PrefixSuffixText = null;
            BookSearchBox.ReadOnly = false;
            BookSearchBox.RightToLeft = RightToLeft.No;
            BookSearchBox.SelectedText = "";
            BookSearchBox.SelectionLength = 0;
            BookSearchBox.SelectionStart = 0;
            BookSearchBox.ShortcutsEnabled = true;
            BookSearchBox.Size = new Size(933, 48);
            BookSearchBox.TabIndex = 0;
            BookSearchBox.TabStop = false;
            BookSearchBox.TextAlign = HorizontalAlignment.Left;
            BookSearchBox.TrailingIcon = null;
            BookSearchBox.UseSystemPasswordChar = false;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(BookSearchBox);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ViewBooks";
            Padding = new Padding(3, 0, 3, 3);
            Text = "ViewBooks";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTextBox2 BookSearchBox;
    }
}