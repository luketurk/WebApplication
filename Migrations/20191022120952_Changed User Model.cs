using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBAPPLICATION.Migrations
{
    public partial class ChangedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(250)",
                table: "Users",
                newName: "UserRole");

            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserRole",
                table: "Users",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRole",
                table: "Users",
                newName: "varchar(250)");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "nvarchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(250)",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");
        }
    }
}
