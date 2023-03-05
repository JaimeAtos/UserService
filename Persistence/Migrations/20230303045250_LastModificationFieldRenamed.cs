using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class LastModificationFieldRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Users",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "UserPermissions",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "RolePermission",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Permission",
                newName: "LastModification");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Email",
                newName: "LastModification");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Users",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "UserPermissions",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "RolePermission",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Permission",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModification",
                table: "Email",
                newName: "DateModified");
        }
    }
}
