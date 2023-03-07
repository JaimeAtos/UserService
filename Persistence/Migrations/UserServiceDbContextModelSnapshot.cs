﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(UserServiceDbContext))]
    partial class UserServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdUserCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserCreatorId")
                        .HasMaxLength(256)
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Email", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<Guid>("IdUserCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserCreatorId")
                        .HasMaxLength(256)
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Permission", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RolePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUserCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserCreatorId")
                        .HasMaxLength(256)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("RolePermission", (string)null);
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUserCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(120)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserCreatorId")
                        .HasMaxLength(256)
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Core.Entities.UserPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdUserCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserCreatorId")
                        .HasMaxLength(256)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Email", b =>
                {
                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.RolePermission", b =>
                {
                    b.HasOne("Core.Entities.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("RolePermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.UserPermission", b =>
                {
                    b.HasOne("Core.Entities.Permission", "Permission")
                        .WithMany("UserPermission")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Permission", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserPermission");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("RolePermissions");

                    b.Navigation("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
