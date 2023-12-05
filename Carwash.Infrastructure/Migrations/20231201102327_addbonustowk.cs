using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carwash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addbonustowk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "Workers");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Workers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Workers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Bonus",
                table: "WorkerInKhadamats",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHJ5kz5iYLKnEGnZY+mjE7sJjbFmLuXMi6BnxWlnCB86mRsw4b6rIOADD9rw+2lCwQ==");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Salary",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Salary",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Salary",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "WorkerInKhadamats");

            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Workers",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bonus",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPhnod29xadVwvDLMRYfn0uULnVuws+bKB2yutfqgnmCBGwVeC0qUhHq6QcK547zPw==");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bonus", "Salary" },
                values: new object[] { 0, 0 });
        }
    }
}
