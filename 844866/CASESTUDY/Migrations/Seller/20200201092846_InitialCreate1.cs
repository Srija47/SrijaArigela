using Microsoft.EntityFrameworkCore.Migrations;

namespace CASESTUDY.Migrations.Seller
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 10, nullable: false),
                    ContactNumber = table.Column<long>(nullable: false),
                    Brief_abt_Company = table.Column<string>(nullable: false),
                    Postal_Address = table.Column<string>(nullable: false),
                    GSTIN = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    Photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
