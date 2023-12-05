using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carwash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatebouns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEK9x9+ISdWBk8FLbeVdw4JsLUlDsZpdipLXilK/lT4KD1zKrjjRx13n2bB42d7PMoA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHJ5kz5iYLKnEGnZY+mjE7sJjbFmLuXMi6BnxWlnCB86mRsw4b6rIOADD9rw+2lCwQ==");
        }
    }
}
