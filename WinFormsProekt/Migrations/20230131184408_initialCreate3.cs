using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsProekt.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Otvet",
                table: "Zayavki",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zapros",
                table: "Zayavki",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Otvet",
                table: "Zayavki");

            migrationBuilder.DropColumn(
                name: "Zapros",
                table: "Zayavki");
        }
    }
}
