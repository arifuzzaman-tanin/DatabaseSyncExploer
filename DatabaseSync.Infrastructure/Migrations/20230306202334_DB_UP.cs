using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSync.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DB_UP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mt4Users",
                columns: table => new
                {
                    Login = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mt4Users", x => x.Login);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mt4Users");
        }
    }
}
