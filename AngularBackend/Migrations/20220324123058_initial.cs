using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularBackend.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBCreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Holder = table.Column<string>(type: "varchar(16)", nullable: false),
                    NoCard = table.Column<string>(type: "varchar(16)", nullable: false),
                    ExpiredDate = table.Column<string>(type: "varchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBCreditCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBCreditCard");
        }
    }
}
