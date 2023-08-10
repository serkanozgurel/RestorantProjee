﻿// <auto-generated />
using System;
using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entites.Abstract.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(857));

                    b.Property<string>("KategoriAciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KategoriAdi")
                        .IsUnique();

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateTime = new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(1397),
                            KategoriAciklama = "Yiyecekler",
                            KategoriAdi = "Ana Yemek",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CreateTime = new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(1400),
                            KategoriAciklama = "Çorba v.b.",
                            KategoriAdi = "Ara Sıcaklar",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CreateTime = new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(1401),
                            KategoriAciklama = "Tatlılar",
                            KategoriAdi = "Tatlı",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 4,
                            CreateTime = new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(1402),
                            KategoriAciklama = "Şarap v.b.",
                            KategoriAdi = "Alkollü İçecekelr",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 5,
                            CreateTime = new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(1403),
                            KategoriAciklama = "Kola, su v.b.",
                            KategoriAdi = "Alkolsüz İçecekler",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entites.Abstract.Masa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(4166));

                    b.Property<int>("MasaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MasaID")
                        .IsUnique();

                    b.ToTable("Masalar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MasaID = 1,
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MasaID = 2,
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MasaID = 3,
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entites.Abstract.Siparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(2953));

                    b.Property<int>("MasaID")
                        .HasColumnType("int");

                    b.Property<double>("ToplamFiyat")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MasaID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("Entites.Abstract.Urun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 10, 14, 52, 57, 540, DateTimeKind.Local).AddTicks(5412));

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("FotografLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int?>("SiparisID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrunAciklama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("SiparisID");

                    b.HasIndex("UrunAdi")
                        .IsUnique();

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fiyat = 0.0,
                            KategoriID = 4,
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UrunAciklama = "50",
                            UrunAdi = "Tuborg Gold"
                        });
                });

            modelBuilder.Entity("Entites.Abstract.Siparis", b =>
                {
                    b.HasOne("Entites.Abstract.Masa", "Masa")
                        .WithMany("Siparisler")
                        .HasForeignKey("MasaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Masa");
                });

            modelBuilder.Entity("Entites.Abstract.Urun", b =>
                {
                    b.HasOne("Entites.Abstract.Kategori", "Kategori")
                        .WithMany("Stoklar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Abstract.Siparis", null)
                        .WithMany("Urunler")
                        .HasForeignKey("SiparisID");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Entites.Abstract.Kategori", b =>
                {
                    b.Navigation("Stoklar");
                });

            modelBuilder.Entity("Entites.Abstract.Masa", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Entites.Abstract.Siparis", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
