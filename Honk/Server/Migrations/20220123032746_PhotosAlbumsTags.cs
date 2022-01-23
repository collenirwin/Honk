using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Honk.Server.Migrations;

public partial class PhotosAlbumsTags : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterDatabase()
            .Annotation("Npgsql:CollationDefinition:case_insensitive_collation", "@colStrength=primary,@colStrength=primary,icu,False");

        migrationBuilder.CreateTable(
            name: "Album",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                Name = table.Column<string>(type: "text", nullable: false),
                Description = table.Column<string>(type: "text", nullable: true),
                CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Album", x => x.Id);
                table.ForeignKey(
                    name: "FK_Album_AspNetUsers_CreatedByUserId",
                    column: x => x.CreatedByUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Tag",
            columns: table => new
            {
                TagText = table.Column<string>(type: "text", nullable: false, collation: "case_insensitive_collation"),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tag", x => x.TagText);
            });

        migrationBuilder.CreateTable(
            name: "Photo",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                Path = table.Column<string>(type: "text", nullable: false),
                Description = table.Column<string>(type: "text", nullable: true),
                AlbumId = table.Column<Guid>(type: "uuid", nullable: false),
                UploadedByUserId = table.Column<string>(type: "text", nullable: false),
                CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Photo", x => x.Id);
                table.ForeignKey(
                    name: "FK_Photo_Album_AlbumId",
                    column: x => x.AlbumId,
                    principalTable: "Album",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Photo_AspNetUsers_UploadedByUserId",
                    column: x => x.UploadedByUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AlbumTag",
            columns: table => new
            {
                AlbumsId = table.Column<Guid>(type: "uuid", nullable: false),
                TagsTagText = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AlbumTag", x => new { x.AlbumsId, x.TagsTagText });
                table.ForeignKey(
                    name: "FK_AlbumTag_Album_AlbumsId",
                    column: x => x.AlbumsId,
                    principalTable: "Album",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AlbumTag_Tag_TagsTagText",
                    column: x => x.TagsTagText,
                    principalTable: "Tag",
                    principalColumn: "TagText",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "PhotoTag",
            columns: table => new
            {
                PhotosId = table.Column<Guid>(type: "uuid", nullable: false),
                TagsTagText = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PhotoTag", x => new { x.PhotosId, x.TagsTagText });
                table.ForeignKey(
                    name: "FK_PhotoTag_Photo_PhotosId",
                    column: x => x.PhotosId,
                    principalTable: "Photo",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_PhotoTag_Tag_TagsTagText",
                    column: x => x.TagsTagText,
                    principalTable: "Tag",
                    principalColumn: "TagText",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Album_CreatedByUserId",
            table: "Album",
            column: "CreatedByUserId");

        migrationBuilder.CreateIndex(
            name: "IX_Album_Name_CreatedByUserId",
            table: "Album",
            columns: new[] { "Name", "CreatedByUserId" },
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_AlbumTag_TagsTagText",
            table: "AlbumTag",
            column: "TagsTagText");

        migrationBuilder.CreateIndex(
            name: "IX_Photo_AlbumId",
            table: "Photo",
            column: "AlbumId");

        migrationBuilder.CreateIndex(
            name: "IX_Photo_Path_AlbumId",
            table: "Photo",
            columns: new[] { "Path", "AlbumId" },
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Photo_UploadedByUserId",
            table: "Photo",
            column: "UploadedByUserId");

        migrationBuilder.CreateIndex(
            name: "IX_PhotoTag_TagsTagText",
            table: "PhotoTag",
            column: "TagsTagText");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AlbumTag");

        migrationBuilder.DropTable(
            name: "PhotoTag");

        migrationBuilder.DropTable(
            name: "Photo");

        migrationBuilder.DropTable(
            name: "Tag");

        migrationBuilder.DropTable(
            name: "Album");

        migrationBuilder.AlterDatabase()
            .OldAnnotation("Npgsql:CollationDefinition:case_insensitive_collation", "@colStrength=primary,@colStrength=primary,icu,False");
    }
}
