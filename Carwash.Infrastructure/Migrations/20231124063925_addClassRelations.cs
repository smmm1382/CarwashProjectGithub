using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carwash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addClassRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerInHistory_History_HistoryId",
                table: "ManagerInHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagerInHistory_Managers_ManagerId",
                table: "ManagerInHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInHistory_History_HistoryId",
                table: "WorkerInHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInHistory_Workers_WorkerId",
                table: "WorkerInHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInKhadamat_Khadamats_KhadamatId",
                table: "WorkerInKhadamat");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInKhadamat_Workers_WorkerId",
                table: "WorkerInKhadamat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerInKhadamat",
                table: "WorkerInKhadamat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerInHistory",
                table: "WorkerInHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManagerInHistory",
                table: "ManagerInHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_History",
                table: "History");

            migrationBuilder.RenameTable(
                name: "WorkerInKhadamat",
                newName: "WorkerInKhadamats");

            migrationBuilder.RenameTable(
                name: "WorkerInHistory",
                newName: "WorkerInHistories");

            migrationBuilder.RenameTable(
                name: "ManagerInHistory",
                newName: "ManagerInHistories");

            migrationBuilder.RenameTable(
                name: "History",
                newName: "Histories");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInKhadamat_WorkerId",
                table: "WorkerInKhadamats",
                newName: "IX_WorkerInKhadamats_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInKhadamat_KhadamatId",
                table: "WorkerInKhadamats",
                newName: "IX_WorkerInKhadamats_KhadamatId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInHistory_WorkerId",
                table: "WorkerInHistories",
                newName: "IX_WorkerInHistories_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInHistory_HistoryId",
                table: "WorkerInHistories",
                newName: "IX_WorkerInHistories_HistoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerInHistory_ManagerId",
                table: "ManagerInHistories",
                newName: "IX_ManagerInHistories_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerInHistory_HistoryId",
                table: "ManagerInHistories",
                newName: "IX_ManagerInHistories_HistoryId");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerInKhadamats",
                table: "WorkerInKhadamats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerInHistories",
                table: "WorkerInHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManagerInHistories",
                table: "ManagerInHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Histories",
                table: "Histories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNumber",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerInHistories_Histories_HistoryId",
                table: "ManagerInHistories",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerInHistories_Managers_ManagerId",
                table: "ManagerInHistories",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInHistories_Histories_HistoryId",
                table: "WorkerInHistories",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInHistories_Workers_WorkerId",
                table: "WorkerInHistories",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInKhadamats_Khadamats_KhadamatId",
                table: "WorkerInKhadamats",
                column: "KhadamatId",
                principalTable: "Khadamats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInKhadamats_Workers_WorkerId",
                table: "WorkerInKhadamats",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerInHistories_Histories_HistoryId",
                table: "ManagerInHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagerInHistories_Managers_ManagerId",
                table: "ManagerInHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInHistories_Histories_HistoryId",
                table: "WorkerInHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInHistories_Workers_WorkerId",
                table: "WorkerInHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInKhadamats_Khadamats_KhadamatId",
                table: "WorkerInKhadamats");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerInKhadamats_Workers_WorkerId",
                table: "WorkerInKhadamats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerInKhadamats",
                table: "WorkerInKhadamats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerInHistories",
                table: "WorkerInHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManagerInHistories",
                table: "ManagerInHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Histories",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "WorkerInKhadamats",
                newName: "WorkerInKhadamat");

            migrationBuilder.RenameTable(
                name: "WorkerInHistories",
                newName: "WorkerInHistory");

            migrationBuilder.RenameTable(
                name: "ManagerInHistories",
                newName: "ManagerInHistory");

            migrationBuilder.RenameTable(
                name: "Histories",
                newName: "History");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInKhadamats_WorkerId",
                table: "WorkerInKhadamat",
                newName: "IX_WorkerInKhadamat_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInKhadamats_KhadamatId",
                table: "WorkerInKhadamat",
                newName: "IX_WorkerInKhadamat_KhadamatId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInHistories_WorkerId",
                table: "WorkerInHistory",
                newName: "IX_WorkerInHistory_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkerInHistories_HistoryId",
                table: "WorkerInHistory",
                newName: "IX_WorkerInHistory_HistoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerInHistories_ManagerId",
                table: "ManagerInHistory",
                newName: "IX_ManagerInHistory_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerInHistories_HistoryId",
                table: "ManagerInHistory",
                newName: "IX_ManagerInHistory_HistoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerInKhadamat",
                table: "WorkerInKhadamat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerInHistory",
                table: "WorkerInHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManagerInHistory",
                table: "ManagerInHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_History",
                table: "History",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerInHistory_History_HistoryId",
                table: "ManagerInHistory",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerInHistory_Managers_ManagerId",
                table: "ManagerInHistory",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInHistory_History_HistoryId",
                table: "WorkerInHistory",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInHistory_Workers_WorkerId",
                table: "WorkerInHistory",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInKhadamat_Khadamats_KhadamatId",
                table: "WorkerInKhadamat",
                column: "KhadamatId",
                principalTable: "Khadamats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerInKhadamat_Workers_WorkerId",
                table: "WorkerInKhadamat",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
