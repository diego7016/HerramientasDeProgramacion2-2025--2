using ClinicaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApp.Infrastructure.Persistence
{
    public class ClinicaDbContext : DbContext
    {
        // 🔹 Constructor sin parámetros: usado por las migraciones en tiempo de diseño
        public ClinicaDbContext()
        {
        }

        // 🔹 Constructor con options: por si luego usas DI o lo creas manualmente
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options)
            : base(options)
        {
        }



        // ===================== DbSet =====================

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        // Órdenes y sus ítems (tablas que el profesor quiere en SQL)
        public DbSet<OrdenMedica> Ordenes { get; set; }                 // Clase que ya teníamos
        public DbSet<OrdenMedicamentoItem> OrdenMedicamentos { get; set; }
        public DbSet<OrdenProcedimientoItem> OrdenProcedimientos { get; set; }
        public DbSet<OrdenAyudaDiagnosticaItem> OrdenAyudasDiagnosticas { get; set; } // si ya la tienes

        // Inventario
        public DbSet<Medicamento> Medicamentos { get; set; }            // si ya tienes esta clase
        public DbSet<Procedimiento> Procedimientos { get; set; }
        public DbSet<AyudaDiagnostica> AyudasDiagnosticas { get; set; }

        // Facturación
        public DbSet<Factura> Facturas { get; set; }                    // si ya tienes esta clase
        public DbSet<DetalleFacturaItem> DetalleFacturaItems { get; set; }
        public DbSet<HistoriaClinicaEntrada> HistoriasClinicas { get; set; }
        public DbSet<RegistroEnfermeria> RegistrosEnfermeria { get; set; }
        public DbSet<SignosVitales> SignosVitales { get; set; }
        public DbSet<ContactoEmergencia> ContactosEmergencia { get; set; }
        public DbSet<PolizaSeguro> PolizasSeguro { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }


        // ===================== FLUENT API =====================

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== USUARIO =====
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuarios");

                // Cédula como PK
                entity.HasKey(u => u.Cedula);

                entity.Property(u => u.Cedula)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(u => u.NombreCompleto)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(u => u.Email)
                      .HasMaxLength(100);

                entity.Property(u => u.Telefono)
                      .HasMaxLength(10);

                entity.Property(u => u.Direccion)
                      .HasMaxLength(30);

                entity.Property(u => u.NombreUsuario)
                      .HasMaxLength(15)
                      .IsRequired();

                entity.HasIndex(u => u.NombreUsuario)
                      .IsUnique();

                entity.Property(u => u.Contrasena)
                      .HasMaxLength(200) // por si después usas hash
                      .IsRequired();
            });

            // ===== PACIENTE =====
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.ToTable("Pacientes");

                entity.HasKey(p => p.Cedula);

                entity.Property(p => p.Cedula)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(p => p.NombreCompleto)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.Direccion)
                      .HasMaxLength(100);

                entity.Property(p => p.Telefono)
                      .HasMaxLength(10);

                entity.Property(p => p.Email)
                      .HasMaxLength(100);

                // Si luego quieres mapear ContactoEmergencia y PolizaSeguro
                // como tipos propios u otras tablas, se hace aquí.
            });

            // ===== ORDEN PRINCIPAL (TABLA: Orden) =====
            modelBuilder.Entity<OrdenMedica>(entity =>
            {
                entity.ToTable("Orden");

                entity.HasKey(o => o.NumeroOrden);

                entity.Property(o => o.NumeroOrden)
                      .ValueGeneratedNever(); // tú asignas el número (máx 6 dígitos)

                entity.Property(o => o.CedulaPaciente)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(o => o.CedulaMedico)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(o => o.FechaCreacion)
                      .HasColumnType("date");
            });

            // ===== ORDEN MEDICAMENTOS (TABLA: OrdenMedicamentos) =====
            modelBuilder.Entity<OrdenMedicamentoItem>(entity =>
            {
                entity.ToTable("OrdenMedicamentos");

                // PK compuesta: NumeroOrden + Item
                entity.HasKey(m => new { m.NumeroOrden, m.Item });

                entity.Property(m => m.NumeroOrden)
                      .HasColumnType("int");

                entity.Property(m => m.Item)
                      .HasColumnType("int");

                entity.Property(m => m.IdMedicamento)
                      .HasMaxLength(50);

                entity.Property(m => m.NombreMedicamento)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(m => m.Dosis)
                      .HasMaxLength(50);

                entity.Property(m => m.DuracionTratamiento)
                      .HasMaxLength(50);

                entity.Property(m => m.Costo)
                      .HasColumnType("decimal(18,2)");

                // FK hacia Orden (sin necesidad de propiedad de navegación)
                entity.HasOne<OrdenMedica>()
                      .WithMany()
                      .HasForeignKey(m => m.NumeroOrden)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ===== ORDEN PROCEDIMIENTOS (TABLA: OrdenProcedimientos) =====
            modelBuilder.Entity<OrdenProcedimientoItem>(entity =>
            {
                entity.ToTable("OrdenProcedimientos");

                entity.HasKey(p => new { p.NumeroOrden, p.Item });

                entity.Property(p => p.NumeroOrden)
                      .HasColumnType("int");

                entity.Property(p => p.Item)
                      .HasColumnType("int");

                entity.Property(p => p.IdProcedimiento)
                      .HasMaxLength(50);

                entity.Property(p => p.NombreProcedimiento)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.Frecuencia)
                      .HasMaxLength(50);

                entity.Property(p => p.IdTipoEspecialista)
                      .HasMaxLength(50);

                entity.Property(p => p.Costo)
                      .HasColumnType("decimal(18,2)");

                entity.HasOne<OrdenMedica>()
                      .WithMany()
                      .HasForeignKey(p => p.NumeroOrden)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ===== ORDEN AYUDA DIAGNÓSTICA (TABLA: OrdenAyudaDiagnostica) =====
            // Solo si ya tienes la clase OrdenAyudaDiagnosticaItem en ClinicaApp.Domain
            modelBuilder.Entity<OrdenAyudaDiagnosticaItem>(entity =>
            {
                entity.ToTable("OrdenAyudaDiagnostica");

                entity.HasKey(a => new { a.NumeroOrden, a.Item });

                entity.Property(a => a.NumeroOrden)
                      .HasColumnType("int");

                entity.Property(a => a.Item)
                      .HasColumnType("int");

                entity.Property(a => a.IdAyudaDiagnostica)
                      .HasMaxLength(50);

                entity.Property(a => a.NombreAyudaDiagnostica)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(a => a.IdTipoEspecialista)
                      .HasMaxLength(50);

                entity.Property(a => a.Costo)
                      .HasColumnType("decimal(18,2)");

                entity.HasOne<OrdenMedica>()
                      .WithMany()
                      .HasForeignKey(a => a.NumeroOrden)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ===== INVENTARIO: AYUDA DIAGNÓSTICA (TABLA: AyudasDiagnosticas) =====
            modelBuilder.Entity<AyudaDiagnostica>(entity =>
            {
                entity.ToTable("AyudasDiagnosticas");

                entity.HasKey(a => a.Id);

                entity.Property(a => a.Id)
                      .HasMaxLength(50);

                entity.Property(a => a.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(a => a.IdTipoEspecialista)
                      .HasMaxLength(50);

                entity.Property(a => a.Costo)
                      .HasColumnType("decimal(18,2)");
            });

            // Si también tienes Medicamento y Procedimiento como inventario:
            modelBuilder.Entity<Medicamento>(entity =>
            {
                entity.ToTable("Medicamentos");

                entity.HasKey(m => m.Id);

                entity.Property(m => m.Id)
                      .HasMaxLength(50);

                entity.Property(m => m.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(m => m.Presentacion)
                      .HasMaxLength(100);

                entity.Property(m => m.Costo)
                      .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Procedimiento>(entity =>
            {
                entity.ToTable("Procedimientos");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                      .HasMaxLength(50);

                entity.Property(p => p.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.IdTipoEspecialista)
                      .HasMaxLength(50);

                entity.Property(p => p.Costo)
                      .HasColumnType("decimal(18,2)");
            });

            // ===== FACTURA =====
            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("Facturas");

                entity.HasKey(f => f.NumeroFactura);

                entity.Property(f => f.NumeroFactura)
                      .HasMaxLength(20);

                entity.Property(f => f.CedulaPaciente)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(f => f.NombrePaciente)
                      .HasMaxLength(100);

                entity.Property(f => f.NombreMedicoTratante)
                      .HasMaxLength(100);

                entity.Property(f => f.NombreCompaniaSeguro)
                      .HasMaxLength(100);

                entity.Property(f => f.NumeroPoliza)
                      .HasMaxLength(50);

                entity.Property(f => f.TotalServicios)
                      .HasColumnType("decimal(18,2)");

                entity.Property(f => f.CopagoPaciente)
                      .HasColumnType("decimal(18,2)");

                entity.Property(f => f.TotalCubreAseguradora)
                      .HasColumnType("decimal(18,2)");
            });

            // ===== DETALLE FACTURA =====
            modelBuilder.Entity<DetalleFacturaItem>(entity =>
            {
                entity.ToTable("DetalleFactura");

                // Como tu modelo NO tiene Id, usamos PK compuesta
                entity.HasKey(d => new { d.Tipo, d.NumeroOrden, d.ItemOrden });

                entity.Property(d => d.Tipo)
                      .HasMaxLength(30)
                      .IsRequired();

                entity.Property(d => d.Descripcion)
                      .HasMaxLength(300);

                entity.Property(d => d.Costo)
                      .HasColumnType("decimal(18,2)");
            });

            // ===================== HISTORIA CLINICA =====================
            modelBuilder.Entity<HistoriaClinicaEntrada>(entity =>
            {
                entity.ToTable("HistoriaClinica");

                entity.HasKey(h => h.Id);

                entity.Property(h => h.Id)
                      .ValueGeneratedNever();

                // Ajusta según tus propiedades reales:
                entity.Property(h => h.CedulaPaciente)
                      .HasMaxLength(20);

                entity.Property(h => h.Diagnostico)
                      .HasMaxLength(500);
            });

            // ===================== REGISTRO ENFERMERÍA =====================
            modelBuilder.Entity<RegistroEnfermeria>(entity =>
            {
                entity.ToTable("RegistroEnfermeria");

                entity.HasKey(r => r.Id);

                entity.Property(r => r.Id)
                      .ValueGeneratedNever();

                entity.Property(r => r.CedulaPaciente)
                      .HasMaxLength(20);

                entity.Property(r => r.Observaciones)
                      .HasMaxLength(300);
            });

            // ===================== SIGNOS VITALES =====================
            modelBuilder.Entity<SignosVitales>(entity =>
            {
                entity.ToTable("SignosVitales");

                entity.HasKey(s => s.Id);

                entity.Property(s => s.Id)
                      .ValueGeneratedNever();

                entity.Property(s => s.Temperatura)
                      .HasColumnType("decimal(5,2)");

                entity.Property(s => s.Pulso)
                      .HasColumnType("int");

                entity.Property(s => s.SpO2)
                      .HasColumnType("int");

                entity.Property(s => s.PresionArterial)
                      .HasMaxLength(20);
            });

            // ===================== CONTACTO EMERGENCIA =====================
            modelBuilder.Entity<ContactoEmergencia>(entity =>
            {
                entity.ToTable("ContactosEmergencia");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.Id)
                      .ValueGeneratedNever();

                entity.Property(c => c.NombreCompleto)
                      .HasMaxLength(100);

                entity.Property(c => c.Telefono)
                      .HasMaxLength(20);

                entity.Property(c => c.Relacion)
                      .HasMaxLength(50);
            });

            // ===================== POLIZA SEGURO =====================
            modelBuilder.Entity<PolizaSeguro>(entity =>
            {
                entity.ToTable("PolizasSeguro");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Id)
                      .ValueGeneratedNever();

                entity.Property(p => p.CompaniaSeguros)
                      .HasMaxLength(100);

                entity.Property(p => p.NumeroPoliza)
                      .HasMaxLength(50);
            });

            // ===================== ESPECIALIDADES =====================
            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidades");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                      .HasMaxLength(50)
                      .IsRequired();
            });
        }

        
         
        // 🔹 Aquí EF configurará la conexión tanto en tiempo de diseño como en tiempo de ejecución
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=Diego\\SQLEXPRESS;Database=Mi_BdClinica;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
