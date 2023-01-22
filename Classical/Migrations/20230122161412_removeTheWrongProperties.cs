using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classical.Migrations
{
    /// <inheritdoc />
    public partial class removeTheWrongProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mass",
                table: "Element");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Element");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Mass",
                table: "Element",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "Element",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
