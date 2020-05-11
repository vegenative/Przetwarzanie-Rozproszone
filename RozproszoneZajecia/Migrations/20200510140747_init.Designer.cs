﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RozproszoneZajecia.encje;

namespace RozproszoneZajecia.Migrations
{
    [DbContext(typeof(DzieckoContext))]
    [Migration("20200510140747_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RozproszoneZajecia.encje.Dziecko", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("dzieci");
                });

            modelBuilder.Entity("RozproszoneZajecia.encje.Klocek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<int>("zestawId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("zestawId");

                    b.ToTable("klocki");
                });

            modelBuilder.Entity("RozproszoneZajecia.encje.Zestaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cena")
                        .HasColumnType("real");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Wielkość")
                        .HasColumnType("real");

                    b.Property<int>("dzieciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("dzieciId")
                        .IsUnique();

                    b.ToTable("zestawy");
                });

            modelBuilder.Entity("RozproszoneZajecia.encje.Klocek", b =>
                {
                    b.HasOne("RozproszoneZajecia.encje.Zestaw", "zestawy")
                        .WithMany("klocki")
                        .HasForeignKey("zestawId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RozproszoneZajecia.encje.Zestaw", b =>
                {
                    b.HasOne("RozproszoneZajecia.encje.Dziecko", "dzieci")
                        .WithOne("zestawy")
                        .HasForeignKey("RozproszoneZajecia.encje.Zestaw", "dzieciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
