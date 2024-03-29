﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bootcamps",
                columns: table => new
                {
                    KursId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bootcamps", x => x.KursId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciAd = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    Eposta = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciId);
                });

            migrationBuilder.CreateTable(
                name: "Kayitlar",
                columns: table => new
                {
                    KayıtId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciId = table.Column<int>(type: "INTEGER", nullable: false),
                    KursId = table.Column<int>(type: "INTEGER", nullable: false),
                    BootcampKursId = table.Column<int>(type: "INTEGER", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kayitlar", x => x.KayıtId);
                    table.ForeignKey(
                        name: "FK_Kayitlar_Bootcamps_BootcampKursId",
                        column: x => x.BootcampKursId,
                        principalTable: "Bootcamps",
                        principalColumn: "KursId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kayitlar_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kayitlar_BootcampKursId",
                table: "Kayitlar",
                column: "BootcampKursId");

            migrationBuilder.CreateIndex(
                name: "IX_Kayitlar_OgrenciId",
                table: "Kayitlar",
                column: "OgrenciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kayitlar");

            migrationBuilder.DropTable(
                name: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Ogrencis");
        }
    }
}
