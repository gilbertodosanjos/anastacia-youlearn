using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YouLearn.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimeiroNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Canal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrlLogo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Canal_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayList_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CanalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrdemNaPlayList = table.Column<int>(type: "int", nullable: false),
                    IdVideoYoutube = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UsuarioSugeriuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Canal_CanalId",
                        column: x => x.CanalId,
                        principalTable: "Canal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Video_PlayList_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "PlayList",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Video_Usuario_UsuarioSugeriuId",
                        column: x => x.UsuarioSugeriuId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onUpdate: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canal_UsuarioId",
                table: "Canal",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayList_UsuarioId",
                table: "PlayList",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CanalId",
                table: "Video",
                column: "CanalId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_PlayListId",
                table: "Video",
                column: "PlayListId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_UsuarioSugeriuId",
                table: "Video",
                column: "UsuarioSugeriuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Canal");

            migrationBuilder.DropTable(
                name: "PlayList");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
