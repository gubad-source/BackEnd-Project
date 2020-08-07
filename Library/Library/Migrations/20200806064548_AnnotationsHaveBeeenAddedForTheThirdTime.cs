using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AnnotationsHaveBeeenAddedForTheThirdTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Bookcase_BookcaseId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Shelf_ShelfId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelf",
                table: "Shelf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookcase",
                table: "Bookcase");

            migrationBuilder.RenameTable(
                name: "Shelf",
                newName: "Shelfs");

            migrationBuilder.RenameTable(
                name: "Bookcase",
                newName: "Bookcases");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelfs",
                table: "Shelfs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookcases",
                table: "Bookcases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Bookcases_BookcaseId",
                table: "Books",
                column: "BookcaseId",
                principalTable: "Bookcases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Shelfs_ShelfId",
                table: "Books",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Bookcases_BookcaseId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Shelfs_ShelfId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelfs",
                table: "Shelfs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookcases",
                table: "Bookcases");

            migrationBuilder.RenameTable(
                name: "Shelfs",
                newName: "Shelf");

            migrationBuilder.RenameTable(
                name: "Bookcases",
                newName: "Bookcase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelf",
                table: "Shelf",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookcase",
                table: "Bookcase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Bookcase_BookcaseId",
                table: "Books",
                column: "BookcaseId",
                principalTable: "Bookcase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Shelf_ShelfId",
                table: "Books",
                column: "ShelfId",
                principalTable: "Shelf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
