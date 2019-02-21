using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Persons",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Persons",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Persons",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Persons",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "PersonID");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Persons",
                maxLength: 12,
                nullable: false,
                defaultValue: 0);
        }
    }
}
