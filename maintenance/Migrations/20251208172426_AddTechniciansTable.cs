using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maintenance.Migrations
{
    /// <inheritdoc />
    public partial class AddTechniciansTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Technician_TechnicianId",
                table: "Assignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technician",
                table: "Technician");

            migrationBuilder.RenameTable(
                name: "Technician",
                newName: "Technicians");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Technicians_TechnicianId",
                table: "Assignment",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Technicians_TechnicianId",
                table: "Assignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians");

            migrationBuilder.RenameTable(
                name: "Technicians",
                newName: "Technician");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technician",
                table: "Technician",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Technician_TechnicianId",
                table: "Assignment",
                column: "TechnicianId",
                principalTable: "Technician",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
