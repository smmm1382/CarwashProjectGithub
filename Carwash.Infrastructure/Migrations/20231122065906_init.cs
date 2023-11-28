using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Carwash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khadamats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khadamats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkerInKhadamat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    KhadamatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerInKhadamat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerInKhadamat_Khadamats_KhadamatId",
                        column: x => x.KhadamatId,
                        principalTable: "Khadamats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerInKhadamat_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pride" },
                    { 2, "Dena" },
                    { 3, "Arrizo" },
                    { 4, "Persia" },
                    { 5, "Peugeot405" },
                    { 6, "SurenPlus" },
                    { 7, "Samand" },
                    { 8, "Santafa" }
                });

            migrationBuilder.InsertData(
                table: "Khadamats",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Roshoee", 60000m },
                    { 2, "Broom", 40000m },
                    { 3, "Wax", 50000m }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Email", "FirstName", "ImageFile", "LastName", "Password" },
                values: new object[] { 1, "mousavi@gmail.com", "mahdi", null, "mousavi", "12345" });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Age", "Bonus", "FirstName", "ImageFile", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, 20, 0, "mahdi", null, "mousavi", 0 },
                    { 2, 55, 0, "emaeil", null, "akbary", 0 },
                    { 3, 17, 0, "amirhosein", null, "Khodabandelo", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInKhadamat_KhadamatId",
                table: "WorkerInKhadamat",
                column: "KhadamatId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInKhadamat_WorkerId",
                table: "WorkerInKhadamat",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "WorkerInKhadamat");

            migrationBuilder.DropTable(
                name: "Khadamats");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
