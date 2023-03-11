namespace librian_desktop
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            AuthDisplayPanel = new Panel();
            SwitchAuthDisplayPanel = new Panel();
            BtnChangeAuthPage = new MaterialSkin2DotNet.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SwitchAuthDisplayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.librian_logo;
            pictureBox1.Location = new Point(344, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AuthDisplayPanel
            // 
            AuthDisplayPanel.BackColor = Color.Transparent;
            AuthDisplayPanel.Location = new Point(0, 67);
            AuthDisplayPanel.Name = "AuthDisplayPanel";
            AuthDisplayPanel.Size = new Size(400, 427);
            AuthDisplayPanel.TabIndex = 1;
            // 
            // SwitchAuthDisplayPanel
            // 
            SwitchAuthDisplayPanel.BackColor = Color.Transparent;
            SwitchAuthDisplayPanel.Controls.Add(BtnChangeAuthPage);
            SwitchAuthDisplayPanel.Location = new Point(1, 494);
            SwitchAuthDisplayPanel.Name = "SwitchAuthDisplayPanel";
            SwitchAuthDisplayPanel.Size = new Size(400, 54);
            SwitchAuthDisplayPanel.TabIndex = 0;
            // 
            // BtnChangeAuthPage
            // 
            BtnChangeAuthPage.AutoSize = false;
            BtnChangeAuthPage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnChangeAuthPage.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnChangeAuthPage.Depth = 0;
            BtnChangeAuthPage.FlatStyle = FlatStyle.Flat;
            BtnChangeAuthPage.HighEmphasis = true;
            BtnChangeAuthPage.Icon = null;
            BtnChangeAuthPage.Location = new Point(127, 9);
            BtnChangeAuthPage.Margin = new Padding(4, 6, 4, 6);
            BtnChangeAuthPage.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnChangeAuthPage.Name = "BtnChangeAuthPage";
            BtnChangeAuthPage.NoAccentTextColor = Color.Empty;
            BtnChangeAuthPage.RightToLeft = RightToLeft.Yes;
            BtnChangeAuthPage.Size = new Size(140, 35);
            BtnChangeAuthPage.TabIndex = 0;
            BtnChangeAuthPage.Text = "Go To SignUp";
            BtnChangeAuthPage.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnChangeAuthPage.UseAccentColor = false;
            BtnChangeAuthPage.UseVisualStyleBackColor = true;
            BtnChangeAuthPage.Click += BtnChangeAuthPage_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 550);
            Controls.Add(SwitchAuthDisplayPanel);
            Controls.Add(AuthDisplayPanel);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            PrimaryColor = MaterialSkin2DotNet.Primary.BlueGrey900;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.DARK;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SwitchAuthDisplayPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel AuthDisplayPanel;
        private Panel SwitchAuthDisplayPanel;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnChangeAuthPage;
    }
}