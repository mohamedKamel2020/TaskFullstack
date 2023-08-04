﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NopCommerce1.Models;

public partial class NopCommerce1Context : DbContext
{
    public NopCommerce1Context()
    {
    }

    public NopCommerce1Context(DbContextOptions<NopCommerce1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<InvoiceSell> InvoiceSells { get; set; }

    public virtual DbSet<InvoiceSellUnit> InvoiceSellUnits { get; set; }

    public virtual DbSet<InvoicesSell> InvoicesSells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source =DESKTOP-JDMM5F1\\MSSQLSERVER01;Initial Catalog= NopCommerce1; Integrated Security = SSPI; TrustServerCertificate = True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvoiceSell>(entity =>
        {
            entity.HasKey(e => new { e.BuildingNo, e.InvoiceNo });

            entity.ToTable("InvoiceSell");

            entity.Property(e => e.BuildingNo)
                .HasColumnType("decimal(28, 0)")
                .HasColumnName("buildingNo");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");
            entity.Property(e => e.AName)
                .HasMaxLength(250)
                .HasColumnName("aName");
            entity.Property(e => e.ClientVendorNo)
                .HasColumnType("decimal(21, 0)")
                .HasColumnName("clientVendorNo");
            entity.Property(e => e.DateG)
                .HasColumnType("date")
                .HasColumnName("dateG");
            entity.Property(e => e.DateH)
                .HasMaxLength(20)
                .HasColumnName("dateH");
            entity.Property(e => e.EName)
                .HasMaxLength(250)
                .HasColumnName("eName");
            entity.Property(e => e.InvoiceVatid)
                .HasMaxLength(50)
                .HasColumnName("invoiceVATID");
            entity.Property(e => e.MainContact1)
                .HasMaxLength(50)
                .HasColumnName("mainContact1");
        });

        modelBuilder.Entity<InvoiceSellUnit>(entity =>
        {
            entity.HasKey(e => new { e.BuildingNo, e.InvoiceNo, e.OrderNo });

            entity.ToTable("InvoiceSellUnit");

            entity.Property(e => e.BuildingNo)
                .HasColumnType("decimal(28, 0)")
                .HasColumnName("buildingNo");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");
            entity.Property(e => e.OrderNo).HasColumnName("orderNo");
            entity.Property(e => e.ItemNo)
                .HasColumnType("decimal(28, 0)")
                .HasColumnName("itemNo");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("quantity");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");
            entity.Property(e => e.TotalPlusTax)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("totalPlusTax");
            entity.Property(e => e.UnitNo).HasColumnName("unitNo");
        });

        modelBuilder.Entity<InvoicesSell>(entity =>
        {
            entity.HasKey(e => new { e.BuildingNo, e.InvoiceNo });

            entity.ToTable("InvoicesSell");

            entity.Property(e => e.BuildingNo)
                .HasColumnType("decimal(28, 0)")
                .HasColumnName("buildingNo");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");
            entity.Property(e => e.AName)
                .HasMaxLength(250)
                .HasColumnName("aName");
            entity.Property(e => e.ClientVendorNo)
                .HasColumnType("decimal(21, 0)")
                .HasColumnName("clientVendorNo");
            entity.Property(e => e.DateG)
                .HasColumnType("date")
                .HasColumnName("dateG");
            entity.Property(e => e.DateH)
                .HasMaxLength(20)
                .HasColumnName("dateH");
            entity.Property(e => e.EName)
                .HasMaxLength(250)
                .HasColumnName("eName");
            entity.Property(e => e.InvoiceVatid)
                .HasMaxLength(50)
                .HasColumnName("invoiceVATID");
            entity.Property(e => e.ItemNo)
                .HasColumnType("decimal(28, 0)")
                .HasColumnName("itemNo");
            entity.Property(e => e.MainContact1)
                .HasMaxLength(50)
                .HasColumnName("mainContact1");
            entity.Property(e => e.OrderNo).HasColumnName("orderNo");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("quantity");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");
            entity.Property(e => e.TotalPlusTax)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("totalPlusTax");
            entity.Property(e => e.UnitNo).HasColumnName("unitNo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
