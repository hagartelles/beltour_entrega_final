using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace beltour.Migrations
{
    /// <inheritdoc />
    public partial class secondBeltour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contry",
                table: "Destinos",
                newName: "Country");

            migrationBuilder.AlterColumn<string>(
                name: "International",
                table: "Destinos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Destinos",
                newName: "Contry");

            migrationBuilder.AlterColumn<sbyte>(
                name: "International",
                table: "Destinos",
                type: "tinyint(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
