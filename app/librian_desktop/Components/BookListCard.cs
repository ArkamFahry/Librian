using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librian_desktop.Components
{
    public partial class BookListCard : UserControl
    {
        public BookListCard()
        {
            InitializeComponent();
        }

        private string _bookId;
        private string _bookName;
        private string _bookDescription;
        private Image _bookCoverImage;

        public string BookId
        {
            get => _bookId;
            set => _bookId = value;
        }

        [Category("Custom Props")]
        public string BookName
        {
            get => _bookName;
            set
            {
                _bookName = value;
                LabelBookName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string BookDescription
        {
            get => _bookDescription;
            set => _bookDescription = value;
        }

        [Category("Custom Props")]
        public Image BookCoverImage
        {
            get => _bookCoverImage;
            set
            {
                _bookCoverImage = value;
                PictureBookImage.Image = value;
            }
        }
    }
}
