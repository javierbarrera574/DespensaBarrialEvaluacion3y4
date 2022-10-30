using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Despensa.BD.Migrations
{
    public partial class Campos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Productos_NombreProducto",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Proveedores",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreProducto",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "FechaVencimiento",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepositoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadMinima",
                table: "Depositos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_AdministradorId",
                table: "Proveedores",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                unique: true,
                filter: "[CategoriaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_DepositoId",
                table: "Productos",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Depositos_DepositoId",
                table: "Productos",
                column: "DepositoId",
                principalTable: "Depositos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Proveedores_ProveedorId",
                table: "Productos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Administradores_AdministradorId",
                table: "Proveedores",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Depositos_DepositoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Proveedores_ProveedorId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Administradores_AdministradorId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_AdministradorId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DepositoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DepositoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UnidadMinima",
                table: "Depositos");

            migrationBuilder.AlterColumn<string>(
                name: "NombreProducto",
                table: "Productos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FechaVencimiento",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_NombreProducto",
                table: "Productos",
                column: "NombreProducto",
                unique: true);
        }
    }
}
