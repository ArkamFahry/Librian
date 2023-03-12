using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class Book
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? PublishedDate { get; set; }

    public string? Picture { get; set; }

    public string? Reference { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; } = new List<BookAuthor>();

    public virtual ICollection<BookBorrower> BookBorrowers { get; } = new List<BookBorrower>();

    public virtual ICollection<BookCategory> BookCategories { get; } = new List<BookCategory>();
}
