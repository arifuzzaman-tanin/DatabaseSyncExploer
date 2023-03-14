﻿// <auto-generated />
using DatabaseSync.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseSync.Infrastructure.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230306202334_DB_UP")]
    partial class DB_UP
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatabaseSync.Core.Entities.Mt4User", b =>
                {
                    b.Property<int>("Login")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Login"));

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Mt4Users");
                });
#pragma warning restore 612, 618
        }
    }
}