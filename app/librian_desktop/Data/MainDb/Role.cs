using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class Role
{
    public string Id { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
