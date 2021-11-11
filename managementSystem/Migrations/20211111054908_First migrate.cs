using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace managementSystem.Migrations
{
    public partial class Firstmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    surName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    idCard = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    department = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
