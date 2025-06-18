using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPedidos.Views
{
    public partial class ResumenPedido : Form
    {
        public ResumenPedido()
        {
            InitializeComponent();
            Btn_Enviar.BackColor = Color.FromArgb(249, 249, 255);
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

        private void ResumenPedido_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
