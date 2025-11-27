using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AyudasDiagnosticas",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequiereEspecialista = table.Column<bool>(nullable: false),
                    IdTipoEspecialista = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AyudasDiagnosticas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactosEmergencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NombreCompleto = table.Column<string>(maxLength: 100, nullable: true),
                    Relacion = table.Column<string>(maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactosEmergencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    NumeroFactura = table.Column<string>(maxLength: 20, nullable: false),
                    CedulaPaciente = table.Column<string>(maxLength: 20, nullable: false),
                    NombrePaciente = table.Column<string>(maxLength: 100, nullable: true),
                    EdadPaciente = table.Column<int>(nullable: false),
                    NombreMedicoTratante = table.Column<string>(maxLength: 100, nullable: true),
                    NombreCompaniaSeguro = table.Column<string>(maxLength: 100, nullable: true),
                    NumeroPoliza = table.Column<string>(maxLength: 50, nullable: true),
                    FechaFinPoliza = table.Column<DateTime>(nullable: true),
                    PolizaActiva = table.Column<bool>(nullable: false),
                    DiasVigenciaPoliza = table.Column<int>(nullable: false),
                    TotalServicios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CopagoPaciente = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCubreAseguradora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaFactura = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.NumeroFactura);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CedulaPaciente = table.Column<string>(maxLength: 20, nullable: true),
                    FechaAtencion = table.Column<DateTime>(nullable: false),
                    CedulaMedico = table.Column<string>(nullable: true),
                    MotivoConsulta = table.Column<string>(nullable: true),
                    Sintomatologia = table.Column<string>(nullable: true),
                    Diagnostico = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Presentacion = table.Column<string>(maxLength: 100, nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    NumeroOrden = table.Column<int>(nullable: false),
                    CedulaPaciente = table.Column<string>(maxLength: 20, nullable: false),
                    CedulaMedico = table.Column<string>(maxLength: 20, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.NumeroOrden);
                });

            migrationBuilder.CreateTable(
                name: "PolizasSeguro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CompaniaSeguros = table.Column<string>(maxLength: 100, nullable: true),
                    NumeroPoliza = table.Column<string>(maxLength: 50, nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaVigenciaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolizasSeguro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedimientos",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequiereEspecialista = table.Column<bool>(nullable: false),
                    IdTipoEspecialista = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PresionArterial = table.Column<string>(maxLength: 20, nullable: true),
                    Temperatura = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Pulso = table.Column<int>(type: "int", nullable: false),
                    SpO2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Cedula = table.Column<string>(maxLength: 20, nullable: false),
                    NombreCompleto = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(maxLength: 10, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 30, nullable: true),
                    Rol = table.Column<int>(nullable: false),
                    NombreUsuario = table.Column<string>(maxLength: 15, nullable: false),
                    Contrasena = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    Tipo = table.Column<string>(maxLength: 30, nullable: false),
                    NumeroOrden = table.Column<int>(nullable: false),
                    ItemOrden = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 300, nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FacturaNumeroFactura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFactura", x => new { x.Tipo, x.NumeroOrden, x.ItemOrden });
                    table.ForeignKey(
                        name: "FK_DetalleFactura_Facturas_FacturaNumeroFactura",
                        column: x => x.FacturaNumeroFactura,
                        principalTable: "Facturas",
                        principalColumn: "NumeroFactura",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenAyudaDiagnostica",
                columns: table => new
                {
                    NumeroOrden = table.Column<int>(type: "int", nullable: false),
                    Item = table.Column<int>(type: "int", nullable: false),
                    IdAyudaDiagnostica = table.Column<string>(maxLength: 50, nullable: true),
                    NombreAyudaDiagnostica = table.Column<string>(maxLength: 100, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    RequiereEspecialista = table.Column<bool>(nullable: false),
                    IdTipoEspecialista = table.Column<string>(maxLength: 50, nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdenMedicaNumeroOrden = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenAyudaDiagnostica", x => new { x.NumeroOrden, x.Item });
                    table.ForeignKey(
                        name: "FK_OrdenAyudaDiagnostica_Orden_NumeroOrden",
                        column: x => x.NumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenAyudaDiagnostica_Orden_OrdenMedicaNumeroOrden",
                        column: x => x.OrdenMedicaNumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenMedicamentos",
                columns: table => new
                {
                    NumeroOrden = table.Column<int>(type: "int", nullable: false),
                    Item = table.Column<int>(type: "int", nullable: false),
                    IdMedicamento = table.Column<string>(maxLength: 50, nullable: true),
                    NombreMedicamento = table.Column<string>(maxLength: 100, nullable: false),
                    Dosis = table.Column<string>(maxLength: 50, nullable: true),
                    DuracionTratamiento = table.Column<string>(maxLength: 50, nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdenMedicaNumeroOrden = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenMedicamentos", x => new { x.NumeroOrden, x.Item });
                    table.ForeignKey(
                        name: "FK_OrdenMedicamentos_Orden_NumeroOrden",
                        column: x => x.NumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenMedicamentos_Orden_OrdenMedicaNumeroOrden",
                        column: x => x.OrdenMedicaNumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenProcedimientos",
                columns: table => new
                {
                    NumeroOrden = table.Column<int>(type: "int", nullable: false),
                    Item = table.Column<int>(type: "int", nullable: false),
                    IdProcedimiento = table.Column<string>(maxLength: 50, nullable: true),
                    NombreProcedimiento = table.Column<string>(maxLength: 100, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Frecuencia = table.Column<string>(maxLength: 50, nullable: true),
                    RequiereEspecialista = table.Column<bool>(nullable: false),
                    IdTipoEspecialista = table.Column<string>(maxLength: 50, nullable: true),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdenMedicaNumeroOrden = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenProcedimientos", x => new { x.NumeroOrden, x.Item });
                    table.ForeignKey(
                        name: "FK_OrdenProcedimientos_Orden_NumeroOrden",
                        column: x => x.NumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenProcedimientos_Orden_OrdenMedicaNumeroOrden",
                        column: x => x.OrdenMedicaNumeroOrden,
                        principalTable: "Orden",
                        principalColumn: "NumeroOrden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(maxLength: 20, nullable: false),
                    NombreCompleto = table.Column<string>(maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    ContactoEmergenciaId = table.Column<int>(nullable: true),
                    PolizaSeguroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Cedula);
                    table.ForeignKey(
                        name: "FK_Pacientes_ContactosEmergencia_ContactoEmergenciaId",
                        column: x => x.ContactoEmergenciaId,
                        principalTable: "ContactosEmergencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_PolizasSeguro_PolizaSeguroId",
                        column: x => x.PolizaSeguroId,
                        principalTable: "PolizasSeguro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroEnfermeria",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CedulaPaciente = table.Column<string>(maxLength: 20, nullable: true),
                    FechaHora = table.Column<DateTime>(nullable: false),
                    NumeroOrden = table.Column<int>(nullable: false),
                    ItemOrden = table.Column<int>(nullable: false),
                    TipoItem = table.Column<string>(nullable: true),
                    SignosId = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroEnfermeria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroEnfermeria_SignosVitales_SignosId",
                        column: x => x.SignosId,
                        principalTable: "SignosVitales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_FacturaNumeroFactura",
                table: "DetalleFactura",
                column: "FacturaNumeroFactura");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenAyudaDiagnostica_OrdenMedicaNumeroOrden",
                table: "OrdenAyudaDiagnostica",
                column: "OrdenMedicaNumeroOrden");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenMedicamentos_OrdenMedicaNumeroOrden",
                table: "OrdenMedicamentos",
                column: "OrdenMedicaNumeroOrden");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenProcedimientos_OrdenMedicaNumeroOrden",
                table: "OrdenProcedimientos",
                column: "OrdenMedicaNumeroOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ContactoEmergenciaId",
                table: "Pacientes",
                column: "ContactoEmergenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_PolizaSeguroId",
                table: "Pacientes",
                column: "PolizaSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroEnfermeria_SignosId",
                table: "RegistroEnfermeria",
                column: "SignosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NombreUsuario",
                table: "Usuarios",
                column: "NombreUsuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AyudasDiagnosticas");

            migrationBuilder.DropTable(
                name: "DetalleFactura");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "HistoriaClinica");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "OrdenAyudaDiagnostica");

            migrationBuilder.DropTable(
                name: "OrdenMedicamentos");

            migrationBuilder.DropTable(
                name: "OrdenProcedimientos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Procedimientos");

            migrationBuilder.DropTable(
                name: "RegistroEnfermeria");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "ContactosEmergencia");

            migrationBuilder.DropTable(
                name: "PolizasSeguro");

            migrationBuilder.DropTable(
                name: "SignosVitales");
        }
    }
}
