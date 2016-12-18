using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserEvents",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Places",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "PhotoEvents",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Photos",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Events",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Activities",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "UserEvents",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "Places",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "PhotoEvents",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "Photos",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "Events",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "Activities",
                schema: "dbo");
        }
    }
}
