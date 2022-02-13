using Microsoft.EntityFrameworkCore.Migrations;

namespace azurelinuxapp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "cost", "description" },
                values: new object[] { 1, "Python", 575.45000000000005, "this book covers information about core python and python db" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "cost", "description" },
                values: new object[] { 2, "Java", 575.45000000000005, "this book covers information about core java and jdbc" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "cost", "description" },
                values: new object[] { 3, "C#", 575.45000000000005, "this book covers information about core C# and some dotnet technologies" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
