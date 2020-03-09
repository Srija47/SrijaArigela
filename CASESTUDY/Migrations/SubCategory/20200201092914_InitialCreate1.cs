using Microsoft.EntityFrameworkCore.Migrations;

namespace CASESTUDY.Migrations.SubCategory
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(nullable: true),
                    Brief_Details1 = table.Column<string>(nullable: true),
                    Subcategory_id = table.Column<int>(nullable: false),
                    Subcategory_name = table.Column<string>(nullable: true),
                    Brief_details2 = table.Column<string>(nullable: true),
                    GST_Percentage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Category_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
