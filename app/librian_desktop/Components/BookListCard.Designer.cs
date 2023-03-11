namespace librian_desktop.Components
{
    partial class BookListCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBookImage = new PictureBox();
            LabelBookName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)PictureBookImage).BeginInit();
            SuspendLayout();
            // 
            // PictureBookImage
            // 
            PictureBookImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PictureBookImage.BackColor = Color.Transparent;
            PictureBookImage.Location = new Point(3, 1);
            PictureBookImage.Name = "PictureBookImage";
            PictureBookImage.Size = new Size(204, 197);
            PictureBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBookImage.TabIndex = 3;
            PictureBookImage.TabStop = false;
            // 
            // LabelBookName
            // 
            LabelBookName.AutoSize = true;
            LabelBookName.Depth = 0;
            LabelBookName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelBookName.Location = new Point(221, 11);
            LabelBookName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelBookName.Name = "LabelBookName";
            LabelBookName.Size = new Size(83, 19);
            LabelBookName.TabIndex = 4;
            LabelBookName.Text = "Book Name";
            // 
            // BookListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Black;
            Controls.Add(LabelBookName);
            Controls.Add(PictureBookImage);
            Name = "BookListCard";
            Size = new Size(995, 200);
            ((System.ComponentModel.ISupportInitialize)PictureBookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBookImage;
        private MaterialSkin2DotNet.Controls.MaterialLabel LabelBookName;
    }
}
