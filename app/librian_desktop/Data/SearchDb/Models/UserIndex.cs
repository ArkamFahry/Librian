using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.SearchDb.Models
{
    public class UserIndex : BaseIndex
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public string? AccessRevoked { get; set; }
    }
}
