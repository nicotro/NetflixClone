﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetflixCloneAPI.Services;

#nullable disable

namespace NetflixCloneAPI.Migrations
{
    [DbContext(typeof(DataContextService))]
    [Migration("20220828152553_OneCategoryPerResource")]
    partial class OneCategoryPerResource
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NetflixCloneAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("answer");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("question");

                    b.HasKey("Id");

                    b.ToTable("faq");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("genre");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Genre_resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .HasColumnType("int")
                        .HasColumnName("resource_id");

                    b.Property<int>("GenreId")
                        .HasColumnType("int")
                        .HasColumnName("genre_id");

                    b.HasKey("ResourceId");

                    b.HasIndex("GenreId");

                    b.ToTable("genre_resource");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ResourceId")
                        .HasColumnType("int")
                        .HasColumnName("resource_id");

                    b.Property<int>("SizeType")
                        .HasColumnType("int")
                        .HasColumnName("size_type");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("uri");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("image");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int")
                        .HasColumnName("Category");

                    b.Property<string>("Infos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("infos");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("season");

                    b.HasKey("Id");

                    b.ToTable("resource");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("function");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Banned")
                        .HasColumnType("bit")
                        .HasColumnName("banned_user");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("phone");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Video", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int")
                        .HasColumnName("resource_id");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("text");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("uri");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("video");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Genre_resource", b =>
                {
                    b.HasOne("NetflixCloneAPI.Models.Genre", "genre")
                        .WithMany("Genre_Resources")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetflixCloneAPI.Models.Resource", "resource")
                        .WithMany("Genre_Resources")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genre");

                    b.Navigation("resource");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Image", b =>
                {
                    b.HasOne("NetflixCloneAPI.Models.Resource", "resource")
                        .WithMany("Images")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resource");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.User", b =>
                {
                    b.HasOne("NetflixCloneAPI.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Video", b =>
                {
                    b.HasOne("NetflixCloneAPI.Models.Resource", "resource")
                        .WithMany("Videos")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("resource");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Genre", b =>
                {
                    b.Navigation("Genre_Resources");
                });

            modelBuilder.Entity("NetflixCloneAPI.Models.Resource", b =>
                {
                    b.Navigation("Genre_Resources");

                    b.Navigation("Images");

                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
