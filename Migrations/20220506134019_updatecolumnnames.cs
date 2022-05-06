using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class updatecolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwner_id",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwner_id",
                table: "Pets",
                newName: "petOwnerid");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwner_id",
                table: "Pets",
                newName: "IX_Pets_petOwnerid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "checkedInAt",
                table: "Pets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets",
                column: "petOwnerid",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnerid",
                table: "Pets",
                newName: "petOwner_id");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnerid",
                table: "Pets",
                newName: "IX_Pets_petOwner_id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "checkedInAt",
                table: "Pets",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwner_id",
                table: "Pets",
                column: "petOwner_id",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
