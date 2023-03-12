using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class BookBorrower
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public DateTime DueDate { get; set; }

    public DateTime? ReturnedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
