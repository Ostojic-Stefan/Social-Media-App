﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FixNullForPostAndSub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Subs_SubId",
                table: "Posts");

            migrationBuilder.AlterColumn<Guid>(
                name: "SubId",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Subs_SubId",
                table: "Posts",
                column: "SubId",
                principalTable: "Subs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Subs_SubId",
                table: "Posts");

            migrationBuilder.AlterColumn<Guid>(
                name: "SubId",
                table: "Posts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Subs_SubId",
                table: "Posts",
                column: "SubId",
                principalTable: "Subs",
                principalColumn: "Id");
        }
    }
}
