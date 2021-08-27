﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PS13035_LEQUANGDUC_ASM1.Models;

namespace PS13035_LEQUANGDUC_ASM1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.Donhang", b =>
                {
                    b.Property<int>("DonhangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ghichu")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("KhachhangID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaydat")
                        .HasColumnType("datetime2");

                    b.Property<double>("Tongtien")
                        .HasColumnType("float");

                    b.Property<int>("trangThaiDonHang")
                        .HasColumnType("int");

                    b.HasKey("DonhangID");

                    b.HasIndex("KhachhangID");

                    b.ToTable("Donhangs");
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.DonhangChitiet", b =>
                {
                    b.Property<int>("ChitietID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonhangID")
                        .HasColumnType("int");

                    b.Property<string>("Ghichu")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("MonAnID")
                        .HasColumnType("int");

                    b.Property<double>("Soluong")
                        .HasColumnType("float");

                    b.Property<double>("Thanhtien")
                        .HasColumnType("float");

                    b.HasKey("ChitietID");

                    b.HasIndex("DonhangID");

                    b.HasIndex("MonAnID");

                    b.ToTable("DonhangChitiets");
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.Khachhang", b =>
                {
                    b.Property<int>("KhachhangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("KhachhangID");

                    b.ToTable("Khachhangs");
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.MonAn", b =>
                {
                    b.Property<int>("MonanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Phanloai")
                        .HasColumnType("int");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("MonanID");

                    b.ToTable("MonAns");
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.Nguoidung", b =>
                {
                    b.Property<int>("NguoidungID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NguoidungID");

                    b.ToTable("Nguoidungs");
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.Donhang", b =>
                {
                    b.HasOne("PS13035_LEQUANGDUC_ASM1.Models.Khachhang", "khachhang")
                        .WithMany()
                        .HasForeignKey("KhachhangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PS13035_LEQUANGDUC_ASM1.Models.DonhangChitiet", b =>
                {
                    b.HasOne("PS13035_LEQUANGDUC_ASM1.Models.Donhang", "Donhang")
                        .WithMany("DonhangChitiets")
                        .HasForeignKey("DonhangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PS13035_LEQUANGDUC_ASM1.Models.MonAn", "MonAn")
                        .WithMany()
                        .HasForeignKey("MonAnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
