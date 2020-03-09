using Microsoft.EntityFrameworkCore.Migrations;

namespace CASESTUDY.Migrations.Item
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(nullable: true),
                    Brief_Details1 = table.Column<string>(nullable: true),
                    Subcategory_id = table.Column<int>(nullable: false),
                    Subcategory_name = table.Column<string>(nullable: true),
                    Brief_details2 = table.Column<string>(nullable: true),
                    GST_Percentage = table.Column<float>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Item_Name = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Stock_Number = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Category_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
