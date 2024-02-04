using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models;

public partial class CrudContext : DbContext
{
    public CrudContext()
    {
    }

    public CrudContext(DbContextOptions<CrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductList> ProductLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=conn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductList>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__ProductL__C5775520DDDED0B2");

            entity.ToTable("ProductList");

            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(12, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
