using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maintenance.Migrations
{
    /// <inheritdoc />
    public partial class AddMaintenanceRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_MaintenanceRequest_MaintenanceRequestId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_MaintenanceRequest_MaintenanceRequestId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceLog_MaintenanceRequest_MaintenanceRequestId",
                table: "MaintenanceLog");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRequest_Customers_CustomerId",
                table: "MaintenanceRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRequest_Equipment_EquipmentId",
                table: "MaintenanceRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceRequest",
                table: "MaintenanceRequest");

            migrationBuilder.RenameTable(
                name: "MaintenanceRequest",
                newName: "MaintenanceRequests");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceRequest_EquipmentId",
                table: "MaintenanceRequests",
                newName: "IX_MaintenanceRequests_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceRequest_CustomerId",
                table: "MaintenanceRequests",
                newName: "IX_MaintenanceRequests_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceRequests",
                table: "MaintenanceRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_MaintenanceRequests_MaintenanceRequestId",
                table: "Assignment",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_MaintenanceRequests_MaintenanceRequestId",
                table: "Invoice",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceLog_MaintenanceRequests_MaintenanceRequestId",
                table: "MaintenanceLog",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRequests_Customers_CustomerId",
                table: "MaintenanceRequests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRequests_Equipment_EquipmentId",
                table: "MaintenanceRequests",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_MaintenanceRequests_MaintenanceRequestId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_MaintenanceRequests_MaintenanceRequestId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceLog_MaintenanceRequests_MaintenanceRequestId",
                table: "MaintenanceLog");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRequests_Customers_CustomerId",
                table: "MaintenanceRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRequests_Equipment_EquipmentId",
                table: "MaintenanceRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintenanceRequests",
                table: "MaintenanceRequests");

            migrationBuilder.RenameTable(
                name: "MaintenanceRequests",
                newName: "MaintenanceRequest");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceRequests_EquipmentId",
                table: "MaintenanceRequest",
                newName: "IX_MaintenanceRequest_EquipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_MaintenanceRequests_CustomerId",
                table: "MaintenanceRequest",
                newName: "IX_MaintenanceRequest_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintenanceRequest",
                table: "MaintenanceRequest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_MaintenanceRequest_MaintenanceRequestId",
                table: "Assignment",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_MaintenanceRequest_MaintenanceRequestId",
                table: "Invoice",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceLog_MaintenanceRequest_MaintenanceRequestId",
                table: "MaintenanceLog",
                column: "MaintenanceRequestId",
                principalTable: "MaintenanceRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRequest_Customers_CustomerId",
                table: "MaintenanceRequest",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRequest_Equipment_EquipmentId",
                table: "MaintenanceRequest",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
