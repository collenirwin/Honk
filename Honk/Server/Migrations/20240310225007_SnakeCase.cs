using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Honk.Server.Migrations;

/// <inheritdoc />
public partial class SnakeCase : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser_Albums_DeletableAlbumsId",
            table: "AlbumApplicationUser");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser1_Albums_ModifiableAlbumsId",
            table: "AlbumApplicationUser1");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser2_Albums_ViewableAlbumsId",
            table: "AlbumApplicationUser2");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumCommentNotifications_AlbumComments_CommentId",
            table: "AlbumCommentNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumCommentNotifications_AspNetUsers_ForUserId",
            table: "AlbumCommentNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumComments_Albums_AlbumId",
            table: "AlbumComments");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumComments_AspNetUsers_CreatedByUserId",
            table: "AlbumComments");

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
            name: "FK_ApplicationUserPhoto_Photos_DeletablePhotosId",
            table: "ApplicationUserPhoto");

        migrationBuilder.DropForeignKey(
            name: "FK_ApplicationUserPhoto1_Photos_ModifiablePhotosId",
            table: "ApplicationUserPhoto1");

        migrationBuilder.DropForeignKey(
            name: "FK_ApplicationUserPhoto2_Photos_ViewablePhotosId",
            table: "ApplicationUserPhoto2");

        migrationBuilder.DropForeignKey(
            name: "FK_Blocks_AspNetUsers_BlockedByUserId",
            table: "Blocks");

        migrationBuilder.DropForeignKey(
            name: "FK_Blocks_AspNetUsers_BlockedUserId",
            table: "Blocks");

        migrationBuilder.DropForeignKey(
            name: "FK_FriendRequestNotifications_AspNetUsers_ForUserId",
            table: "FriendRequestNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_FriendRequestNotifications_AspNetUsers_RequestorUserId",
            table: "FriendRequestNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_Friendships_AspNetUsers_User1Id",
            table: "Friendships");

        migrationBuilder.DropForeignKey(
            name: "FK_Friendships_AspNetUsers_User2Id",
            table: "Friendships");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoCommentNotifications_AspNetUsers_ForUserId",
            table: "PhotoCommentNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoCommentNotifications_PhotoComments_CommentId",
            table: "PhotoCommentNotifications");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoComments_AspNetUsers_CreatedByUserId",
            table: "PhotoComments");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoComments_Photos_PhotoId",
            table: "PhotoComments");

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

        migrationBuilder.DropPrimaryKey(
            name: "PK_Tags",
            table: "Tags");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Photos",
            table: "Photos");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Friendships",
            table: "Friendships");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Blocks",
            table: "Blocks");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Albums",
            table: "Albums");

        migrationBuilder.DropPrimaryKey(
            name: "PK_PhotoComments",
            table: "PhotoComments");

        migrationBuilder.DropPrimaryKey(
            name: "PK_PhotoCommentNotifications",
            table: "PhotoCommentNotifications");

        migrationBuilder.DropPrimaryKey(
            name: "PK_FriendRequestNotifications",
            table: "FriendRequestNotifications");

        migrationBuilder.DropPrimaryKey(
            name: "PK_AlbumComments",
            table: "AlbumComments");

        migrationBuilder.DropPrimaryKey(
            name: "PK_AlbumCommentNotifications",
            table: "AlbumCommentNotifications");

        migrationBuilder.RenameTable(
            name: "Tags",
            newName: "tags");

        migrationBuilder.RenameTable(
            name: "Photos",
            newName: "photos");

        migrationBuilder.RenameTable(
            name: "Friendships",
            newName: "friendships");

        migrationBuilder.RenameTable(
            name: "Blocks",
            newName: "blocks");

        migrationBuilder.RenameTable(
            name: "Albums",
            newName: "albums");

        migrationBuilder.RenameTable(
            name: "PhotoComments",
            newName: "photo_comments");

        migrationBuilder.RenameTable(
            name: "PhotoCommentNotifications",
            newName: "photo_comment_notifications");

        migrationBuilder.RenameTable(
            name: "FriendRequestNotifications",
            newName: "friend_request_notifications");

        migrationBuilder.RenameTable(
            name: "AlbumComments",
            newName: "album_comments");

        migrationBuilder.RenameTable(
            name: "AlbumCommentNotifications",
            newName: "album_comment_notifications");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "tags",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "tags",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "TagText",
            table: "tags",
            newName: "tag_text");

        migrationBuilder.RenameColumn(
            name: "Path",
            table: "photos",
            newName: "path");

        migrationBuilder.RenameColumn(
            name: "Description",
            table: "photos",
            newName: "description");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "photos",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "ViewPrivacy",
            table: "photos",
            newName: "view_privacy");

        migrationBuilder.RenameColumn(
            name: "UploadedByUserId",
            table: "photos",
            newName: "uploaded_by_user_id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "photos",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "ModificationPrivacy",
            table: "photos",
            newName: "modification_privacy");

        migrationBuilder.RenameColumn(
            name: "DeletionPrivacy",
            table: "photos",
            newName: "deletion_privacy");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "photos",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "AlbumId",
            table: "photos",
            newName: "album_id");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_UploadedByUserId",
            table: "photos",
            newName: "IX_photos_uploaded_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_Path_AlbumId",
            table: "photos",
            newName: "IX_photos_path_album_id");

        migrationBuilder.RenameIndex(
            name: "IX_Photos_AlbumId",
            table: "photos",
            newName: "IX_photos_album_id");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "friendships",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "User2Id",
            table: "friendships",
            newName: "user_2_id");

        migrationBuilder.RenameColumn(
            name: "User1Id",
            table: "friendships",
            newName: "user_1_id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "friendships",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "friendships",
            newName: "created_on");

        migrationBuilder.RenameIndex(
            name: "IX_Friendships_User2Id",
            table: "friendships",
            newName: "IX_friendships_user_2_id");

        migrationBuilder.RenameIndex(
            name: "IX_Friendships_User1Id_User2Id",
            table: "friendships",
            newName: "IX_friendships_user_1_id_user_2_id");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "blocks",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "blocks",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "blocks",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "BlockedUserId",
            table: "blocks",
            newName: "blocked_user_id");

        migrationBuilder.RenameColumn(
            name: "BlockedByUserId",
            table: "blocks",
            newName: "blocked_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_Blocks_BlockedUserId",
            table: "blocks",
            newName: "IX_blocks_blocked_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_Blocks_BlockedByUserId",
            table: "blocks",
            newName: "IX_blocks_blocked_by_user_id");

        migrationBuilder.RenameColumn(
            name: "Name",
            table: "albums",
            newName: "name");

        migrationBuilder.RenameColumn(
            name: "Description",
            table: "albums",
            newName: "description");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "albums",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "ViewPrivacy",
            table: "albums",
            newName: "view_privacy");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "albums",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "ModificationPrivacy",
            table: "albums",
            newName: "modification_privacy");

        migrationBuilder.RenameColumn(
            name: "DeletionPrivacy",
            table: "albums",
            newName: "deletion_privacy");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "albums",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "CreatedByUserId",
            table: "albums",
            newName: "created_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_Albums_Name_CreatedByUserId",
            table: "albums",
            newName: "IX_albums_name_created_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_Albums_CreatedByUserId",
            table: "albums",
            newName: "IX_albums_created_by_user_id");

        migrationBuilder.RenameColumn(
            name: "Text",
            table: "photo_comments",
            newName: "text");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "photo_comments",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "photo_comments",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "PhotoId",
            table: "photo_comments",
            newName: "photo_id");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "photo_comments",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "CreatedByUserId",
            table: "photo_comments",
            newName: "created_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_PhotoComments_PhotoId",
            table: "photo_comments",
            newName: "IX_photo_comments_photo_id");

        migrationBuilder.RenameIndex(
            name: "IX_PhotoComments_CreatedByUserId",
            table: "photo_comments",
            newName: "IX_photo_comments_created_by_user_id");

        migrationBuilder.RenameColumn(
            name: "Read",
            table: "photo_comment_notifications",
            newName: "read");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "photo_comment_notifications",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "photo_comment_notifications",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "ForUserId",
            table: "photo_comment_notifications",
            newName: "for_user_id");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "photo_comment_notifications",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "CommentId",
            table: "photo_comment_notifications",
            newName: "comment_id");

        migrationBuilder.RenameIndex(
            name: "IX_PhotoCommentNotifications_ForUserId",
            table: "photo_comment_notifications",
            newName: "IX_photo_comment_notifications_for_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_PhotoCommentNotifications_CommentId",
            table: "photo_comment_notifications",
            newName: "IX_photo_comment_notifications_comment_id");

        migrationBuilder.RenameColumn(
            name: "Read",
            table: "friend_request_notifications",
            newName: "read");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "friend_request_notifications",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "friend_request_notifications",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "RequestorUserId",
            table: "friend_request_notifications",
            newName: "requestor_user_id");

        migrationBuilder.RenameColumn(
            name: "ForUserId",
            table: "friend_request_notifications",
            newName: "for_user_id");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "friend_request_notifications",
            newName: "created_on");

        migrationBuilder.RenameIndex(
            name: "IX_FriendRequestNotifications_RequestorUserId",
            table: "friend_request_notifications",
            newName: "IX_friend_request_notifications_requestor_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_FriendRequestNotifications_ForUserId",
            table: "friend_request_notifications",
            newName: "IX_friend_request_notifications_for_user_id");

        migrationBuilder.RenameColumn(
            name: "Text",
            table: "album_comments",
            newName: "text");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "album_comments",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "album_comments",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "album_comments",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "CreatedByUserId",
            table: "album_comments",
            newName: "created_by_user_id");

        migrationBuilder.RenameColumn(
            name: "AlbumId",
            table: "album_comments",
            newName: "album_id");

        migrationBuilder.RenameIndex(
            name: "IX_AlbumComments_CreatedByUserId",
            table: "album_comments",
            newName: "IX_album_comments_created_by_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_AlbumComments_AlbumId",
            table: "album_comments",
            newName: "IX_album_comments_album_id");

        migrationBuilder.RenameColumn(
            name: "Read",
            table: "album_comment_notifications",
            newName: "read");

        migrationBuilder.RenameColumn(
            name: "Id",
            table: "album_comment_notifications",
            newName: "id");

        migrationBuilder.RenameColumn(
            name: "UpdatedOn",
            table: "album_comment_notifications",
            newName: "updated_on");

        migrationBuilder.RenameColumn(
            name: "ForUserId",
            table: "album_comment_notifications",
            newName: "for_user_id");

        migrationBuilder.RenameColumn(
            name: "CreatedOn",
            table: "album_comment_notifications",
            newName: "created_on");

        migrationBuilder.RenameColumn(
            name: "CommentId",
            table: "album_comment_notifications",
            newName: "comment_id");

        migrationBuilder.RenameIndex(
            name: "IX_AlbumCommentNotifications_ForUserId",
            table: "album_comment_notifications",
            newName: "IX_album_comment_notifications_for_user_id");

        migrationBuilder.RenameIndex(
            name: "IX_AlbumCommentNotifications_CommentId",
            table: "album_comment_notifications",
            newName: "IX_album_comment_notifications_comment_id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_tags",
            table: "tags",
            column: "tag_text");

        migrationBuilder.AddPrimaryKey(
            name: "PK_photos",
            table: "photos",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_friendships",
            table: "friendships",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_blocks",
            table: "blocks",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_albums",
            table: "albums",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_photo_comments",
            table: "photo_comments",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_photo_comment_notifications",
            table: "photo_comment_notifications",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_friend_request_notifications",
            table: "friend_request_notifications",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_album_comments",
            table: "album_comments",
            column: "id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_album_comment_notifications",
            table: "album_comment_notifications",
            column: "id");

        migrationBuilder.AddForeignKey(
            name: "FK_album_comment_notifications_AspNetUsers_for_user_id",
            table: "album_comment_notifications",
            column: "for_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_album_comment_notifications_album_comments_comment_id",
            table: "album_comment_notifications",
            column: "comment_id",
            principalTable: "album_comments",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_album_comments_AspNetUsers_created_by_user_id",
            table: "album_comments",
            column: "created_by_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_album_comments_albums_album_id",
            table: "album_comments",
            column: "album_id",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser_albums_DeletableAlbumsId",
            table: "AlbumApplicationUser",
            column: "DeletableAlbumsId",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser1_albums_ModifiableAlbumsId",
            table: "AlbumApplicationUser1",
            column: "ModifiableAlbumsId",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser2_albums_ViewableAlbumsId",
            table: "AlbumApplicationUser2",
            column: "ViewableAlbumsId",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_albums_AspNetUsers_created_by_user_id",
            table: "albums",
            column: "created_by_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_albums_AlbumsId",
            table: "AlbumTag",
            column: "AlbumsId",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumTag_tags_TagsTagText",
            table: "AlbumTag",
            column: "TagsTagText",
            principalTable: "tags",
            principalColumn: "tag_text",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_ApplicationUserPhoto_photos_DeletablePhotosId",
            table: "ApplicationUserPhoto",
            column: "DeletablePhotosId",
            principalTable: "photos",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_ApplicationUserPhoto1_photos_ModifiablePhotosId",
            table: "ApplicationUserPhoto1",
            column: "ModifiablePhotosId",
            principalTable: "photos",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_ApplicationUserPhoto2_photos_ViewablePhotosId",
            table: "ApplicationUserPhoto2",
            column: "ViewablePhotosId",
            principalTable: "photos",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_blocks_AspNetUsers_blocked_by_user_id",
            table: "blocks",
            column: "blocked_by_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_blocks_AspNetUsers_blocked_user_id",
            table: "blocks",
            column: "blocked_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_friend_request_notifications_AspNetUsers_for_user_id",
            table: "friend_request_notifications",
            column: "for_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_friend_request_notifications_AspNetUsers_requestor_user_id",
            table: "friend_request_notifications",
            column: "requestor_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_friendships_AspNetUsers_user_1_id",
            table: "friendships",
            column: "user_1_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_friendships_AspNetUsers_user_2_id",
            table: "friendships",
            column: "user_2_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photo_comment_notifications_AspNetUsers_for_user_id",
            table: "photo_comment_notifications",
            column: "for_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photo_comment_notifications_photo_comments_comment_id",
            table: "photo_comment_notifications",
            column: "comment_id",
            principalTable: "photo_comments",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photo_comments_AspNetUsers_created_by_user_id",
            table: "photo_comments",
            column: "created_by_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photo_comments_photos_photo_id",
            table: "photo_comments",
            column: "photo_id",
            principalTable: "photos",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photos_AspNetUsers_uploaded_by_user_id",
            table: "photos",
            column: "uploaded_by_user_id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_photos_albums_album_id",
            table: "photos",
            column: "album_id",
            principalTable: "albums",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_photos_PhotosId",
            table: "PhotoTag",
            column: "PhotosId",
            principalTable: "photos",
            principalColumn: "id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoTag_tags_TagsTagText",
            table: "PhotoTag",
            column: "TagsTagText",
            principalTable: "tags",
            principalColumn: "tag_text",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_album_comment_notifications_AspNetUsers_for_user_id",
            table: "album_comment_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_album_comment_notifications_album_comments_comment_id",
            table: "album_comment_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_album_comments_AspNetUsers_created_by_user_id",
            table: "album_comments");

        migrationBuilder.DropForeignKey(
            name: "FK_album_comments_albums_album_id",
            table: "album_comments");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser_albums_DeletableAlbumsId",
            table: "AlbumApplicationUser");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser1_albums_ModifiableAlbumsId",
            table: "AlbumApplicationUser1");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumApplicationUser2_albums_ViewableAlbumsId",
            table: "AlbumApplicationUser2");

        migrationBuilder.DropForeignKey(
            name: "FK_albums_AspNetUsers_created_by_user_id",
            table: "albums");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_albums_AlbumsId",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_AlbumTag_tags_TagsTagText",
            table: "AlbumTag");

        migrationBuilder.DropForeignKey(
            name: "FK_ApplicationUserPhoto_photos_DeletablePhotosId",
            table: "ApplicationUserPhoto");

        migrationBuilder.DropForeignKey(
            name: "FK_ApplicationUserPhoto1_photos_ModifiablePhotosId",
            table: "ApplicationUserPhoto1");

        migrationBuilder.DropForeignKey(
            name: "FK_ApplicationUserPhoto2_photos_ViewablePhotosId",
            table: "ApplicationUserPhoto2");

        migrationBuilder.DropForeignKey(
            name: "FK_blocks_AspNetUsers_blocked_by_user_id",
            table: "blocks");

        migrationBuilder.DropForeignKey(
            name: "FK_blocks_AspNetUsers_blocked_user_id",
            table: "blocks");

        migrationBuilder.DropForeignKey(
            name: "FK_friend_request_notifications_AspNetUsers_for_user_id",
            table: "friend_request_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_friend_request_notifications_AspNetUsers_requestor_user_id",
            table: "friend_request_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_friendships_AspNetUsers_user_1_id",
            table: "friendships");

        migrationBuilder.DropForeignKey(
            name: "FK_friendships_AspNetUsers_user_2_id",
            table: "friendships");

        migrationBuilder.DropForeignKey(
            name: "FK_photo_comment_notifications_AspNetUsers_for_user_id",
            table: "photo_comment_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_photo_comment_notifications_photo_comments_comment_id",
            table: "photo_comment_notifications");

        migrationBuilder.DropForeignKey(
            name: "FK_photo_comments_AspNetUsers_created_by_user_id",
            table: "photo_comments");

        migrationBuilder.DropForeignKey(
            name: "FK_photo_comments_photos_photo_id",
            table: "photo_comments");

        migrationBuilder.DropForeignKey(
            name: "FK_photos_AspNetUsers_uploaded_by_user_id",
            table: "photos");

        migrationBuilder.DropForeignKey(
            name: "FK_photos_albums_album_id",
            table: "photos");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_photos_PhotosId",
            table: "PhotoTag");

        migrationBuilder.DropForeignKey(
            name: "FK_PhotoTag_tags_TagsTagText",
            table: "PhotoTag");

        migrationBuilder.DropPrimaryKey(
            name: "PK_tags",
            table: "tags");

        migrationBuilder.DropPrimaryKey(
            name: "PK_photos",
            table: "photos");

        migrationBuilder.DropPrimaryKey(
            name: "PK_friendships",
            table: "friendships");

        migrationBuilder.DropPrimaryKey(
            name: "PK_blocks",
            table: "blocks");

        migrationBuilder.DropPrimaryKey(
            name: "PK_albums",
            table: "albums");

        migrationBuilder.DropPrimaryKey(
            name: "PK_photo_comments",
            table: "photo_comments");

        migrationBuilder.DropPrimaryKey(
            name: "PK_photo_comment_notifications",
            table: "photo_comment_notifications");

        migrationBuilder.DropPrimaryKey(
            name: "PK_friend_request_notifications",
            table: "friend_request_notifications");

        migrationBuilder.DropPrimaryKey(
            name: "PK_album_comments",
            table: "album_comments");

        migrationBuilder.DropPrimaryKey(
            name: "PK_album_comment_notifications",
            table: "album_comment_notifications");

        migrationBuilder.RenameTable(
            name: "tags",
            newName: "Tags");

        migrationBuilder.RenameTable(
            name: "photos",
            newName: "Photos");

        migrationBuilder.RenameTable(
            name: "friendships",
            newName: "Friendships");

        migrationBuilder.RenameTable(
            name: "blocks",
            newName: "Blocks");

        migrationBuilder.RenameTable(
            name: "albums",
            newName: "Albums");

        migrationBuilder.RenameTable(
            name: "photo_comments",
            newName: "PhotoComments");

        migrationBuilder.RenameTable(
            name: "photo_comment_notifications",
            newName: "PhotoCommentNotifications");

        migrationBuilder.RenameTable(
            name: "friend_request_notifications",
            newName: "FriendRequestNotifications");

        migrationBuilder.RenameTable(
            name: "album_comments",
            newName: "AlbumComments");

        migrationBuilder.RenameTable(
            name: "album_comment_notifications",
            newName: "AlbumCommentNotifications");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "Tags",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "Tags",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "tag_text",
            table: "Tags",
            newName: "TagText");

        migrationBuilder.RenameColumn(
            name: "path",
            table: "Photos",
            newName: "Path");

        migrationBuilder.RenameColumn(
            name: "description",
            table: "Photos",
            newName: "Description");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "Photos",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "view_privacy",
            table: "Photos",
            newName: "ViewPrivacy");

        migrationBuilder.RenameColumn(
            name: "uploaded_by_user_id",
            table: "Photos",
            newName: "UploadedByUserId");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "Photos",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "modification_privacy",
            table: "Photos",
            newName: "ModificationPrivacy");

        migrationBuilder.RenameColumn(
            name: "deletion_privacy",
            table: "Photos",
            newName: "DeletionPrivacy");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "Photos",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "album_id",
            table: "Photos",
            newName: "AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_photos_uploaded_by_user_id",
            table: "Photos",
            newName: "IX_Photos_UploadedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_photos_path_album_id",
            table: "Photos",
            newName: "IX_Photos_Path_AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_photos_album_id",
            table: "Photos",
            newName: "IX_Photos_AlbumId");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "Friendships",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "user_2_id",
            table: "Friendships",
            newName: "User2Id");

        migrationBuilder.RenameColumn(
            name: "user_1_id",
            table: "Friendships",
            newName: "User1Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "Friendships",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "Friendships",
            newName: "CreatedOn");

        migrationBuilder.RenameIndex(
            name: "IX_friendships_user_2_id",
            table: "Friendships",
            newName: "IX_Friendships_User2Id");

        migrationBuilder.RenameIndex(
            name: "IX_friendships_user_1_id_user_2_id",
            table: "Friendships",
            newName: "IX_Friendships_User1Id_User2Id");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "Blocks",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "Blocks",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "Blocks",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "blocked_user_id",
            table: "Blocks",
            newName: "BlockedUserId");

        migrationBuilder.RenameColumn(
            name: "blocked_by_user_id",
            table: "Blocks",
            newName: "BlockedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_blocks_blocked_user_id",
            table: "Blocks",
            newName: "IX_Blocks_BlockedUserId");

        migrationBuilder.RenameIndex(
            name: "IX_blocks_blocked_by_user_id",
            table: "Blocks",
            newName: "IX_Blocks_BlockedByUserId");

        migrationBuilder.RenameColumn(
            name: "name",
            table: "Albums",
            newName: "Name");

        migrationBuilder.RenameColumn(
            name: "description",
            table: "Albums",
            newName: "Description");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "Albums",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "view_privacy",
            table: "Albums",
            newName: "ViewPrivacy");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "Albums",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "modification_privacy",
            table: "Albums",
            newName: "ModificationPrivacy");

        migrationBuilder.RenameColumn(
            name: "deletion_privacy",
            table: "Albums",
            newName: "DeletionPrivacy");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "Albums",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "created_by_user_id",
            table: "Albums",
            newName: "CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_albums_name_created_by_user_id",
            table: "Albums",
            newName: "IX_Albums_Name_CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_albums_created_by_user_id",
            table: "Albums",
            newName: "IX_Albums_CreatedByUserId");

        migrationBuilder.RenameColumn(
            name: "text",
            table: "PhotoComments",
            newName: "Text");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "PhotoComments",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "PhotoComments",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "photo_id",
            table: "PhotoComments",
            newName: "PhotoId");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "PhotoComments",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "created_by_user_id",
            table: "PhotoComments",
            newName: "CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_photo_comments_photo_id",
            table: "PhotoComments",
            newName: "IX_PhotoComments_PhotoId");

        migrationBuilder.RenameIndex(
            name: "IX_photo_comments_created_by_user_id",
            table: "PhotoComments",
            newName: "IX_PhotoComments_CreatedByUserId");

        migrationBuilder.RenameColumn(
            name: "read",
            table: "PhotoCommentNotifications",
            newName: "Read");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "PhotoCommentNotifications",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "PhotoCommentNotifications",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "for_user_id",
            table: "PhotoCommentNotifications",
            newName: "ForUserId");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "PhotoCommentNotifications",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "comment_id",
            table: "PhotoCommentNotifications",
            newName: "CommentId");

        migrationBuilder.RenameIndex(
            name: "IX_photo_comment_notifications_for_user_id",
            table: "PhotoCommentNotifications",
            newName: "IX_PhotoCommentNotifications_ForUserId");

        migrationBuilder.RenameIndex(
            name: "IX_photo_comment_notifications_comment_id",
            table: "PhotoCommentNotifications",
            newName: "IX_PhotoCommentNotifications_CommentId");

        migrationBuilder.RenameColumn(
            name: "read",
            table: "FriendRequestNotifications",
            newName: "Read");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "FriendRequestNotifications",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "FriendRequestNotifications",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "requestor_user_id",
            table: "FriendRequestNotifications",
            newName: "RequestorUserId");

        migrationBuilder.RenameColumn(
            name: "for_user_id",
            table: "FriendRequestNotifications",
            newName: "ForUserId");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "FriendRequestNotifications",
            newName: "CreatedOn");

        migrationBuilder.RenameIndex(
            name: "IX_friend_request_notifications_requestor_user_id",
            table: "FriendRequestNotifications",
            newName: "IX_FriendRequestNotifications_RequestorUserId");

        migrationBuilder.RenameIndex(
            name: "IX_friend_request_notifications_for_user_id",
            table: "FriendRequestNotifications",
            newName: "IX_FriendRequestNotifications_ForUserId");

        migrationBuilder.RenameColumn(
            name: "text",
            table: "AlbumComments",
            newName: "Text");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "AlbumComments",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "AlbumComments",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "AlbumComments",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "created_by_user_id",
            table: "AlbumComments",
            newName: "CreatedByUserId");

        migrationBuilder.RenameColumn(
            name: "album_id",
            table: "AlbumComments",
            newName: "AlbumId");

        migrationBuilder.RenameIndex(
            name: "IX_album_comments_created_by_user_id",
            table: "AlbumComments",
            newName: "IX_AlbumComments_CreatedByUserId");

        migrationBuilder.RenameIndex(
            name: "IX_album_comments_album_id",
            table: "AlbumComments",
            newName: "IX_AlbumComments_AlbumId");

        migrationBuilder.RenameColumn(
            name: "read",
            table: "AlbumCommentNotifications",
            newName: "Read");

        migrationBuilder.RenameColumn(
            name: "id",
            table: "AlbumCommentNotifications",
            newName: "Id");

        migrationBuilder.RenameColumn(
            name: "updated_on",
            table: "AlbumCommentNotifications",
            newName: "UpdatedOn");

        migrationBuilder.RenameColumn(
            name: "for_user_id",
            table: "AlbumCommentNotifications",
            newName: "ForUserId");

        migrationBuilder.RenameColumn(
            name: "created_on",
            table: "AlbumCommentNotifications",
            newName: "CreatedOn");

        migrationBuilder.RenameColumn(
            name: "comment_id",
            table: "AlbumCommentNotifications",
            newName: "CommentId");

        migrationBuilder.RenameIndex(
            name: "IX_album_comment_notifications_for_user_id",
            table: "AlbumCommentNotifications",
            newName: "IX_AlbumCommentNotifications_ForUserId");

        migrationBuilder.RenameIndex(
            name: "IX_album_comment_notifications_comment_id",
            table: "AlbumCommentNotifications",
            newName: "IX_AlbumCommentNotifications_CommentId");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Tags",
            table: "Tags",
            column: "TagText");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Photos",
            table: "Photos",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Friendships",
            table: "Friendships",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Blocks",
            table: "Blocks",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Albums",
            table: "Albums",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_PhotoComments",
            table: "PhotoComments",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_PhotoCommentNotifications",
            table: "PhotoCommentNotifications",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_FriendRequestNotifications",
            table: "FriendRequestNotifications",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_AlbumComments",
            table: "AlbumComments",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_AlbumCommentNotifications",
            table: "AlbumCommentNotifications",
            column: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser_Albums_DeletableAlbumsId",
            table: "AlbumApplicationUser",
            column: "DeletableAlbumsId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser1_Albums_ModifiableAlbumsId",
            table: "AlbumApplicationUser1",
            column: "ModifiableAlbumsId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumApplicationUser2_Albums_ViewableAlbumsId",
            table: "AlbumApplicationUser2",
            column: "ViewableAlbumsId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumCommentNotifications_AlbumComments_CommentId",
            table: "AlbumCommentNotifications",
            column: "CommentId",
            principalTable: "AlbumComments",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumCommentNotifications_AspNetUsers_ForUserId",
            table: "AlbumCommentNotifications",
            column: "ForUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumComments_Albums_AlbumId",
            table: "AlbumComments",
            column: "AlbumId",
            principalTable: "Albums",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_AlbumComments_AspNetUsers_CreatedByUserId",
            table: "AlbumComments",
            column: "CreatedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

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
            name: "FK_ApplicationUserPhoto_Photos_DeletablePhotosId",
            table: "ApplicationUserPhoto",
            column: "DeletablePhotosId",
            principalTable: "Photos",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_ApplicationUserPhoto1_Photos_ModifiablePhotosId",
            table: "ApplicationUserPhoto1",
            column: "ModifiablePhotosId",
            principalTable: "Photos",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_ApplicationUserPhoto2_Photos_ViewablePhotosId",
            table: "ApplicationUserPhoto2",
            column: "ViewablePhotosId",
            principalTable: "Photos",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Blocks_AspNetUsers_BlockedByUserId",
            table: "Blocks",
            column: "BlockedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Blocks_AspNetUsers_BlockedUserId",
            table: "Blocks",
            column: "BlockedUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_FriendRequestNotifications_AspNetUsers_ForUserId",
            table: "FriendRequestNotifications",
            column: "ForUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_FriendRequestNotifications_AspNetUsers_RequestorUserId",
            table: "FriendRequestNotifications",
            column: "RequestorUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Friendships_AspNetUsers_User1Id",
            table: "Friendships",
            column: "User1Id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_Friendships_AspNetUsers_User2Id",
            table: "Friendships",
            column: "User2Id",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoCommentNotifications_AspNetUsers_ForUserId",
            table: "PhotoCommentNotifications",
            column: "ForUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoCommentNotifications_PhotoComments_CommentId",
            table: "PhotoCommentNotifications",
            column: "CommentId",
            principalTable: "PhotoComments",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoComments_AspNetUsers_CreatedByUserId",
            table: "PhotoComments",
            column: "CreatedByUserId",
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);

        migrationBuilder.AddForeignKey(
            name: "FK_PhotoComments_Photos_PhotoId",
            table: "PhotoComments",
            column: "PhotoId",
            principalTable: "Photos",
            principalColumn: "Id",
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
}
