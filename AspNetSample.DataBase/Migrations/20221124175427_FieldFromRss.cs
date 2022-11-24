using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetSample.DataBase.Migrations
{
    public partial class FieldFromRss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullText",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Articles",
                newName: "SourceUrl");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Articles",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortSummary",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ShortSummary",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "SourceUrl",
                table: "Articles",
                newName: "ShortDescription");

            migrationBuilder.AddColumn<string>(
                name: "FullText",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
