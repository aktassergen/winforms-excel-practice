﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SA.AUTApp.DAL.Context;

#nullable disable

namespace SA.AUTApp.DAL.Migrations
{
    [DbContext(typeof(SA_AUTAppDbContext))]
    [Migration("20240325131814_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.KullaniciUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("UrunId");

                    b.ToTable("KullaniciUruns");
                });

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Ay")
                        .HasColumnType("int");

                    b.Property<int>("Tonaj")
                        .HasColumnType("int");

                    b.Property<string>("UrunName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.KullaniciUrun", b =>
                {
                    b.HasOne("SA.AUTApp.Entity.Concrete.Kullanici", "Kullanici")
                        .WithMany("kullaniciUruns")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SA.AUTApp.Entity.Concrete.Urun", "Urun")
                        .WithMany("kullaniciUruns")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.Kullanici", b =>
                {
                    b.Navigation("kullaniciUruns");
                });

            modelBuilder.Entity("SA.AUTApp.Entity.Concrete.Urun", b =>
                {
                    b.Navigation("kullaniciUruns");
                });
#pragma warning restore 612, 618
        }
    }
}
