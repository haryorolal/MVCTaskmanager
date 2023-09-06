using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTaskmanager.Migrations
{
    /// <inheritdoc />
    public partial class Task : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheTasks",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    TaskCreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskPriorityID = table.Column<int>(type: "int", nullable: false),
                    LastUpdateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskCurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskCurrentStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheTasks", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_TheTasks_AspNetUsers_AssignedTo",
                        column: x => x.AssignedTo,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TheTasks_AspNetUsers_TaskCreatedBy",
                        column: x => x.TaskCreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TheTasks_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TheTasks_TaskPriorities_TaskPriorityID",
                        column: x => x.TaskPriorityID,
                        principalTable: "TaskPriorities",
                        principalColumn: "TaskPriorityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatusDetails",
                columns: table => new
                {
                    TaskStatusDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    TaskStatusID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskStatus = table.Column<int>(type: "int", nullable: false),
                    TheTaskTaskID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatusDetails", x => x.TaskStatusDetailID);
                    table.ForeignKey(
                        name: "FK_TaskStatusDetails_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskStatusDetails_TheTasks_TheTaskTaskID",
                        column: x => x.TheTaskTaskID,
                        principalTable: "TheTasks",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatusDetails_TheTaskTaskID",
                table: "TaskStatusDetails",
                column: "TheTaskTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatusDetails_UserID",
                table: "TaskStatusDetails",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TheTasks_AssignedTo",
                table: "TheTasks",
                column: "AssignedTo");

            migrationBuilder.CreateIndex(
                name: "IX_TheTasks_ProjectID",
                table: "TheTasks",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TheTasks_TaskCreatedBy",
                table: "TheTasks",
                column: "TaskCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TheTasks_TaskPriorityID",
                table: "TheTasks",
                column: "TaskPriorityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskStatusDetails");

            migrationBuilder.DropTable(
                name: "TheTasks");
        }
    }
}
