using Microsoft.EntityFrameworkCore.Migrations;

namespace B_E_Task17.Migrations
{
    public partial class ContactsTypeAddIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "ContactsTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "ContactsTypes");
        }
    }
}
