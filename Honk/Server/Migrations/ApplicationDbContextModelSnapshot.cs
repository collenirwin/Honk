﻿// <auto-generated />
using System;
using Honk.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Honk.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:CollationDefinition:case_insensitive_collation", "@colStrength=primary,@colStrength=primary,icu,False")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AlbumApplicationUser", b =>
                {
                    b.Property<Guid>("DeletableAlbumsId")
                        .HasColumnType("uuid");

                    b.Property<string>("DeletionUsersId")
                        .HasColumnType("text");

                    b.HasKey("DeletableAlbumsId", "DeletionUsersId");

                    b.HasIndex("DeletionUsersId");

                    b.ToTable("AlbumApplicationUser");
                });

            modelBuilder.Entity("AlbumApplicationUser1", b =>
                {
                    b.Property<Guid>("ModifiableAlbumsId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModificationUsersId")
                        .HasColumnType("text");

                    b.HasKey("ModifiableAlbumsId", "ModificationUsersId");

                    b.HasIndex("ModificationUsersId");

                    b.ToTable("AlbumApplicationUser1");
                });

            modelBuilder.Entity("AlbumApplicationUser2", b =>
                {
                    b.Property<string>("ViewUsersId")
                        .HasColumnType("text");

                    b.Property<Guid>("ViewableAlbumsId")
                        .HasColumnType("uuid");

                    b.HasKey("ViewUsersId", "ViewableAlbumsId");

                    b.HasIndex("ViewableAlbumsId");

                    b.ToTable("AlbumApplicationUser2");
                });

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.Property<Guid>("AlbumsId")
                        .HasColumnType("uuid");

                    b.Property<string>("TagsTagText")
                        .HasColumnType("text");

                    b.HasKey("AlbumsId", "TagsTagText");

                    b.HasIndex("TagsTagText");

                    b.ToTable("AlbumTag");
                });

            modelBuilder.Entity("ApplicationUserPhoto", b =>
                {
                    b.Property<Guid>("DeletablePhotosId")
                        .HasColumnType("uuid");

                    b.Property<string>("DeletionUsersId")
                        .HasColumnType("text");

                    b.HasKey("DeletablePhotosId", "DeletionUsersId");

                    b.HasIndex("DeletionUsersId");

                    b.ToTable("ApplicationUserPhoto");
                });

            modelBuilder.Entity("ApplicationUserPhoto1", b =>
                {
                    b.Property<Guid>("ModifiablePhotosId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModificationUsersId")
                        .HasColumnType("text");

                    b.HasKey("ModifiablePhotosId", "ModificationUsersId");

                    b.HasIndex("ModificationUsersId");

                    b.ToTable("ApplicationUserPhoto1");
                });

            modelBuilder.Entity("ApplicationUserPhoto2", b =>
                {
                    b.Property<string>("ViewUsersId")
                        .HasColumnType("text");

                    b.Property<Guid>("ViewablePhotosId")
                        .HasColumnType("uuid");

                    b.HasKey("ViewUsersId", "ViewablePhotosId");

                    b.HasIndex("ViewablePhotosId");

                    b.ToTable("ApplicationUserPhoto2");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeletionPrivacy")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ModificationPrivacy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ViewPrivacy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("Name", "CreatedByUserId")
                        .IsUnique();

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.AlbumComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("AlbumComments");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.AlbumCommentNotification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ForUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Read")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("ForUserId");

                    b.ToTable("AlbumCommentNotifications");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("ProfilePhotoPath")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Block", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BlockedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BlockedUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BlockedByUserId");

                    b.HasIndex("BlockedUserId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.FriendRequestNotification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ForUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Read")
                        .HasColumnType("boolean");

                    b.Property<string>("RequestorUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ForUserId");

                    b.HasIndex("RequestorUserId");

                    b.ToTable("FriendRequestNotifications");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Friendship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("User1Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User2Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("User2Id");

                    b.HasIndex("User1Id", "User2Id")
                        .IsUnique();

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeletionPrivacy")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ModificationPrivacy")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UploadedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ViewPrivacy")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("UploadedByUserId");

                    b.HasIndex("Path", "AlbumId")
                        .IsUnique();

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.PhotoComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("PhotoId");

                    b.ToTable("PhotoComments");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.PhotoCommentNotification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ForUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Read")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("ForUserId");

                    b.ToTable("PhotoCommentNotifications");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Tag", b =>
                {
                    b.Property<string>("TagText")
                        .HasColumnType("text")
                        .UseCollation("case_insensitive_collation");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TagText");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PhotoTag", b =>
                {
                    b.Property<Guid>("PhotosId")
                        .HasColumnType("uuid");

                    b.Property<string>("TagsTagText")
                        .HasColumnType("text");

                    b.HasKey("PhotosId", "TagsTagText");

                    b.HasIndex("TagsTagText");

                    b.ToTable("PhotoTag");
                });

            modelBuilder.Entity("AlbumApplicationUser", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Album", null)
                        .WithMany()
                        .HasForeignKey("DeletableAlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("DeletionUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlbumApplicationUser1", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Album", null)
                        .WithMany()
                        .HasForeignKey("ModifiableAlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ModificationUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlbumApplicationUser2", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ViewUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.Album", null)
                        .WithMany()
                        .HasForeignKey("ViewableAlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagText")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserPhoto", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Photo", null)
                        .WithMany()
                        .HasForeignKey("DeletablePhotosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("DeletionUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserPhoto1", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Photo", null)
                        .WithMany()
                        .HasForeignKey("ModifiablePhotosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ModificationUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationUserPhoto2", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ViewUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.Photo", null)
                        .WithMany()
                        .HasForeignKey("ViewablePhotosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Album", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "CreatedBy")
                        .WithMany("Albums")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.AlbumComment", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Album", "Album")
                        .WithMany("Comments")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.AlbumCommentNotification", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.AlbumComment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "For")
                        .WithMany("AlbumCommentNotifications")
                        .HasForeignKey("ForUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("For");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Block", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "BlockedBy")
                        .WithMany("BlockedUsers")
                        .HasForeignKey("BlockedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "Blocked")
                        .WithMany("BlockedByUsers")
                        .HasForeignKey("BlockedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blocked");

                    b.Navigation("BlockedBy");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.FriendRequestNotification", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "For")
                        .WithMany("ReceivedFriendRequests")
                        .HasForeignKey("ForUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "Requestor")
                        .WithMany("SentFriendRequests")
                        .HasForeignKey("RequestorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("For");

                    b.Navigation("Requestor");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Friendship", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Photo", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "UploadedBy")
                        .WithMany("Photos")
                        .HasForeignKey("UploadedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("UploadedBy");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.PhotoComment", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.Photo", "Photo")
                        .WithMany("Comments")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.PhotoCommentNotification", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.PhotoComment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", "For")
                        .WithMany("PhotoCommentNotifications")
                        .HasForeignKey("ForUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("For");
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
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
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

                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhotoTag", b =>
                {
                    b.HasOne("Honk.Server.Models.Data.Photo", null)
                        .WithMany()
                        .HasForeignKey("PhotosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Honk.Server.Models.Data.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagText")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Album", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.ApplicationUser", b =>
                {
                    b.Navigation("AlbumCommentNotifications");

                    b.Navigation("Albums");

                    b.Navigation("BlockedByUsers");

                    b.Navigation("BlockedUsers");

                    b.Navigation("PhotoCommentNotifications");

                    b.Navigation("Photos");

                    b.Navigation("ReceivedFriendRequests");

                    b.Navigation("SentFriendRequests");
                });

            modelBuilder.Entity("Honk.Server.Models.Data.Photo", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
