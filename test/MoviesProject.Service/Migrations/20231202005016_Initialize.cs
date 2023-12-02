﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieProject.Service.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table =>
                    new
                    {
                        Id = table
                            .Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Year = table.Column<int>(type: "int", nullable: false),
                        Runtime = table.Column<int>(type: "int", nullable: false),
                        Genres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Directors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Actors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Plot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Movies");
        }
    }
}
