using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FictionFantasyServer.NetCoreEntry.Migrations
{
    public partial class JamesSettingsBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalityTraits",
                table: "BookIntroductionEntity");

            migrationBuilder.DropColumn(
                name: "Relationships",
                table: "BookIntroductionEntity");

            migrationBuilder.DropColumn(
                name: "Settings",
                table: "BookIntroductionEntity");

            migrationBuilder.AddColumn<Guid>(
                name: "BookIntroductionEntityId",
                table: "Settings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_BookIntroductionEntityId",
                table: "Settings",
                column: "BookIntroductionEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_BookIntroductionEntity_BookIntroductionEntityId",
                table: "Settings",
                column: "BookIntroductionEntityId",
                principalTable: "BookIntroductionEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settings_BookIntroductionEntity_BookIntroductionEntityId",
                table: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Settings_BookIntroductionEntityId",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "BookIntroductionEntityId",
                table: "Settings");

            migrationBuilder.AddColumn<List<string>>(
                name: "PersonalityTraits",
                table: "BookIntroductionEntity",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "Relationships",
                table: "BookIntroductionEntity",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "Settings",
                table: "BookIntroductionEntity",
                nullable: true);
        }
    }
}
