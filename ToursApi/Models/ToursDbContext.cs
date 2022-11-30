using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToursApi.Models;

public partial class ToursDbContext : DbContext
{
    public ToursDbContext()
    {
    }

    public ToursDbContext(DbContextOptions<ToursDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tour> Tours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH155\\SQLEXPRESS;Initial Catalog=ToursDB;Integrated Security=True;Connect Timeout=300;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.ToursId).HasName("PK__tours__A054D13C375012C4");

            entity.ToTable("tours");

            entity.Property(e => e.ToursId).HasColumnName("ToursID");
            entity.Property(e => e.Countries)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("countries");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Information)
                .IsUnicode(false)
                .HasColumnName("information");
            entity.Property(e => e.Interested)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("interested");
            entity.Property(e => e.Price)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
