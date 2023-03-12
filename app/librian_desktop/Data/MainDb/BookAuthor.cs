using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class BookAuthor
{
    public string Id { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public string AuthorId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
