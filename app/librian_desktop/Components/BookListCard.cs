using System.ComponentModel;

namespace librian_desktop.Components
{
    public partial class BookListCard : UserControl
    {
        private string _bookId;
        private string _bookName;
        private string _bookDescription;
        private Image _bookCoverImage;

        public BookListCard()
        {
            InitializeComponent();
        }

        private void BookListCard_Load(object sender, EventArgs e)
        {

        }

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
