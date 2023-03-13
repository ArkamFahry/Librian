using System;
using System.Collections.Generic;

namespace librian_desktop.Data.MainDb;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Picture { get; set; }

    public string Role { get; set; } = null!;

    public DateTime? AccessRevoked { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BookBorrower> BookBorrowers { get; } = new List<BookBorrower>();

    public virtual Role RoleNavigation { get; set; } = null!;
}
