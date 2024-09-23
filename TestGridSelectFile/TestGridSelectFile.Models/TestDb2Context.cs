using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestGridSelectFile.TestGridSelectFile.Models;

public partial class TestDb2Context : DbContext
{
    public TestDb2Context()
    {
    }

    public TestDb2Context(DbContextOptions<TestDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUser1> TblUsers1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-251TL74;Database=TestDB2;Integrated Security=True;Trusted_Connection=True;Trust Server Certificate=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tblUser");

            entity.HasIndex(e => e.Salary, "IX_tblUser_Salary");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUser1>(entity =>
        {
            entity.ToTable("tblUsers");

            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FullName)
                .HasMaxLength(200)
                .HasColumnName("Full_Name");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("Last_Login");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
