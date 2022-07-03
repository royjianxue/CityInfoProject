using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointOfInterests_Cities_CityId",
                table: "PointOfInterests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointOfInterests",
                table: "PointOfInterests");

            migrationBuilder.RenameTable(
                name: "PointOfInterests",
                newName: "PointsOfInterets");

            migrationBuilder.RenameIndex(
                name: "IX_PointOfInterests_CityId",
                table: "PointsOfInterets",
                newName: "IX_PointsOfInterets_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterets",
                table: "PointsOfInterets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterets_Cities_CityId",
                table: "PointsOfInterets",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterets_Cities_CityId",
                table: "PointsOfInterets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterets",
                table: "PointsOfInterets");

            migrationBuilder.RenameTable(
                name: "PointsOfInterets",
                newName: "PointOfInterests");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterets_CityId",
                table: "PointOfInterests",
                newName: "IX_PointOfInterests_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointOfInterests",
                table: "PointOfInterests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointOfInterests_Cities_CityId",
                table: "PointOfInterests",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
