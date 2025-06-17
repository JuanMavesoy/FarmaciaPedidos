namespace FarmaciaPedidos
{
    partial class FormularioPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPedido));
            this.NombreMedicamento = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.TipoMedicamento = new System.Windows.Forms.Label();
            this.comboBoxTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.Distribuidor = new System.Windows.Forms.Label();
            this.Cofarma = new System.Windows.Forms.RadioButton();
            this.Sucursal = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.CheckBox();
            this.Secundaria = new System.Windows.Forms.CheckBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_pedido = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.AutoSize = true;
            this.NombreMedicamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMedicamento.Location = new System.Drawing.Point(347, 98);
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.Size = new System.Drawing.Size(193, 16);
            this.NombreMedicamento.TabIndex = 0;
            this.NombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(544, 95);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(215, 20);
            this.txtNombreMedicamento.TabIndex = 1;
            this.txtNombreMedicamento.TextChanged += new System.EventHandler(this.txtNombreMedicamento_TextChanged);
            // 
            // TipoMedicamento
            // 
            this.TipoMedicamento.AutoSize = true;
            this.TipoMedicamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMedicamento.Location = new System.Drawing.Point(373, 144);
            this.TipoMedicamento.Name = "TipoMedicamento";
            this.TipoMedicamento.Size = new System.Drawing.Size(162, 16);
            this.TipoMedicamento.TabIndex = 2;
            this.TipoMedicamento.Text = "Tipo de Medicamento";
            // 
            // comboBoxTipoMedicamento
            // 
            this.comboBoxTipoMedicamento.DisplayMember = "Seleccione;";
            this.comboBoxTipoMedicamento.FormattingEnabled = true;
            this.comboBoxTipoMedicamento.Items.AddRange(new object[] {
            "Seleccione",
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo ",
            "Antibióticos"});
            this.comboBoxTipoMedicamento.Location = new System.Drawing.Point(544, 144);
            this.comboBoxTipoMedicamento.Name = "comboBoxTipoMedicamento";
            this.comboBoxTipoMedicamento.Size = new System.Drawing.Size(215, 21);
            this.comboBoxTipoMedicamento.TabIndex = 3;
            this.comboBoxTipoMedicamento.ValueMember = "Seleccione;Analgesico;Analeptico; Anestésico; Atiacido; Antidepresivo; Antibiotic" +
    "o";
            this.comboBoxTipoMedicamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoMedicamento_SelectedIndexChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(453, 197);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(73, 16);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(544, 197);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(215, 20);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // Distribuidor
            // 
            this.Distribuidor.AutoSize = true;
            this.Distribuidor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distribuidor.Location = new System.Drawing.Point(433, 287);
            this.Distribuidor.Name = "Distribuidor";
            this.Distribuidor.Size = new System.Drawing.Size(92, 16);
            this.Distribuidor.TabIndex = 6;
            this.Distribuidor.Text = "Distribuidor";
            // 
            // Cofarma
            // 
            this.Cofarma.AutoSize = true;
            this.Cofarma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cofarma.Location = new System.Drawing.Point(544, 249);
            this.Cofarma.Name = "Cofarma";
            this.Cofarma.Size = new System.Drawing.Size(80, 20);
            this.Cofarma.TabIndex = 0;
            this.Cofarma.TabStop = true;
            this.Cofarma.Text = "Cofarma";
            this.Cofarma.UseVisualStyleBackColor = true;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucursal.Location = new System.Drawing.Point(456, 381);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(70, 16);
            this.Sucursal.TabIndex = 8;
            this.Sucursal.Text = "Sucursal";
            // 
            // Principal
            // 
            this.Principal.AutoSize = true;
            this.Principal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Principal.Location = new System.Drawing.Point(542, 381);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(81, 20);
            this.Principal.TabIndex = 9;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // Secundaria
            // 
            this.Secundaria.AutoSize = true;
            this.Secundaria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secundaria.Location = new System.Drawing.Point(646, 381);
            this.Secundaria.Name = "Secundaria";
            this.Secundaria.Size = new System.Drawing.Size(100, 20);
            this.Secundaria.TabIndex = 10;
            this.Secundaria.Text = "Secundaria";
            this.Secundaria.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.Gainsboro;
            this.Confirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Confirmar.Location = new System.Drawing.Point(459, 456);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(102, 32);
            this.Confirmar.TabIndex = 11;
            this.Confirmar.Text = "CONFIRMAR";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.Gainsboro;
            this.Borrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(614, 456);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(100, 32);
            this.Borrar.TabIndex = 12;
            this.Borrar.Text = "BORRAR";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 555);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_pedido
            // 
            this.Lbl_pedido.AutoSize = true;
            this.Lbl_pedido.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pedido.Location = new System.Drawing.Point(382, 20);
            this.Lbl_pedido.Name = "Lbl_pedido";
            this.Lbl_pedido.Size = new System.Drawing.Size(377, 40);
            this.Lbl_pedido.TabIndex = 14;
            this.Lbl_pedido.Text = "REGISTRO DE PEDIDOS";
            this.Lbl_pedido.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Lbl_pedido.UseCompatibleTextRendering = true;
            this.Lbl_pedido.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(545, 287);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 20);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Empsephar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(544, 327);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 20);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cemefar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormularioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(940, 550);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Lbl_pedido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cofarma);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Secundaria);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Sucursal);
            this.Controls.Add(this.Distribuidor);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.comboBoxTipoMedicamento);
            this.Controls.Add(this.TipoMedicamento);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.NombreMedicamento);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormularioPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreMedicamento;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Label TipoMedicamento;
        private System.Windows.Forms.ComboBox comboBoxTipoMedicamento;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label Distribuidor;
        private System.Windows.Forms.RadioButton Cofarma;
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.CheckBox Principal;
        private System.Windows.Forms.CheckBox Secundaria;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_pedido;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

