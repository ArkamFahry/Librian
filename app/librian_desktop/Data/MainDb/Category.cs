using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class Category
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BookCategory> BookCategories { get; } = new List<BookCategory>();
}
