namespace librian_desktop.Pages.ManageBooks
{
    partial class AddBooks
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
            TxtBookName = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            BookCoverPicture = new PictureBox();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtBookDescription = new RichTextBox();
            CmbBookAuthors = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            Authors = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            CmbBookCategories = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            BtnCreateBook = new MaterialSkin2DotNet.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)BookCoverPicture).BeginInit();
            SuspendLayout();
            // 
            // TxtBookName
            // 
            TxtBookName.AllowPromptAsInput = true;
            TxtBookName.AnimateReadOnly = false;
            TxtBookName.AsciiOnly = false;
            TxtBookName.BackgroundImageLayout = ImageLayout.None;
            TxtBookName.BeepOnError = false;
            TxtBookName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TxtBookName.Depth = 0;
            TxtBookName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBookName.HidePromptOnLeave = false;
            TxtBookName.HideSelection = true;
            TxtBookName.InsertKeyMode = InsertKeyMode.Default;
            TxtBookName.LeadingIcon = null;
            TxtBookName.Location = new Point(304, 69);
            TxtBookName.Mask = "";
            TxtBookName.MaxLength = 32767;
            TxtBookName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtBookName.Name = "TxtBookName";
            TxtBookName.PasswordChar = '\0';
            TxtBookName.PrefixSuffixText = null;
            TxtBookName.PromptChar = '_';
            TxtBookName.ReadOnly = false;
            TxtBookName.RejectInputOnFirstFailure = false;
            TxtBookName.ResetOnPrompt = true;
            TxtBookName.ResetOnSpace = true;
            TxtBookName.RightToLeft = RightToLeft.No;
            TxtBookName.SelectedText = "";
            TxtBookName.SelectionLength = 0;
            TxtBookName.SelectionStart = 0;
            TxtBookName.ShortcutsEnabled = true;
            TxtBookName.Size = new Size(697, 48);
            TxtBookName.SkipLiterals = true;
            TxtBookName.TabIndex = 0;
            TxtBookName.TabStop = false;
            TxtBookName.TextAlign = HorizontalAlignment.Left;
            TxtBookName.TextMaskFormat = MaskFormat.IncludeLiterals;
            TxtBookName.TrailingIcon = null;
            TxtBookName.UseSystemPasswordChar = false;
            TxtBookName.ValidatingType = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(304, 47);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(43, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Name";
            // 
            // BookCoverPicture
            // 
            BookCoverPicture.Location = new Point(21, 69);
            BookCoverPicture.Name = "BookCoverPicture";
            BookCoverPicture.Size = new Size(257, 403);
            BookCoverPicture.TabIndex = 2;
            BookCoverPicture.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(21, 47);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(81, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Cover Page";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(304, 133);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(81, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Description";
            // 
            // TxtBookDescription
            // 
            TxtBookDescription.Location = new Point(304, 155);
            TxtBookDescription.Name = "TxtBookDescription";
            TxtBookDescription.Size = new Size(697, 128);
            TxtBookDescription.TabIndex = 6;
            TxtBookDescription.Text = "";
            // 
            // CmbBookAuthors
            // 
            CmbBookAuthors.AutoResize = false;
            CmbBookAuthors.BackColor = Color.FromArgb(80, 80, 80);
            CmbBookAuthors.Depth = 0;
            CmbBookAuthors.DrawMode = DrawMode.OwnerDrawVariable;
            CmbBookAuthors.DropDownHeight = 174;
            CmbBookAuthors.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBookAuthors.DropDownWidth = 121;
            CmbBookAuthors.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbBookAuthors.ForeColor = Color.FromArgb(222, 255, 255, 255);
            CmbBookAuthors.FormattingEnabled = true;
            CmbBookAuthors.IntegralHeight = false;
            CmbBookAuthors.ItemHeight = 43;
            CmbBookAuthors.Location = new Point(304, 318);
            CmbBookAuthors.MaxDropDownItems = 4;
            CmbBookAuthors.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            CmbBookAuthors.Name = "CmbBookAuthors";
            CmbBookAuthors.Size = new Size(697, 49);
            CmbBookAuthors.StartIndex = 0;
            CmbBookAuthors.TabIndex = 7;
            // 
            // Authors
            // 
            Authors.AutoSize = true;
            Authors.Depth = 0;
            Authors.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Authors.Location = new Point(304, 296);
            Authors.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Authors.Name = "Authors";
            Authors.Size = new Size(56, 19);
            Authors.TabIndex = 8;
            Authors.Text = "Authors";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(304, 401);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(76, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Categories";
            // 
            // CmbBookCategories
            // 
            CmbBookCategories.AutoResize = false;
            CmbBookCategories.BackColor = Color.FromArgb(80, 80, 80);
            CmbBookCategories.Depth = 0;
            CmbBookCategories.DrawMode = DrawMode.OwnerDrawVariable;
            CmbBookCategories.DropDownHeight = 174;
            CmbBookCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBookCategories.DropDownWidth = 121;
            CmbBookCategories.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CmbBookCategories.ForeColor = Color.FromArgb(222, 255, 255, 255);
            CmbBookCategories.FormattingEnabled = true;
            CmbBookCategories.IntegralHeight = false;
            CmbBookCategories.ItemHeight = 43;
            CmbBookCategories.Location = new Point(304, 423);
            CmbBookCategories.MaxDropDownItems = 4;
            CmbBookCategories.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            CmbBookCategories.Name = "CmbBookCategories";
            CmbBookCategories.Size = new Size(697, 49);
            CmbBookCategories.StartIndex = 0;
            CmbBookCategories.TabIndex = 9;
            // 
            // BtnCreateBook
            // 
            BtnCreateBook.AutoSize = false;
            BtnCreateBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCreateBook.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCreateBook.Depth = 0;
            BtnCreateBook.HighEmphasis = true;
            BtnCreateBook.Icon = null;
            BtnCreateBook.Location = new Point(831, 495);
            BtnCreateBook.Margin = new Padding(4, 6, 4, 6);
            BtnCreateBook.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnCreateBook.Name = "BtnCreateBook";
            BtnCreateBook.NoAccentTextColor = Color.Empty;
            BtnCreateBook.Size = new Size(170, 35);
            BtnCreateBook.TabIndex = 11;
            BtnCreateBook.Text = "Create";
            BtnCreateBook.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnCreateBook.UseAccentColor = false;
            BtnCreateBook.UseVisualStyleBackColor = true;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 550);
            Controls.Add(BtnCreateBook);
            Controls.Add(materialLabel4);
            Controls.Add(CmbBookCategories);
            Controls.Add(Authors);
            Controls.Add(CmbBookAuthors);
            Controls.Add(TxtBookDescription);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(BookCoverPicture);
            Controls.Add(materialLabel1);
            Controls.Add(TxtBookName);
            FormStyle = FormStyles.ActionBar_None;
            Name = "AddBooks";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)BookCoverPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox TxtBookName;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private PictureBox BookCoverPicture;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private RichTextBox TxtBookDescription;
        private MaterialSkin2DotNet.Controls.MaterialComboBox CmbBookAuthors;
        private MaterialSkin2DotNet.Controls.MaterialLabel Authors;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
        private MaterialSkin2DotNet.Controls.MaterialComboBox CmbBookCategories;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnCreateBook;
    }
}