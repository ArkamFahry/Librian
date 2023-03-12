using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.SearchDb.Models
{
    public class BookIndex : BaseIndex
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
