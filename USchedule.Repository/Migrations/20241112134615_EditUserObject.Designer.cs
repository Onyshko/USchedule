﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USchedule.Repository.Context;

#nullable disable

namespace USchedule.Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241112134615_EditUserObject")]
    partial class EditUserObject
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EntryTime")
                        .HasColumnType("time");

                    b.Property<string>("EntryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FacultyId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Homework")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("FacultyId1");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb599993-72b9-4b53-bb57-60f142137c28"),
                            Address = "вул. Грушевського, 4, м. Львів 79005, Україна",
                            Name = "Біологічний факультет"
                        },
                        new
                        {
                            Id = new Guid("e8ad3d33-2f15-4c4f-8ce3-d243489a9277"),
                            Address = "вул. Дорошенка, 41, м. Львів, 79000, Україна",
                            Name = "Географічний факультет"
                        },
                        new
                        {
                            Id = new Guid("8ac83cbb-ae28-4c3e-af3c-3690540fc55d"),
                            Address = "вул. Грушевського, 4, м. Львів 79005, Україна",
                            Name = "Геологічний факультет"
                        },
                        new
                        {
                            Id = new Guid("bac595e9-9cf5-4122-be7b-ea1b2de88e8d"),
                            Address = "проспект Свободи, 18, м. Львів, 79008, Україна",
                            Name = "Економічний факультет"
                        },
                        new
                        {
                            Id = new Guid("860e595b-e777-4e46-92b1-66c32b2c9b57"),
                            Address = "вул. Драгоманова, 50, м. Львів, 79005, Україна",
                            Name = "Факультет електроніки та комп’ютерних технологій"
                        },
                        new
                        {
                            Id = new Guid("7f3b8aa3-d9b9-4fa5-a8ab-d4cf467c80f0"),
                            Address = "вул. Генерала Чупринки, 49, м. Львів, 79044, Україна",
                            Name = "Факультет журналістики"
                        },
                        new
                        {
                            Id = new Guid("e62bf165-d39c-4291-8277-cfe62a40c15f"),
                            Address = "вул. Університетська 1/415, м. Львів, 79000, Україна",
                            Name = "Факультет іноземних мов"
                        },
                        new
                        {
                            Id = new Guid("96fb77c4-58ac-4170-8765-9b4f5b634f60"),
                            Address = "вул. Університетська, 1, м. Львів, 79000, Україна",
                            Name = "Історичний факультет"
                        },
                        new
                        {
                            Id = new Guid("e7116453-183f-44ce-8dd9-e5e3117fca09"),
                            Address = "вул. Валова,18, м. Львів, 79008, Україна",
                            Name = "Факультет культури і мистецтв"
                        },
                        new
                        {
                            Id = new Guid("4da387f8-291b-43bb-ba3f-da11336f6555"),
                            Address = "вул. Університетська, 1 м. Львів, 79000, Україна",
                            Name = "Механіко-математичний факультет"
                        },
                        new
                        {
                            Id = new Guid("6bcf2fbb-8f04-4d6f-81d7-2867e9a9c774"),
                            Address = "вул. Січових Стрільців, 19, м. Львів, 79000, Україна",
                            Name = "Факультет міжнародних відносин"
                        },
                        new
                        {
                            Id = new Guid("5331a84b-d7ce-48e3-a630-02eb0551c829"),
                            Address = "вул. Туган-Барановського, 7, м. Львів, 79000, Україна",
                            Name = "Факультет педагогічної освіти"
                        },
                        new
                        {
                            Id = new Guid("c6b26218-9406-4dc6-b084-ef2c3b6b1f08"),
                            Address = "вул. Університетська 1, м. Львів, 79000, Україна",
                            Name = "Факультет прикладної математики та інформатики"
                        },
                        new
                        {
                            Id = new Guid("a4397c08-e509-4d89-903f-db3ff25107f6"),
                            Address = "вул. Коперника, 3, м. Львів, 79000, Україна",
                            Name = "Факультет управління фінансами та бізнесу"
                        },
                        new
                        {
                            Id = new Guid("eff0bdf2-0d03-475c-8556-5440fa4c5773"),
                            Address = "вул. Кирила і Мефодія, 8, м. Львів, 79005, Україна",
                            Name = "Фізичний факультет"
                        },
                        new
                        {
                            Id = new Guid("3acee6c8-1e92-4d1d-a38a-272372d24158"),
                            Address = "вул. Університетська, 1, кімната 232, м. Львів, 79000, Україна",
                            Name = "Філологічний факультет"
                        },
                        new
                        {
                            Id = new Guid("d1db4f95-b3ca-410d-a683-9b3a0342d9de"),
                            Address = "вул. Університетська, 1, м. Львів, 79001, Україна",
                            Name = "Філософський факультет"
                        },
                        new
                        {
                            Id = new Guid("0d04d34f-0364-427e-b7fc-b33ca742c04d"),
                            Address = "вул. Кирила і Мефодія, 6, м. Львів, 79005, Україна",
                            Name = "Хімічний факультет"
                        },
                        new
                        {
                            Id = new Guid("916007a9-9553-4f97-85e7-04bb4a5a2877"),
                            Address = "вул. Січових Стрільців, 14, м. Львів, 79000, Україна",
                            Name = "Юридичний факультет"
                        });
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
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

            modelBuilder.Entity("USchedule.Domain.Entities.StudentGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentGroups");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.TeacherSubjectGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubjectGroups");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Entry", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("USchedule.Domain.Entities.Faculty", null)
                        .WithMany("Entries")
                        .HasForeignKey("FacultyId1");

                    b.HasOne("USchedule.Domain.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.Subject", "Subject")
                        .WithMany("Entries")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.User", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Group");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.StudentGroup", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Group", "Group")
                        .WithMany("StudentGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.User", "Student")
                        .WithMany("StudentGroups")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.TeacherSubjectGroup", b =>
                {
                    b.HasOne("USchedule.Domain.Entities.Group", "Group")
                        .WithMany("TeacherSubjectGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.Subject", "Subject")
                        .WithMany("TeacherSubjectGroups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("USchedule.Domain.Entities.User", "Teacher")
                        .WithMany("TeacherSubjectGroups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Faculty", b =>
                {
                    b.Navigation("Entries");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Group", b =>
                {
                    b.Navigation("StudentGroups");

                    b.Navigation("TeacherSubjectGroups");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.Subject", b =>
                {
                    b.Navigation("Entries");

                    b.Navigation("TeacherSubjectGroups");
                });

            modelBuilder.Entity("USchedule.Domain.Entities.User", b =>
                {
                    b.Navigation("StudentGroups");

                    b.Navigation("TeacherSubjectGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
