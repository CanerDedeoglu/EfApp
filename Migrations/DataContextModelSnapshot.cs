﻿// <auto-generated />
using System;
using EfApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("EfApp.Data.Bootcamp", b =>
                {
                    b.Property<int>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.HasKey("KursId");

                    b.ToTable("Bootcamps");
                });

            modelBuilder.Entity("EfApp.Data.BootcampKayit", b =>
                {
                    b.Property<int>("KayıtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BootcampKursId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayıtId");

                    b.HasIndex("BootcampKursId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("Kayitlar");
                });

            modelBuilder.Entity("EfApp.Data.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("EfApp.Data.BootcampKayit", b =>
                {
                    b.HasOne("EfApp.Data.Bootcamp", "Bootcamp")
                        .WithMany()
                        .HasForeignKey("BootcampKursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfApp.Data.Ogrenci", "Ogrenci")
                        .WithMany()
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bootcamp");

                    b.Navigation("Ogrenci");
                });
#pragma warning restore 612, 618
        }
    }
}
