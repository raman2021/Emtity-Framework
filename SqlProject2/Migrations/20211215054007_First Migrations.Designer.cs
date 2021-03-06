// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlProject2.Datacontext;

namespace SqlProject2.Migrations
{
    [DbContext(typeof(EFDatacontext))]
    [Migration("20211215054007_First Migrations")]
    partial class FirstMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SqlProject2.Model.ProductModel", b =>
                {
                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductName");

                    b.ToTable("productModels");
                });

            modelBuilder.Entity("SqlProject2.Model.SaleItemModel", b =>
                {
                    b.Property<string>("ProductSaleName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductSaleName");

                    b.ToTable("saleItemModels");
                });
#pragma warning restore 612, 618
        }
    }
}
