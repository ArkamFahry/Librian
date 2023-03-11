using System.ComponentModel;

namespace librian_desktop.Components.SideBar
{
    public class DropDown : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;

        public DropDown(IContainer container) : base(container)
        {

        }

        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        private void LoadItemAppearence()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }

            foreach (ToolStripMenuItem menuItem1 in this.Items)
            {
                menuItem1.ForeColor = menuItemTextColor;
                menuItem1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItem1.Image == null) menuItem1.Image = menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItem2 in menuItem1.DropDownItems)
                {
                    menuItem2.ForeColor = menuItemTextColor;
                    menuItem2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItem2.Image == null) menuItem2.Image = menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItem3 in menuItem2.DropDownItems)
                    {
                        menuItem3.ForeColor = menuItemTextColor;
                        menuItem3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItem3.Image == null) menuItem3.Image = menuItemHeaderSize;
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
