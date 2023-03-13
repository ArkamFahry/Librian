using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace librian_desktop.Data.MainDb;

public partial class LibrianContext : DbContext
{
    public LibrianContext()
    {
    }

    public LibrianContext(DbContextOptions<LibrianContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookAuthor> BookAuthors { get; set; }

    public virtual DbSet<BookBorrower> BookBorrowers { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=Librian;persist security info=True;User Id=SA;Password=Arkam2004;Trusted_Connection=False;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC07950BE13B");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07F24383DB");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Picture).IsUnicode(false);
            entity.Property(e => e.Reference).IsUnicode(false);
        });

        modelBuilder.Entity<BookAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookAuth__3214EC07A3C8F87E");

            entity.HasIndex(e => new { e.BookId, e.AuthorId }, "UQ__BookAuth__6AED6DC58FEDF99E").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.AuthorId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BookId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Author).WithMany(p => p.BookAuthors)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookAutho__Autho__571DF1D5");

            entity.HasOne(d => d.Book).WithMany(p => p.BookAuthors)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookAutho__BookI__5629CD9C");
        });

        modelBuilder.Entity<BookBorrower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookBorr__3214EC07F5566D21");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.BookId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Book).WithMany(p => p.BookBorrowers)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookBorro__BookI__5CD6CB2B");

            entity.HasOne(d => d.User).WithMany(p => p.BookBorrowers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookBorro__UserI__5BE2A6F2");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookCate__3214EC07A79FC025");

            entity.HasIndex(e => new { e.BookId, e.CategoryId }, "UQ__BookCate__9C7051A63472DD78").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.BookId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Book).WithMany(p => p.BookCategories)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookCateg__BookI__4BAC3F29");

            entity.HasOne(d => d.Category).WithMany(p => p.BookCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookCateg__Categ__4CA06362");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC071D73CDE6");

            entity.HasIndex(e => e.Name, "UQ__Categori__737584F6D49BA436").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC0772C7797B");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07E3FD27CA");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105347D04D07A").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Picture).IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('user')");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__Role__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
