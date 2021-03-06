﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AnnotationsHaveBeenUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CustomerId",
                table: "Books",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Customers_CustomerId",
                table: "Books",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Customers_CustomerId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CustomerId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Books");
        }
    }
}
