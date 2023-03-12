using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class Author
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; } = new List<BookAuthor>();
}
