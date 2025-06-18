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
            this.Empsephar = new System.Windows.Forms.RadioButton();
            this.Cemefar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.AutoSize = true;
            this.NombreMedicamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMedicamento.Location = new System.Drawing.Point(347, 98);
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.Size = new System.Drawing.Size(192, 16);
            this.NombreMedicamento.TabIndex = 0;
            this.NombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(544, 95);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(215, 20);
            this.txtNombreMedicamento.TabIndex = 1;
            // 
            // TipoMedicamento
            // 
            this.TipoMedicamento.AutoSize = true;
            this.TipoMedicamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMedicamento.Location = new System.Drawing.Point(373, 144);
            this.TipoMedicamento.Name = "TipoMedicamento";
            this.TipoMedicamento.Size = new System.Drawing.Size(161, 16);
            this.TipoMedicamento.TabIndex = 2;
            this.TipoMedicamento.Text = "Tipo de Medicamento";
            // 
            // comboBoxTipoMedicamento
            // 
            this.comboBoxTipoMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTipoMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoMedicamento.DisplayMember = "Seleccione;";
            this.comboBoxTipoMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMedicamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(453, 197);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(72, 16);
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
            this.Distribuidor.Size = new System.Drawing.Size(91, 16);
            this.Distribuidor.TabIndex = 6;
            this.Distribuidor.Text = "Distribuidor";
            // 
            // Cofarma
            // 
            this.Cofarma.AutoSize = true;
            this.Cofarma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cofarma.Location = new System.Drawing.Point(544, 249);
            this.Cofarma.Name = "Cofarma";
            this.Cofarma.Size = new System.Drawing.Size(79, 20);
            this.Cofarma.TabIndex = 0;
            this.Cofarma.TabStop = true;
            this.Cofarma.Text = "Cofarma";
            this.Cofarma.UseVisualStyleBackColor = true;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucursal.Location = new System.Drawing.Point(455, 393);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(69, 16);
            this.Sucursal.TabIndex = 8;
            this.Sucursal.Text = "Sucursal";
            // 
            // Principal
            // 
            this.Principal.AutoSize = true;
            this.Principal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Principal.Location = new System.Drawing.Point(545, 393);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(80, 20);
            this.Principal.TabIndex = 9;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // Secundaria
            // 
            this.Secundaria.AutoSize = true;
            this.Secundaria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secundaria.Location = new System.Drawing.Point(645, 393);
            this.Secundaria.Name = "Secundaria";
            this.Secundaria.Size = new System.Drawing.Size(99, 20);
            this.Secundaria.TabIndex = 10;
            this.Secundaria.Text = "Secundaria";
            this.Secundaria.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(475, 472);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(96, 32);
            this.Confirmar.TabIndex = 11;
            this.Confirmar.Text = "CONFIRMAR";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Borrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(616, 472);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(96, 32);
            this.Borrar.TabIndex = 12;
            this.Borrar.Text = "BORRAR";
            this.Borrar.UseVisualStyleBackColor = true;
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
            // 
            // Empsephar
            // 
            this.Empsephar.AutoSize = true;
            this.Empsephar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empsephar.Location = new System.Drawing.Point(544, 287);
            this.Empsephar.Name = "Empsephar";
            this.Empsephar.Size = new System.Drawing.Size(96, 20);
            this.Empsephar.TabIndex = 1;
            this.Empsephar.TabStop = true;
            this.Empsephar.Text = "Empsephar";
            this.Empsephar.UseVisualStyleBackColor = true;
            // 
            // Cemefar
            // 
            this.Cemefar.AutoSize = true;
            this.Cemefar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cemefar.Location = new System.Drawing.Point(545, 327);
            this.Cemefar.Name = "Cemefar";
            this.Cemefar.Size = new System.Drawing.Size(79, 20);
            this.Cemefar.TabIndex = 2;
            this.Cemefar.TabStop = true;
            this.Cemefar.Text = "Cemefar";
            this.Cemefar.UseVisualStyleBackColor = true;
            // 
            // FormularioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.Cemefar);
            this.Controls.Add(this.Lbl_pedido);
            this.Controls.Add(this.Empsephar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPedido";
            this.Text = "Form1";
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
        private System.Windows.Forms.RadioButton Empsephar;
        private System.Windows.Forms.RadioButton Cemefar;
    }
}

