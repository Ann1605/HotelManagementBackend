using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class CreateRoomsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hostels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    hostel_id = table.Column<int>(type: "INTEGER", nullable: false),
                    hostel_name = table.Column<string>(type: "TEXT", nullable: true),
                    hostel_description = table.Column<string>(type: "TEXT", nullable: true),
                    type_of_rooms = table.Column<string>(type: "TEXT", nullable: true),
                    type_of_food = table.Column<string>(type: "TEXT", nullable: true),
                    rate = table.Column<float>(type: "REAL", nullable: false),
                    heads_per_room = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hostels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hostels");
        }
    }
}
