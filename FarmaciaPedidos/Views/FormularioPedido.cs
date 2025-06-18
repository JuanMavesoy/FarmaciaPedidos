using FarmaciaPedidos.Models;
using FarmaciaPedidos.Services;
using FarmaciaPedidos.Views;
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FarmaciaPedidos
{
    public partial class FormularioPedido : Form
    {
        public FormularioPedido()
        {
            InitializeComponent();
            Confirmar.BackColor =System.Drawing.Color.FromArgb(200, 200, 255);
            Confirmar.ForeColor = System.Drawing.Color.Black;
            Confirmar.FlatStyle = FlatStyle.Flat;
            Confirmar.FlatAppearance.BorderSize = 0;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(Confirmar.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(Confirmar.Width - 20, Confirmar.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, Confirmar.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();
            Confirmar.Region = new System.Drawing.Region(path);

            Borrar.BackColor = System.Drawing.Color.FromArgb(225, 225, 255);
            Borrar.ForeColor = System.Drawing.Color.Black;
            Borrar.FlatStyle = FlatStyle.Flat;
            Borrar.FlatAppearance.BorderSize = 0;

            GraphicsPath pathBorrar = new GraphicsPath();
            pathBorrar.AddArc(0, 0, 20, 20, 180, 90);
            pathBorrar.AddArc(Borrar.Width - 20, 0, 20, 20, 270, 90);
            pathBorrar.AddArc(Borrar.Width - 20, Borrar.Height - 20, 20, 20, 0, 90);
            pathBorrar.AddArc(0, Borrar.Height - 20, 20, 20, 90, 90);
            pathBorrar.CloseAllFigures();
            Borrar.Region = new System.Drawing.Region(pathBorrar);
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            var pedido = new Pedido
            {
                
            NombreMedicamento = txtNombreMedicamento.Text,
                TipoMedicamento = comboBoxTipoMedicamento.SelectedItem?.ToString(),
                Distribuidor = Cofarma.Checked ? "Cofarma" :
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

            // Mostrar formulario de resumen
            var resumenForm = new ResumenPedidoForm(resumen);
            resumenForm.ShowDialog();
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
