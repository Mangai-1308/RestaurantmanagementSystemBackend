using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantmanagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateRestaurantTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    restaurant_name = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    type_of_food = table.Column<string>(type: "TEXT", nullable: true),
                    type_of_cusine = table.Column<string>(type: "TEXT", nullable: true),
                    image = table.Column<string>(type: "TEXT", nullable: true),
                    url = table.Column<string>(type: "TEXT", nullable: true),
                    rating = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
