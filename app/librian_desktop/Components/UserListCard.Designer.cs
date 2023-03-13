namespace librian_desktop.Components
{
    partial class UserListCard
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
            ProfilePicture = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LblUpdatedAt = new Label();
            LblCreatedAt = new Label();
            LblEmail = new Label();
            LblName = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicture
            // 
            ProfilePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProfilePicture.BackColor = Color.Transparent;
            ProfilePicture.Location = new Point(3, 1);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(204, 147);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 5;
            ProfilePicture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 45);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 78);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Created At :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 111);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 9;
            label4.Text = "Updated At :";
            // 
            // LblUpdatedAt
            // 
            LblUpdatedAt.AutoSize = true;
            LblUpdatedAt.Location = new Point(321, 111);
            LblUpdatedAt.Name = "LblUpdatedAt";
            LblUpdatedAt.Size = new Size(67, 15);
            LblUpdatedAt.TabIndex = 13;
            LblUpdatedAt.Text = "Updated At";
            // 
            // LblCreatedAt
            // 
            LblCreatedAt.AutoSize = true;
            LblCreatedAt.Location = new Point(321, 78);
            LblCreatedAt.Name = "LblCreatedAt";
            LblCreatedAt.Size = new Size(63, 15);
            LblCreatedAt.TabIndex = 12;
            LblCreatedAt.Text = "Created At";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(321, 45);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 11;
            LblEmail.Text = "Email";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(321, 14);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 10;
            LblName.Text = "Name";
            // 
            // UserListCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 42, 48);
            Controls.Add(LblUpdatedAt);
            Controls.Add(LblCreatedAt);
            Controls.Add(LblEmail);
            Controls.Add(LblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProfilePicture);
            Name = "UserListCard";
            Size = new Size(995, 150);
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ProfilePicture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblUpdatedAt;
        private Label LblCreatedAt;
        private Label LblEmail;
        private Label LblName;
    }
}
