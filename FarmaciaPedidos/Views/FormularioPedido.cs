using FarmaciaPedidos.Models;
using FarmaciaPedidos.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FarmaciaPedidos
{
    public partial class FormularioPedido: Form
    {
        public FormularioPedido()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            var pedido = new Pedido
            {
                NombreMedicamento   =   txtNombreMedicamento.Text,
                TipoMedicamento     =   comboBoxTipoMedicamento.SelectedItem?.ToString(),
                Distribuidor        =   Cofarma.Checked ? "Cofarma" :
                                        Empsephar.Checked ? "Empsephar" :
                                        Cemefar.Checked ? "Cemefar" : null,

                Cantidad = int.TryParse(textBoxCantidad.Text, out int cantidad) ? cantidad : -1
            };

            // Sucursales seleccionadas
            if (Principal.Checked) pedido.Sucursales.Add("Principal");
            if (Secundaria.Checked) pedido.Sucursales.Add("Secundaria");

            // Validar
            var validador = new PedidoValidator();
            var errores = validador.Validar(pedido);

            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Errores en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construir resumen
            var builder = new ResumenPedidoBuilder();
            var resumen = builder.ConstruirResumen(pedido);

            // Mostrar en MessageBox por ahora (luego abrirás ResumenPedidoForm)
            MessageBox.Show($"{resumen.TituloVentana}\n\n{resumen.DetalleMedicamento}\n\n{resumen.DireccionEntrega}",
                "Resumen del Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtNombreMedicamento.Text = "";
            comboBoxTipoMedicamento.SelectedIndex = -1;
            textBoxCantidad.Text = "";
            Cofarma.Checked = false;
            Empsephar.Checked = false;
            Cemefar.Checked = false;
            Principal.Checked = false;
            Secundaria.Checked = false;
        }
    }
}
