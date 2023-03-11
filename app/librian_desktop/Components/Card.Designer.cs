namespace librian_desktop.Components
{
    partial class Card
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
            LblBookImage = new PictureBox();
            LabelBookName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)LblBookImage).BeginInit();
            SuspendLayout();
            // 
            // LblBookImage
            // 
            LblBookImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblBookImage.BackColor = Color.Transparent;
            LblBookImage.Location = new Point(0, 1);
            LblBookImage.Name = "LblBookImage";
            LblBookImage.Size = new Size(204, 197);
            LblBookImage.TabIndex = 0;
            LblBookImage.TabStop = false;
            // 
            // LabelBookName
            // 
            LabelBookName.AutoSize = true;
            LabelBookName.Depth = 0;
            LabelBookName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelBookName.Location = new Point(219, 14);
            LabelBookName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            LabelBookName.Name = "LabelBookName";
            LabelBookName.Size = new Size(83, 19);
            LabelBookName.TabIndex = 1;
            LabelBookName.Text = "Book Name";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 200);
            Controls.Add(LabelBookName);
            Controls.Add(LblBookImage);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Card";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Card";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            ((System.ComponentModel.ISupportInitialize)LblBookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LblBookImage;
        private MaterialSkin2DotNet.Controls.MaterialLabel LabelBookName;
    }
}