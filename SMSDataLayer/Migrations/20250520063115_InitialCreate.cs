using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Users_UserId",
                table: "Faculties");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Faculties",
                newName: "CoordinatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Faculties_UserId",
                table: "Faculties",
                newName: "IX_Faculties_CoordinatorId");

            migrationBuilder.CreateTable(
                name: "Coordinator",
                columns: table => new
                {
                    CoordinatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinator", x => x.CoordinatorId);
                    table.ForeignKey(
                        name: "FK_Coordinator_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_UserId",
                table: "Coordinator",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Coordinator_CoordinatorId",
                table: "Faculties",
                column: "CoordinatorId",
                principalTable: "Coordinator",
                principalColumn: "CoordinatorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Coordinator_CoordinatorId",
                table: "Faculties");

            migrationBuilder.DropTable(
                name: "Coordinator");

            migrationBuilder.RenameColumn(
                name: "CoordinatorId",
                table: "Faculties",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Faculties_CoordinatorId",
                table: "Faculties",
                newName: "IX_Faculties_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Users_UserId",
                table: "Faculties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
