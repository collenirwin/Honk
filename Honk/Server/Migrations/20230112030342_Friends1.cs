using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Honk.Server.Migrations;

public partial class Friends1 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Album_AspNetUsers_CreatedByUserId",
            table: "Album");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_Album_AlbumsId",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_Tag_TagsTagText",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_Photo_Album_AlbumId",
            table: "Photo");

        migrationBuilder.DropForeignKey(
            name: "FK_Photo_AspNetUsers_UploadedByUserId",
            table: "Photo");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_Photo_PhotosId",
            table: "PhotoTag");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_Tag_TagsTagText",
            table: "PhotoTag");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Tag",
            table: "Tag");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Photo",
            table: "Photo");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Album",
            table: "Album");

        migrationBuilder.RenameTable(
            name: "Tag",
            newName: "Tags");

        migrationBuilder.RenameTable(
            name: "Photo",
            newName: "Photos");

        migrationBuilder.RenameTable(
            name: "Album",
            newName: "Albums");

        migrationBuilder.RenameIndex(
            name: "IX_Photo_UploadedByUserId",
            table: "Photos",
            newName: "IX_Photos_UploadedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_Photo_Path_AlbumId",
            table: "Photos",
            newName: "IX_Photos_Path_AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_Photo_AlbumId",
            table: "Photos",
            newName: "IX_Photos_AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_Album_Name_CreatedByUserId",
            table: "Albums",
            newName: "IX_Albums_Name_CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_Album_CreatedByUserId",
            table: "Albums",
            newName: "IX_Albums_CreatedByUserId");

        migrationBuilder.AddColumn<int>(
            name: "DeletionPrivacy",
            table: "Photos",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<int>(
            name: "ModificationPrivacy",
            table: "Photos",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<int>(
            name: "ViewPrivacy",
            table: "Photos",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<int>(
            name: "DeletionPrivacy",
            table: "Albums",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<int>(
            name: "ModificationPrivacy",
            table: "Albums",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddColumn<int>(
            name: "ViewPrivacy",
            table: "Albums",
            type: "integer",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.AddPrimaryKey(
            name: "PK_Tags",
            table: "Tags",
            column: "TagText");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Photos",
            table: "Photos",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Albums",
            table: "Albums",
            column: "Id");

        migrationBuilder.CreateTable(
            name: "AlbumApplicationUser",
            columns: table => new
            {
                DeletableAlbumsId = table.Column<Guid>(type: "uuid", nullable: false),
                DeletionUsersId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumApplicationUser", x => new { x.DeletableAlbumsId, x.DeletionUsersId });
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser_Albums_DeletableAlbumsId",
                    column: x => x.DeletableAlbumsId,
                    principalTable: "Albums",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser_AspNetUsers_DeletionUsersId",
                    column: x => x.DeletionUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AlbumApplicationUser1",
            columns: table => new
            {
                ModifiableAlbumsId = table.Column<Guid>(type: "uuid", nullable: false),
                ModificationUsersId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumApplicationUser1", x => new { x.ModifiableAlbumsId, x.ModificationUsersId });
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser1_Albums_ModifiableAlbumsId",
                    column: x => x.ModifiableAlbumsId,
                    principalTable: "Albums",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser1_AspNetUsers_ModificationUsersId",
                    column: x => x.ModificationUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AlbumApplicationUser2",
            columns: table => new
            {
                ViewUsersId = table.Column<string>(type: "text", nullable: false),
                ViewableAlbumsId = table.Column<Guid>(type: "uuid", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumApplicationUser2", x => new { x.ViewUsersId, x.ViewableAlbumsId });
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser2_Albums_ViewableAlbumsId",
                    column: x => x.ViewableAlbumsId,
                    principalTable: "Albums",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumApplicationUser2_AspNetUsers_ViewUsersId",
                    column: x => x.ViewUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AlbumComments",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                AlbumId = table.Column<Guid>(type: "uuid", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Text = table.Column<string>(type: "text", nullable: false),
                CreatedByUserId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumComments", x => x.Id);
                table.ForeignKey(
                    name: "FK_AlbumComments_Albums_AlbumId",
                    column: x => x.AlbumId,
                    principalTable: "Albums",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumComments_AspNetUsers_CreatedByUserId",
                    column: x => x.CreatedByUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ApplicationUserPhoto",
            columns: table => new
            {
                DeletablePhotosId = table.Column<Guid>(type: "uuid", nullable: false),
                DeletionUsersId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ApplicationUserPhoto", x => new { x.DeletablePhotosId, x.DeletionUsersId });
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto_AspNetUsers_DeletionUsersId",
                    column: x => x.DeletionUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto_Photos_DeletablePhotosId",
                    column: x => x.DeletablePhotosId,
                    principalTable: "Photos",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ApplicationUserPhoto1",
            columns: table => new
            {
                ModifiablePhotosId = table.Column<Guid>(type: "uuid", nullable: false),
                ModificationUsersId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ApplicationUserPhoto1", x => new { x.ModifiablePhotosId, x.ModificationUsersId });
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto1_AspNetUsers_ModificationUsersId",
                    column: x => x.ModificationUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto1_Photos_ModifiablePhotosId",
                    column: x => x.ModifiablePhotosId,
                    principalTable: "Photos",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ApplicationUserPhoto2",
            columns: table => new
            {
                ViewUsersId = table.Column<string>(type: "text", nullable: false),
                ViewablePhotosId = table.Column<Guid>(type: "uuid", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ApplicationUserPhoto2", x => new { x.ViewUsersId, x.ViewablePhotosId });
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto2_AspNetUsers_ViewUsersId",
                    column: x => x.ViewUsersId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ApplicationUserPhoto2_Photos_ViewablePhotosId",
                    column: x => x.ViewablePhotosId,
                    principalTable: "Photos",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Blocks",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                BlockedByUserId = table.Column<string>(type: "text", nullable: false),
                BlockedUserId = table.Column<string>(type: "text", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Blocks", x => x.Id);
                table.ForeignKey(
                    name: "FK_Blocks_AspNetUsers_BlockedByUserId",
                    column: x => x.BlockedByUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Blocks_AspNetUsers_BlockedUserId",
                    column: x => x.BlockedUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "FriendRequestNotifications",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                RequestorUserId = table.Column<string>(type: "text", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Read = table.Column<bool>(type: "boolean", nullable: false),
                ForUserId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FriendRequestNotifications", x => x.Id);
                table.ForeignKey(
                    name: "FK_FriendRequestNotifications_AspNetUsers_ForUserId",
                    column: x => x.ForUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_FriendRequestNotifications_AspNetUsers_RequestorUserId",
                    column: x => x.RequestorUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Friendships",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                User1Id = table.Column<string>(type: "text", nullable: false),
                User2Id = table.Column<string>(type: "text", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Friendships", x => x.Id);
                table.ForeignKey(
                    name: "FK_Friendships_AspNetUsers_User1Id",
                    column: x => x.User1Id,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Friendships_AspNetUsers_User2Id",
                    column: x => x.User2Id,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "PhotoComments",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                PhotoId = table.Column<Guid>(type: "uuid", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Text = table.Column<string>(type: "text", nullable: false),
                CreatedByUserId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PhotoComments", x => x.Id);
                table.ForeignKey(
                    name: "FK_PhotoComments_AspNetUsers_CreatedByUserId",
                    column: x => x.CreatedByUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_PhotoComments_Photos_PhotoId",
                    column: x => x.PhotoId,
                    principalTable: "Photos",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AlbumCommentNotifications",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Read = table.Column<bool>(type: "boolean", nullable: false),
                ForUserId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumCommentNotifications", x => x.Id);
                table.ForeignKey(
                    name: "FK_AlbumCommentNotifications_AlbumComments_CommentId",
                    column: x => x.CommentId,
                    principalTable: "AlbumComments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumCommentNotifications_AspNetUsers_ForUserId",
                    column: x => x.ForUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "PhotoCommentNotifications",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                CommentId = table.Column<Guid>(type: "uuid", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Read = table.Column<bool>(type: "boolean", nullable: false),
                ForUserId = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PhotoCommentNotifications", x => x.Id);
                table.ForeignKey(
                    name: "FK_PhotoCommentNotifications_AspNetUsers_ForUserId",
                    column: x => x.ForUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_PhotoCommentNotifications_PhotoComments_CommentId",
                    column: x => x.CommentId,
                    principalTable: "PhotoComments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_AlbumApplicationUser_DeletionUsersId",
            table: "AlbumApplicationUser",
            column: "DeletionUsersId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumApplicationUser1_ModificationUsersId",
            table: "AlbumApplicationUser1",
            column: "ModificationUsersId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumApplicationUser2_ViewableAlbumsId",
            table: "AlbumApplicationUser2",
            column: "ViewableAlbumsId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumCommentNotifications_CommentId",
            table: "AlbumCommentNotifications",
            column: "CommentId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumCommentNotifications_ForUserId",
            table: "AlbumCommentNotifications",
            column: "ForUserId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumComments_AlbumId",
            table: "AlbumComments",
            column: "AlbumId");

        migrationBuilder.CreateIndex(
            name: "IX_AlbumComments_CreatedByUserId",
            table: "AlbumComments",
            column: "CreatedByUserId");

        migrationBuilder.CreateIndex(
            name: "IX_ApplicationUserPhoto_DeletionUsersId",
            table: "ApplicationUserPhoto",
            column: "DeletionUsersId");

        migrationBuilder.CreateIndex(
            name: "IX_ApplicationUserPhoto1_ModificationUsersId",
            table: "ApplicationUserPhoto1",
            column: "ModificationUsersId");

        migrationBuilder.CreateIndex(
            name: "IX_ApplicationUserPhoto2_ViewablePhotosId",
            table: "ApplicationUserPhoto2",
            column: "ViewablePhotosId");

        migrationBuilder.CreateIndex(
            name: "IX_Blocks_BlockedByUserId",
            table: "Blocks",
            column: "BlockedByUserId");

        migrationBuilder.CreateIndex(
            name: "IX_Blocks_BlockedUserId",
            table: "Blocks",
            column: "BlockedUserId");

        migrationBuilder.CreateIndex(
            name: "IX_FriendRequestNotifications_ForUserId",
            table: "FriendRequestNotifications",
            column: "ForUserId");

        migrationBuilder.CreateIndex(
            name: "IX_FriendRequestNotifications_RequestorUserId",
            table: "FriendRequestNotifications",
            column: "RequestorUserId");

        migrationBuilder.CreateIndex(
            name: "IX_Friendships_User1Id_User2Id",
            table: "Friendships",
            columns: new[] { "User1Id", "User2Id" },
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Friendships_User2Id",
            table: "Friendships",
            column: "User2Id");

        migrationBuilder.CreateIndex(
            name: "IX_PhotoCommentNotifications_CommentId",
            table: "PhotoCommentNotifications",
            column: "CommentId");

        migrationBuilder.CreateIndex(
            name: "IX_PhotoCommentNotifications_ForUserId",
            table: "PhotoCommentNotifications",
            column: "ForUserId");

        migrationBuilder.CreateIndex(
            name: "IX_PhotoComments_CreatedByUserId",
            table: "PhotoComments",
            column: "CreatedByUserId");

        migrationBuilder.CreateIndex(
            name: "IX_PhotoComments_PhotoId",
            table: "PhotoComments",
            column: "PhotoId");

        migrationBuilder.AddForeignKey(
            name: "FK_Albums_AspNetUsers_CreatedByUserId",
            table: "Albums",
            column: "CreatedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_Albums_AlbumsId",
            table: "AlbumTag",
            column: "AlbumsId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_Tags_TagsTagText",
            table: "AlbumTag",
            column: "TagsTagText",
            principalTable: "Tags",
            principalColumn: "TagText",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Photos_Albums_AlbumId",
            table: "Photos",
            column: "AlbumId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Photos_AspNetUsers_UploadedByUserId",
            table: "Photos",
            column: "UploadedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_Photos_PhotosId",
            table: "PhotoTag",
            column: "PhotosId",
            principalTable: "Photos",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_Tags_TagsTagText",
            table: "PhotoTag",
            column: "TagsTagText",
            principalTable: "Tags",
            principalColumn: "TagText",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Albums_AspNetUsers_CreatedByUserId",
            table: "Albums");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_Albums_AlbumsId",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_Tags_TagsTagText",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_Photos_Albums_AlbumId",
            table: "Photos");

        migrationBuilder.DropForeignKey(
            name: "FK_Photos_AspNetUsers_UploadedByUserId",
            table: "Photos");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_Photos_PhotosId",
            table: "PhotoTag");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_Tags_TagsTagText",
            table: "PhotoTag");

        migrationBuilder.DropTable(
            name: "AlbumApplicationUser");

        migrationBuilder.DropTable(
            name: "AlbumApplicationUser1");

        migrationBuilder.DropTable(
            name: "AlbumApplicationUser2");

        migrationBuilder.DropTable(
            name: "AlbumCommentNotifications");

        migrationBuilder.DropTable(
            name: "ApplicationUserPhoto");

        migrationBuilder.DropTable(
            name: "ApplicationUserPhoto1");

        migrationBuilder.DropTable(
            name: "ApplicationUserPhoto2");

        migrationBuilder.DropTable(
            name: "Blocks");

        migrationBuilder.DropTable(
            name: "FriendRequestNotifications");

        migrationBuilder.DropTable(
            name: "Friendships");

        migrationBuilder.DropTable(
            name: "PhotoCommentNotifications");

        migrationBuilder.DropTable(
            name: "AlbumComments");

        migrationBuilder.DropTable(
            name: "PhotoComments");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Tags",
            table: "Tags");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Photos",
            table: "Photos");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Albums",
            table: "Albums");

        migrationBuilder.DropColumn(
            name: "DeletionPrivacy",
            table: "Photos");

        migrationBuilder.DropColumn(
            name: "ModificationPrivacy",
            table: "Photos");

        migrationBuilder.DropColumn(
            name: "ViewPrivacy",
            table: "Photos");

        migrationBuilder.DropColumn(
            name: "DeletionPrivacy",
            table: "Albums");

        migrationBuilder.DropColumn(
            name: "ModificationPrivacy",
            table: "Albums");

        migrationBuilder.DropColumn(
            name: "ViewPrivacy",
            table: "Albums");

        migrationBuilder.RenameTable(
            name: "Tags",
            newName: "Tag");

        migrationBuilder.RenameTable(
            name: "Photos",
            newName: "Photo");

        migrationBuilder.RenameTable(
            name: "Albums",
            newName: "Album");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_UploadedByUserId",
            table: "Photo",
            newName: "IX_Photo_UploadedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_Path_AlbumId",
            table: "Photo",
            newName: "IX_Photo_Path_AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_AlbumId",
            table: "Photo",
            newName: "IX_Photo_AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_Albums_Name_CreatedByUserId",
            table: "Album",
            newName: "IX_Album_Name_CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_Albums_CreatedByUserId",
            table: "Album",
            newName: "IX_Album_CreatedByUserId");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Tag",
            table: "Tag",
            column: "TagText");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Photo",
            table: "Photo",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Album",
            table: "Album",
            column: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Album_AspNetUsers_CreatedByUserId",
            table: "Album",
            column: "CreatedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_Album_AlbumsId",
            table: "AlbumTag",
            column: "AlbumsId",
            principalTable: "Album",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_Tag_TagsTagText",
            table: "AlbumTag",
            column: "TagsTagText",
            principalTable: "Tag",
            principalColumn: "TagText",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Photo_Album_AlbumId",
            table: "Photo",
            column: "AlbumId",
            principalTable: "Album",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Photo_AspNetUsers_UploadedByUserId",
            table: "Photo",
            column: "UploadedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_Photo_PhotosId",
            table: "PhotoTag",
            column: "PhotosId",
            principalTable: "Photo",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_Tag_TagsTagText",
            table: "PhotoTag",
            column: "TagsTagText",
            principalTable: "Tag",
            principalColumn: "TagText",
            onDelete: ReferentialAction.Cascade);
    }
}
