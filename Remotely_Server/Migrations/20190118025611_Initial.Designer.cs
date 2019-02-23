﻿// <auto-generated />
using System;
using Remotely_Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Remotely_Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190118025611_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.CommandContext", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandMode");

                    b.Property<string>("CommandResults");

                    b.Property<string>("CommandText");

                    b.Property<string>("OrganizationID");

                    b.Property<string>("PSCoreResults");

                    b.Property<string>("SenderConnectionID");

                    b.Property<string>("SenderUserID");

                    b.Property<string>("TargetMachineIDs");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("CommandContexts");
                });

            modelBuilder.Entity("Library.Models.RemotelyUserOptions", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandModeShortcutBash")
                        .HasMaxLength(10);

                    b.Property<string>("CommandModeShortcutCMD")
                        .HasMaxLength(10);

                    b.Property<string>("CommandModeShortcutRemotely")
                        .HasMaxLength(10);

                    b.Property<string>("CommandModeShortcutPSCore")
                        .HasMaxLength(10);

                    b.Property<string>("CommandModeShortcutWinPS")
                        .HasMaxLength(10);

                    b.Property<string>("ConsolePrompt")
                        .HasMaxLength(5);

                    b.HasKey("ID");

                    b.ToTable("RemotelyUserOptions");
                });

            modelBuilder.Entity("Library.Models.Drive", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DriveFormat");

                    b.Property<int>("DriveType");

                    b.Property<double>("FreeSpace");

                    b.Property<string>("MachineID");

                    b.Property<string>("Name");

                    b.Property<string>("RootDirectory");

                    b.Property<double>("TotalSize");

                    b.Property<string>("VolumeLabel");

                    b.HasKey("ID");

                    b.HasIndex("MachineID");

                    b.ToTable("Drives");
                });

            modelBuilder.Entity("Library.Models.EventLog", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventType");

                    b.Property<string>("Message");

                    b.Property<string>("OrganizationID");

                    b.Property<string>("Source");

                    b.Property<string>("StackTrace");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("Library.Models.InviteLink", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSent");

                    b.Property<string>("InvitedUser");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("OrganizationID");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("InviteLinks");
                });

            modelBuilder.Entity("Library.Models.Machine", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentUser");

                    b.Property<double>("FreeMemory");

                    b.Property<double>("FreeStorage");

                    b.Property<bool>("Is64Bit");

                    b.Property<bool>("IsOnline");

                    b.Property<DateTime>("LastOnline");

                    b.Property<string>("MachineName");

                    b.Property<int>("OSArchitecture");

                    b.Property<string>("OSDescription");

                    b.Property<string>("OrganizationID");

                    b.Property<string>("Platform");

                    b.Property<int>("ProcessorCount");

                    b.Property<string>("ServerVerificationToken");

                    b.Property<string>("Tags")
                        .HasMaxLength(200);

                    b.Property<double>("TotalMemory");

                    b.Property<double>("TotalStorage");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Library.Models.Organization", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OrganizationName")
                        .HasMaxLength(25);

                    b.HasKey("ID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Library.Models.PermissionGroup", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MachineID");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("OrganizationID");

                    b.HasKey("ID");

                    b.HasIndex("MachineID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("PermissionGroups");
                });

            modelBuilder.Entity("Library.Models.SharedFile", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType");

                    b.Property<byte[]>("FileContents");

                    b.Property<string>("FileName");

                    b.Property<string>("OrganizationID");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("SharedFiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("RemotelyUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Library.Models.RemotelyUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("IsAdministrator");

                    b.Property<string>("OrganizationID");

                    b.Property<string>("PermissionGroups");

                    b.Property<string>("UserOptions");

                    b.HasIndex("OrganizationID");

                    b.ToTable("RemotelyUsers");

                    b.HasDiscriminator().HasValue("RemotelyUser");
                });

            modelBuilder.Entity("Library.Models.CommandContext", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("CommandContexts")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Library.Models.Drive", b =>
                {
                    b.HasOne("Library.Models.Machine")
                        .WithMany("Drives")
                        .HasForeignKey("MachineID");
                });

            modelBuilder.Entity("Library.Models.EventLog", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("EventLogs")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Library.Models.InviteLink", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("InviteLinks")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Library.Models.Machine", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("Machines")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Library.Models.PermissionGroup", b =>
                {
                    b.HasOne("Library.Models.Machine")
                        .WithMany("PermissionGroups")
                        .HasForeignKey("MachineID");

                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("PermissionGroups")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Library.Models.SharedFile", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("SharedFiles")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.RemotelyUser", b =>
                {
                    b.HasOne("Library.Models.Organization", "Organization")
                        .WithMany("RemotelyUsers")
                        .HasForeignKey("OrganizationID");
                });
#pragma warning restore 612, 618
        }
    }
}
