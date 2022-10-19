﻿// <auto-generated />
using System;
using Berger.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Berger.Infra.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20221019171847_UpdateUserColumns")]
    partial class UpdateUserColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Berger.Domain.Entities.Church", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Church", (string)null);
                });

            modelBuilder.Entity("Berger.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Berger.Domain.Entities.Church", b =>
                {
                    b.OwnsOne("Berger.Domain.ComplexTypes.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("ChurchId")
                                .HasColumnType("uuid");

                            b1.Property<string>("City")
                                .HasColumnType("text");

                            b1.Property<string>("Complement")
                                .HasColumnType("text");

                            b1.Property<string>("Neighborhood")
                                .HasColumnType("text");

                            b1.Property<string>("Number")
                                .HasColumnType("text");

                            b1.Property<string>("State")
                                .HasColumnType("text");

                            b1.Property<string>("Street")
                                .HasColumnType("text");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("text");

                            b1.HasKey("ChurchId");

                            b1.ToTable("Church");

                            b1.WithOwner()
                                .HasForeignKey("ChurchId");
                        });

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
