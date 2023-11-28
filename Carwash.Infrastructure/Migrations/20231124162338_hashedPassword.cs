using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carwash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hashedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPhnod29xadVwvDLMRYfn0uULnVuws+bKB2yutfqgnmCBGwVeC0qUhHq6QcK547zPw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "12345");
        }
    }
}
