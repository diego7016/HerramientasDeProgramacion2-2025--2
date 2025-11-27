using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp.Forms.Facturacion
{
    public partial class FrmFacturacion : Form
    {
        private readonly PacienteService _pacienteService;
        private readonly IOrdenRepository _ordenRepository;
        private readonly FacturacionService _facturacionService;

        private Paciente _pacienteActual;
        private List<OrdenMedica> _ordenesPaciente = new List<OrdenMedica>();
        private Factura _facturaActual;

        public FrmFacturacion(
            PacienteService pacienteService,
            IOrdenRepository ordenRepository,
            FacturacionService facturacionService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            _ordenRepository = ordenRepository;
            _facturacionService = facturacionService;
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            dtpFechaFactura.Value = DateTime.Today;

            // Configurar grilla de órdenes
            dgvOrdenes.AutoGenerateColumns = false;
            dgvOrdenes.Columns.Clear();

            var colSel = new DataGridViewCheckBoxColumn
            {
                Name = "Seleccionar",
                HeaderText = "Sel"
            };
            dgvOrdenes.Columns.Add(colSel);

            dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroOrden",
                HeaderText = "Nº Orden",
                DataPropertyName = "NumeroOrden"
            });

            dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaCreacion",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCreacion"
            });

            dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CedulaMedico",
                HeaderText = "Cédula médico",
                DataPropertyName = "CedulaMedico"
            });

            dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalOrden",
                HeaderText = "Total orden",
                DataPropertyName = "TotalOrden"
            });

            // Grilla detalle factura
            dgvDetalleFactura.AutoGenerateColumns = false;
            dgvDetalleFactura.Columns.Clear();

            dgvDetalleFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo"
            });

            dgvDetalleFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroOrden",
                HeaderText = "Nº Orden",
                DataPropertyName = "NumeroOrden"
            });

            dgvDetalleFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemOrden",
                HeaderText = "Ítem",
                DataPropertyName = "ItemOrden"
            });

            dgvDetalleFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion"
            });

            dgvDetalleFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Costo",
                HeaderText = "Costo",
                DataPropertyName = "Costo"
            });
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaPaciente.Text.Trim();
            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Ingrese la cédula del paciente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _pacienteActual = _pacienteService.ObtenerPacientePorCedula(cedula);

            if (_pacienteActual == null)
            {
                MessageBox.Show("No se encontró el paciente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos paciente
            lblNombrePaciente.Text = _pacienteActual.NombreCompleto;
            lblEdadPaciente.Text = _pacienteActual.CalcularEdad().ToString();

            // Datos póliza
            if (_pacienteActual.PolizaSeguro != null)
            {
                var p = _pacienteActual.PolizaSeguro;
                lblCompania.Text = p.CompaniaSeguros;
                lblNumeroPoliza.Text = p.NumeroPoliza;
                lblFechaFinPoliza.Text = p.FechaVigenciaFin.ToString("dd/MM/yyyy");

                bool activa = p.Estado == Domain.Enums.EstadoPoliza.Activa &&
                              p.FechaVigenciaFin >= DateTime.Today;

                lblEstadoPoliza.Text = activa ? "Activa" : "Inactiva";
                lblDiasVigencia.Text = (p.FechaVigenciaFin - DateTime.Today).Days.ToString();
            }
            else
            {
                lblCompania.Text = "Sin póliza";
                lblNumeroPoliza.Text = "-";
                lblFechaFinPoliza.Text = "-";
                lblEstadoPoliza.Text = "Sin póliza";
                lblDiasVigencia.Text = "-";
            }

            // Cargar órdenes del paciente
            _ordenesPaciente = _ordenRepository
                .GetOrdenesPorPaciente(cedula)
                .ToList();

            var listaGrid = _ordenesPaciente
                .Select(o => new
                {
                    o.NumeroOrden,
                    FechaCreacion = o.FechaCreacion.ToString("dd/MM/yyyy"),
                    o.CedulaMedico,
                    TotalOrden = CalcularTotalOrden(o)
                })
                .ToList();

            dgvOrdenes.DataSource = listaGrid;
        }

        private decimal CalcularTotalOrden(OrdenMedica orden)
        {
            decimal total = 0;

            foreach (var m in orden.Medicamentos)
            {
                total += m.Costo; // asumimos costo total del medicamento en la orden
            }

            foreach (var p in orden.Procedimientos)
            {
                total += p.Costo * p.Cantidad;
            }

            foreach (var a in orden.AyudasDiagnosticas)
            {
                total += a.Costo * a.Cantidad;
            }

            return total;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (_pacienteActual == null)
            {
                MessageBox.Show("Primero busque un paciente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numeroFactura = txtNumeroFactura.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeroFactura))
            {
                MessageBox.Show("Ingrese el número de factura.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreMedicoTratante = txtNombreMedicoTratante.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreMedicoTratante))
            {
                MessageBox.Show("Ingrese el nombre del médico tratante.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener órdenes seleccionadas
            var seleccionados = new List<OrdenMedica>();

            foreach (DataGridViewRow row in dgvOrdenes.Rows)
            {
                bool sel = false;
                if (row.Cells["Seleccionar"].Value != null)
                {
                    bool.TryParse(row.Cells["Seleccionar"].Value.ToString(), out sel);
                }

                if (sel)
                {
                    int numOrden = Convert.ToInt32(row.Cells["NumeroOrden"].Value);
                    var orden = _ordenesPaciente.FirstOrDefault(o => o.NumeroOrden == numOrden);
                    if (orden != null)
                        seleccionados.Add(orden);
                }
            }

            if (seleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden para facturar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construir detalle de factura a partir de las órdenes
            var detalles = new List<DetalleFacturaItem>();

            foreach (var orden in seleccionados)
            {
                foreach (var m in orden.Medicamentos)
                {
                    detalles.Add(new DetalleFacturaItem
                    {
                        Tipo = "Medicamento",
                        NumeroOrden = orden.NumeroOrden,
                        ItemOrden = m.Item,
                        Descripcion = $"{m.NombreMedicamento} - Dosis: {m.Dosis} - Duración: {m.DuracionTratamiento}",
                        Costo = m.Costo
                    });
                }

                foreach (var p in orden.Procedimientos)
                {
                    detalles.Add(new DetalleFacturaItem
                    {
                        Tipo = "Procedimiento",
                        NumeroOrden = orden.NumeroOrden,
                        ItemOrden = p.Item,
                        Descripcion = $"{p.NombreProcedimiento} - Cantidad: {p.Cantidad} - Frecuencia: {p.Frecuencia}",
                        Costo = p.Costo * p.Cantidad
                    });
                }

                foreach (var a in orden.AyudasDiagnosticas)
                {
                    detalles.Add(new DetalleFacturaItem
                    {
                        Tipo = "Ayuda diagnóstica",
                        NumeroOrden = orden.NumeroOrden,
                        ItemOrden = a.Item,
                        Descripcion = $"{a.NombreAyudaDiagnostica} - Cantidad: {a.Cantidad}",
                        Costo = a.Costo * a.Cantidad
                    });
                }
            }

            try
            {
                var poliza = _pacienteActual.PolizaSeguro;

                var factura = _facturacionService.CalcularFactura(
                    numeroFactura,
                    _pacienteActual,
                    nombreMedicoTratante,
                    poliza,
                    detalles,
                    dtpFechaFactura.Value.Date);

                _facturaActual = factura;

                // Mostrar detalle en la grilla
                var detalleGrid = factura.Detalles
                    .Select(d => new
                    {
                        d.Tipo,
                        d.NumeroOrden,
                        d.ItemOrden,
                        d.Descripcion,
                        d.Costo
                    })
                    .ToList();

                dgvDetalleFactura.DataSource = detalleGrid;

                // Mostrar totales
                lblTotalServicios.Text = factura.TotalServicios.ToString("N0");
                lblCopagoPaciente.Text = factura.CopagoPaciente.ToString("N0");
                lblTotalAseguradora.Text = factura.TotalCubreAseguradora.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de facturación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_facturaActual == null)
            {
                MessageBox.Show("Primero calcule la factura.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _facturacionService.GuardarFactura(_facturaActual);

            MessageBox.Show("Factura guardada correctamente.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            _facturaActual = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
