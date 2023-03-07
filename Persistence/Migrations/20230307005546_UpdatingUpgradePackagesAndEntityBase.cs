using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UpdatingUpgradePackagesAndEntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "UserPermissions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Email");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "UserPermissions",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "RolePermission",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Permission",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Email",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<Guid>(
                name: "UserCreatorId",
                table: "Users",
                type: "uniqueidentifier",
                maxLength: 256,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserCreatorId",
                table: "UserPermissions",
                type: "uniqueidentifier",
                maxLength: 256,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserCreatorId",
                table: "RolePermission",
                type: "uniqueidentifier",
                maxLength: 256,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserCreatorId",
                table: "Permission",
                type: "uniqueidentifier",
                maxLength: 256,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserCreatorId",
                table: "Email",
                type: "uniqueidentifier",
                maxLength: 256,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreatorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserCreatorId",
                table: "UserPermissions");

            migrationBuilder.DropColumn(
                name: "UserCreatorId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "UserCreatorId",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "UserCreatorId",
                table: "Email");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "UserPermissions",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "RolePermission",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Permission",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Email",
                newName: "LastModification");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "UserPermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "RolePermission",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Permission",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Email",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
