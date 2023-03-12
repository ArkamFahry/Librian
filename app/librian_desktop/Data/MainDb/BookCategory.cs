using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class BookCategory
{
    public string Id { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
