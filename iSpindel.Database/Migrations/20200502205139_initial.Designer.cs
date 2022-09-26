﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iSpindel.Database;

namespace iSpindel.Database.Migrations
{
    [DbContext(typeof(iSpindelContext))]
    [Migration("20200502205139_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("iSpindel.Database.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Battery")
                        .HasColumnType("double precision");

                    b.Property<int?>("DataSeriesId")
                        .HasColumnType("integer");

                    b.Property<double>("Gravity")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("RecordTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Temperature")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("DataSeriesId");

                    b.ToTable("DataPoints");
                });

            modelBuilder.Entity("iSpindel.Database.DataSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("DataSeries");
                });

            modelBuilder.Entity("iSpindel.Database.DataPoint", b =>
                {
                    b.HasOne("iSpindel.Database.DataSeries", "DataSeries")
                        .WithMany("DataPoints")
                        .HasForeignKey("DataSeriesId");
                });
#pragma warning restore 612, 618
        }
    }
}