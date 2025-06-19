using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaTurismo.Migrations
{
    /// <inheritdoc />
    public partial class AddDeletedAtToPacoteTuristico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Pacotes_PacoteTuristicoId",
                table: "Cidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Paises_PaisDestinoId",
                table: "Cidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades");

            migrationBuilder.RenameTable(
                name: "Cidades",
                newName: "CidadeDestino");

            migrationBuilder.RenameIndex(
                name: "IX_Cidades_PaisDestinoId",
                table: "CidadeDestino",
                newName: "IX_CidadeDestino_PaisDestinoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cidades_PacoteTuristicoId",
                table: "CidadeDestino",
                newName: "IX_CidadeDestino_PacoteTuristicoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paises",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Pacotes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CidadeDestino",
                table: "CidadeDestino",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CidadeDestino_Pacotes_PacoteTuristicoId",
                table: "CidadeDestino",
                column: "PacoteTuristicoId",
                principalTable: "Pacotes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CidadeDestino_Paises_PaisDestinoId",
                table: "CidadeDestino",
                column: "PaisDestinoId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CidadeDestino_Pacotes_PacoteTuristicoId",
                table: "CidadeDestino");

            migrationBuilder.DropForeignKey(
                name: "FK_CidadeDestino_Paises_PaisDestinoId",
                table: "CidadeDestino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CidadeDestino",
                table: "CidadeDestino");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Pacotes");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "CidadeDestino",
                newName: "Cidades");

            migrationBuilder.RenameIndex(
                name: "IX_CidadeDestino_PaisDestinoId",
                table: "Cidades",
                newName: "IX_Cidades_PaisDestinoId");

            migrationBuilder.RenameIndex(
                name: "IX_CidadeDestino_PacoteTuristicoId",
                table: "Cidades",
                newName: "IX_Cidades_PacoteTuristicoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paises",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Pacotes_PacoteTuristicoId",
                table: "Cidades",
                column: "PacoteTuristicoId",
                principalTable: "Pacotes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Paises_PaisDestinoId",
                table: "Cidades",
                column: "PaisDestinoId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
