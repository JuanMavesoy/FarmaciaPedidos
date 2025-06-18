using FarmaciaPedidos.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FarmaciaPedidos.Views
{
    public partial class ResumenPedidoForm : Form
    {
        private readonly ResumenPedido _resumen;
        public ResumenPedidoForm(ResumenPedido resumen)
        {
            InitializeComponent();
            _resumen = resumen;

            AplicarEstilos();
            MostrarResumenEnHtml();
        }

        private void MostrarResumenEnHtml()
        {
            string html = $@"
                <html>
                <head>
                    <style>
                        body {{
                            background-color: #F2F2F2; 
                            font-family: Verdana;
                            padding: 20px;
                            overflow: hidden; /* Oculta scroll */
                        }}
                        h1 {{
                            font-size: 24px;
                            text-align: center;
                        }}
                        p {{
                            font-size: 18px;
                            text-align: center;
                            margin: 10px 0;
                        }}
                    </style>
                </head>
                <body>
                    <br />
                    <h1>{_resumen.TituloVentana}</h1>
                    <br />
                    <br />
                    <p>{_resumen.DetalleMedicamento}</p>
                    <br />
                    <p>{_resumen.DireccionEntrega}</p>
                </body>
                </html>";


            webBrowserResumen.DocumentText = html;
        }


        private void AplicarEstilos()
        {
            // ENVIAR
            Btn_Enviar.BackColor = Color.FromArgb(249, 249, 255);
            Btn_Enviar.FlatStyle = FlatStyle.Flat;
            Btn_Enviar.FlatAppearance.BorderSize = 0;

            GraphicsPath pathEnviar = new GraphicsPath();
            pathEnviar.AddArc(0, 0, 20, 20, 180, 90);
            pathEnviar.AddArc(Btn_Enviar.Width - 20, 0, 20, 20, 270, 90);
            pathEnviar.AddArc(Btn_Enviar.Width - 20, Btn_Enviar.Height - 20, 20, 20, 0, 90);
            pathEnviar.AddArc(0, Btn_Enviar.Height - 20, 20, 20, 90, 90);
            pathEnviar.CloseAllFigures();
            Btn_Enviar.Region = new Region(pathEnviar);

            // CANCELAR
            Btn_Cancelar.BackColor = Color.FromArgb(225, 225, 255);
            Btn_Cancelar.ForeColor = Color.Black;
            Btn_Cancelar.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar.FlatAppearance.BorderSize = 0;

            GraphicsPath pathCancelar = new GraphicsPath();
            pathCancelar.AddArc(0, 0, 20, 20, 180, 90);
            pathCancelar.AddArc(Btn_Cancelar.Width - 20, 0, 20, 20, 270, 90);
            pathCancelar.AddArc(Btn_Cancelar.Width - 20, Btn_Cancelar.Height - 20, 20, 20, 0, 90);
            pathCancelar.AddArc(0, Btn_Cancelar.Height - 20, 20, 20, 90, 90);
            pathCancelar.CloseAllFigures();
            Btn_Cancelar.Region = new Region(pathCancelar);
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
