using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coffee.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Black Coffee dapat membantu meningkatkan daya ingat.", "1.jpg", "Black Coffee", 40.000m },
                    { 2, "Latte sangat baik dalam mengelola diabetes tipe-2.", "2.jpg", "Coffee Latte", 50.000m },
                    { 3, "cappucino dapat membantu mengatasi kolesterol dan mencegah beberapa masalah yang berhubungan dengan jantung. ", "3.jpeg", "Coffee Cappucino", 60.000m },
                    { 4, "Coffee yang dapat membantu melawan depresi", "4.jpg", "Americano Coffee", 60.000m },
                    { 5, "Coffee yand dapat Mengurangi risiko stroke", "5.jpg", "Espresso Coffee", 54.000m },
                    { 6, " Coffee yang dapat merontokan lemak secara alami.", "6.jpg", "Mocha Coffee", 75.000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
