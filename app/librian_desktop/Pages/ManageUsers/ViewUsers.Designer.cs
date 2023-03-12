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
            UserSearchBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            FlowPanelUserView = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // UserSearchBox
            // 
            UserSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserSearchBox.AnimateReadOnly = false;
            UserSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            UserSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            UserSearchBox.BackgroundImageLayout = ImageLayout.None;
            UserSearchBox.CharacterCasing = CharacterCasing.Normal;
            UserSearchBox.Depth = 0;
            UserSearchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserSearchBox.HideSelection = true;
            UserSearchBox.LeadingIcon = null;
            UserSearchBox.Location = new Point(19, 22);
            UserSearchBox.MaxLength = 32767;
            UserSearchBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            UserSearchBox.Name = "UserSearchBox";
            UserSearchBox.PasswordChar = '\0';
            UserSearchBox.PrefixSuffixText = null;
            UserSearchBox.ReadOnly = false;
            UserSearchBox.RightToLeft = RightToLeft.No;
            UserSearchBox.SelectedText = "";
            UserSearchBox.SelectionLength = 0;
            UserSearchBox.SelectionStart = 0;
            UserSearchBox.ShortcutsEnabled = true;
            UserSearchBox.Size = new Size(1020, 48);
            UserSearchBox.TabIndex = 1;
            UserSearchBox.TabStop = false;
            UserSearchBox.TextAlign = HorizontalAlignment.Left;
            UserSearchBox.TrailingIcon = null;
            UserSearchBox.UseSystemPasswordChar = false;
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
            // button1
            // 
            button1.Location = new Point(955, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(button1);
            Controls.Add(FlowPanelUserView);
            Controls.Add(UserSearchBox);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ViewUsers";
            Padding = new Padding(3, 0, 3, 3);
            Sizable = false;
            Text = "ViewUsers";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTextBox2 UserSearchBox;
        private FlowLayoutPanel FlowPanelUserView;
        private Button button1;
    }
}