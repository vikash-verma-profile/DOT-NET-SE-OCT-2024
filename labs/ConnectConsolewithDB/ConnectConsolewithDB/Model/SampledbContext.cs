using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConnectConsolewithDB.Model;

public partial class SampledbContext : DbContext
{
    public SampledbContext()
    {
    }

    public SampledbContext(DbContextOptions<SampledbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auditlog> Auditlogs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Empdeptdatum> Empdeptdata { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Tblemployee> Tblemployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HVUT504;Initial Catalog=SAMPLEDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auditlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUDITLOG");

            entity.Property(e => e.Action)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.Actiondate)
                .HasColumnType("datetime")
                .HasColumnName("ACTIONDATE");
            entity.Property(e => e.Employeeid).HasColumnName("EMPLOYEEID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("PK__CUSTOMER__61DBD7888AD7E497");

            entity.ToTable("CUSTOMERS");

            entity.Property(e => e.Customerid)
                .ValueGeneratedNever()
                .HasColumnName("CUSTOMERID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Departmentname)
                .HasMaxLength(200)
                .HasColumnName("DEPARTMENTNAME");
        });

        modelBuilder.Entity<Empdeptdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMPDEPTDATA");

            entity.Property(e => e.Departmentname)
                .HasMaxLength(200)
                .HasColumnName("DEPARTMENTNAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Orderid).HasName("PK__ORDERS__491E4192AB0B1AD4");

            entity.ToTable("ORDERS");

            entity.Property(e => e.Orderid)
                .ValueGeneratedNever()
                .HasColumnName("ORDERID");
            entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Customerid)
                .HasConstraintName("FK__ORDERS__CUSTOMER__46E78A0C");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Saledid).HasName("PK__SALES__95890C2301BC4104");

            entity.ToTable("SALES");

            entity.Property(e => e.Saledid).HasColumnName("SALEDID");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Product)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Saledate)
                .HasColumnType("datetime")
                .HasColumnName("SALEDATE");
        });

        modelBuilder.Entity<Tblemployee>(entity =>
        {
            entity.ToTable("TBLEMPLOYEE", tb =>
                {
                    tb.HasTrigger("TRGAFTERINSERT");
                    tb.HasTrigger("TRGINSTEEADOFDELETE");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depid).HasColumnName("DEPID");
            entity.Property(e => e.Empid)
                .HasMaxLength(10)
                .HasColumnName("EMPID");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.Managerid).HasColumnName("MANAGERID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("NAME");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SALARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
