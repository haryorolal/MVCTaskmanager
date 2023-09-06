﻿// <auto-generated />
using System;
using MVCTaskmanager.identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCTaskmanager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230316085155_Task")]
    partial class Task
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCTaskmanager.Models.ClientLocation", b =>
                {
                    b.Property<int>("ClientLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientLocationID"));

                    b.Property<string>("ClientLocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientLocationID");

                    b.ToTable("ClientLocations");

                    b.HasData(
                        new
                        {
                            ClientLocationID = 1,
                            ClientLocationName = "Boston"
                        },
                        new
                        {
                            ClientLocationID = 2,
                            ClientLocationName = "New Delhi"
                        },
                        new
                        {
                            ClientLocationID = 3,
                            ClientLocationName = "New Jersy"
                        },
                        new
                        {
                            ClientLocationID = 4,
                            ClientLocationName = "New York"
                        },
                        new
                        {
                            ClientLocationID = 5,
                            ClientLocationName = "London"
                        },
                        new
                        {
                            ClientLocationID = 6,
                            ClientLocationName = "Tokyo"
                        });
                });

            modelBuilder.Entity("MVCTaskmanager.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("ClientLocationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamSize")
                        .HasColumnType("int");

                    b.HasKey("ProjectID");

                    b.HasIndex("ClientLocationID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            Active = true,
                            ClientLocationID = 2,
                            DateOfStart = new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Hospital Management System",
                            Status = "In Force",
                            TeamSize = 14
                        },
                        new
                        {
                            ProjectID = 2,
                            Active = true,
                            ClientLocationID = 2,
                            DateOfStart = new DateTime(2018, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Reporting Tool",
                            Status = "Support",
                            TeamSize = 81
                        });
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TaskPriority", b =>
                {
                    b.Property<int>("TaskPriorityID")
                        .HasColumnType("int");

                    b.Property<string>("TaskPriorityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskPriorityID");

                    b.ToTable("TaskPriorities");

                    b.HasData(
                        new
                        {
                            TaskPriorityID = 1,
                            TaskPriorityName = "Urgent"
                        },
                        new
                        {
                            TaskPriorityID = 2,
                            TaskPriorityName = "Normal"
                        },
                        new
                        {
                            TaskPriorityID = 3,
                            TaskPriorityName = "Below Normal"
                        },
                        new
                        {
                            TaskPriorityID = 4,
                            TaskPriorityName = "Low"
                        });
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TaskStat", b =>
                {
                    b.Property<int>("TaskStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskStatusID"));

                    b.Property<string>("TaskStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskStatusID");

                    b.ToTable("TaskStatuses");

                    b.HasData(
                        new
                        {
                            TaskStatusID = 1,
                            TaskStatusName = "Holding"
                        },
                        new
                        {
                            TaskStatusID = 2,
                            TaskStatusName = "Prioritised"
                        },
                        new
                        {
                            TaskStatusID = 3,
                            TaskStatusName = "Started"
                        },
                        new
                        {
                            TaskStatusID = 4,
                            TaskStatusName = "Finished"
                        },
                        new
                        {
                            TaskStatusID = 5,
                            TaskStatusName = "Reverted"
                        });
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TaskStatusDetail", b =>
                {
                    b.Property<int>("TaskStatusDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskStatusDetailID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StatusUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskID")
                        .HasColumnType("int");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.Property<int>("TaskStatusID")
                        .HasColumnType("int");

                    b.Property<int?>("TheTaskTaskID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TaskStatusDetailID");

                    b.HasIndex("TheTaskTaskID");

                    b.HasIndex("UserID");

                    b.ToTable("TaskStatusDetails");
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TheTask", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskID"));

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProjectID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TaskCreatedBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TaskCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskCurrentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskCurrentStatusID")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskPriorityID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("TaskID");

                    b.HasIndex("AssignedTo");

                    b.HasIndex("ProjectID");

                    b.HasIndex("TaskCreatedBy");

                    b.HasIndex("TaskPriorityID");

                    b.ToTable("TheTasks");
                });

            modelBuilder.Entity("MVCTaskmanager.Models.country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = 1,
                            CountryName = "China"
                        },
                        new
                        {
                            CountryID = 2,
                            CountryName = "United States"
                        },
                        new
                        {
                            CountryID = 3,
                            CountryName = "Brazil"
                        },
                        new
                        {
                            CountryID = 4,
                            CountryName = "Nigeria"
                        },
                        new
                        {
                            CountryID = 5,
                            CountryName = "Pakistan"
                        },
                        new
                        {
                            CountryID = 6,
                            CountryName = "Bangladash"
                        },
                        new
                        {
                            CountryID = 7,
                            CountryName = "Russia"
                        },
                        new
                        {
                            CountryID = 8,
                            CountryName = "Croatia"
                        },
                        new
                        {
                            CountryID = 9,
                            CountryName = "Mexico"
                        },
                        new
                        {
                            CountryID = 10,
                            CountryName = "France"
                        });
                });

            modelBuilder.Entity("MVCTaskmanager.Models.skills", b =>
                {
                    b.Property<int>("skillsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("skillsID"));

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("skillsLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skillsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillsID");

                    b.HasIndex("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MVCTaskmanager.identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("ReceiveNewsLetters")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVCTaskmanager.Models.Project", b =>
                {
                    b.HasOne("MVCTaskmanager.Models.ClientLocation", "ClientLocation")
                        .WithMany()
                        .HasForeignKey("ClientLocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientLocation");
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TaskStatusDetail", b =>
                {
                    b.HasOne("MVCTaskmanager.Models.TheTask", null)
                        .WithMany("TaskStatusDetails")
                        .HasForeignKey("TheTaskTaskID");

                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TheTask", b =>
                {
                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", "AssignedToUser")
                        .WithMany()
                        .HasForeignKey("AssignedTo");

                    b.HasOne("MVCTaskmanager.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", "TaskCreatedByUser")
                        .WithMany()
                        .HasForeignKey("TaskCreatedBy");

                    b.HasOne("MVCTaskmanager.Models.TaskPriority", "TaskPriority")
                        .WithMany()
                        .HasForeignKey("TaskPriorityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedToUser");

                    b.Navigation("Project");

                    b.Navigation("TaskCreatedByUser");

                    b.Navigation("TaskPriority");
                });

            modelBuilder.Entity("MVCTaskmanager.Models.skills", b =>
                {
                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVCTaskmanager.identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCTaskmanager.Models.TheTask", b =>
                {
                    b.Navigation("TaskStatusDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
