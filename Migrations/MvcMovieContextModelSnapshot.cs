﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TranVanTuyen760.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TranVanTuyen760.Models.UniversityTVT760", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("UniversityName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityTVT760");
                });
#pragma warning restore 612, 618
        }
    }
}