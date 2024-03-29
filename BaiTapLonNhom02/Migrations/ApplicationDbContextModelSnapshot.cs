﻿// <auto-generated />
using BaiTapLonNhom02.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiTapLonNhom02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("BaiTapLonNhom02.Models.Cathi", b =>
                {
                    b.Property<string>("MaCathi")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenCathi")
                        .HasColumnType("TEXT");

                    b.HasKey("MaCathi");

                    b.ToTable("Cathis");
                });

            modelBuilder.Entity("BaiTapLonNhom02.Models.DangNhap", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("DangNhaps");
                });

            modelBuilder.Entity("BaiTapLonNhom02.Models.Nhom", b =>
                {
                    b.Property<string>("MaNhom")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhom")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhom");

                    b.ToTable("Nhoms");
                });

            modelBuilder.Entity("BaiTapLonNhom02.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSV")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("MaCathi")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaNhom")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSV")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("MaSV");

                    b.HasIndex("MaCathi");

                    b.HasIndex("MaNhom");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("BaiTapLonNhom02.Models.SinhVien", b =>
                {
                    b.HasOne("BaiTapLonNhom02.Models.Cathi", "Cathi")
                        .WithMany()
                        .HasForeignKey("MaCathi");

                    b.HasOne("BaiTapLonNhom02.Models.Nhom", "Nhom")
                        .WithMany()
                        .HasForeignKey("MaNhom");

                    b.Navigation("Cathi");

                    b.Navigation("Nhom");
                });
#pragma warning restore 612, 618
        }
    }
}
