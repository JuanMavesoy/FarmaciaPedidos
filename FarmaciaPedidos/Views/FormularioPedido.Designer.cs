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
            this.NombreMedicamento = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.TipoMedicamento = new System.Windows.Forms.Label();
            this.comboBoxTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.Distribuidor = new System.Windows.Forms.Label();
            this.groupBoxDistribuidor = new System.Windows.Forms.GroupBox();
            this.Cemefar = new System.Windows.Forms.RadioButton();
            this.Empsephar = new System.Windows.Forms.RadioButton();
            this.Cofarma = new System.Windows.Forms.RadioButton();
            this.Sucursal = new System.Windows.Forms.Label();
            this.Principal = new System.Windows.Forms.CheckBox();
            this.Secundaria = new System.Windows.Forms.CheckBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.groupBoxDistribuidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.AutoSize = true;
            this.NombreMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMedicamento.Location = new System.Drawing.Point(379, 51);
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.Size = new System.Drawing.Size(169, 17);
            this.NombreMedicamento.TabIndex = 0;
            this.NombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(575, 51);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(215, 20);
            this.txtNombreMedicamento.TabIndex = 1;
            // 
            // TipoMedicamento
            // 
            this.TipoMedicamento.AutoSize = true;
            this.TipoMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMedicamento.Location = new System.Drawing.Point(379, 109);
            this.TipoMedicamento.Name = "TipoMedicamento";
            this.TipoMedicamento.Size = new System.Drawing.Size(143, 17);
            this.TipoMedicamento.TabIndex = 2;
            this.TipoMedicamento.Text = "Tipo de Medicamento";
            // 
            // comboBoxTipoMedicamento
            // 
            this.comboBoxTipoMedicamento.FormattingEnabled = true;
            this.comboBoxTipoMedicamento.Location = new System.Drawing.Point(575, 109);
            this.comboBoxTipoMedicamento.Name = "comboBoxTipoMedicamento";
            this.comboBoxTipoMedicamento.Size = new System.Drawing.Size(215, 21);
            this.comboBoxTipoMedicamento.TabIndex = 3;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(379, 173);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(63, 17);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(575, 170);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(215, 20);
            this.textBoxCantidad.TabIndex = 5;
            // 
            // Distribuidor
            // 
            this.Distribuidor.AutoSize = true;
            this.Distribuidor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distribuidor.Location = new System.Drawing.Point(379, 250);
            this.Distribuidor.Name = "Distribuidor";
            this.Distribuidor.Size = new System.Drawing.Size(83, 17);
            this.Distribuidor.TabIndex = 6;
            this.Distribuidor.Text = "Distribuidor";
            // 
            // groupBoxDistribuidor
            // 
            this.groupBoxDistribuidor.Controls.Add(this.Cemefar);
            this.groupBoxDistribuidor.Controls.Add(this.Empsephar);
            this.groupBoxDistribuidor.Controls.Add(this.Cofarma);
            this.groupBoxDistribuidor.Location = new System.Drawing.Point(575, 230);
            this.groupBoxDistribuidor.Name = "groupBoxDistribuidor";
            this.groupBoxDistribuidor.Size = new System.Drawing.Size(200, 133);
            this.groupBoxDistribuidor.TabIndex = 7;
            this.groupBoxDistribuidor.TabStop = false;
            // 
            // Cemefar
            // 
            this.Cemefar.AutoSize = true;
            this.Cemefar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cemefar.Location = new System.Drawing.Point(19, 97);
            this.Cemefar.Name = "Cemefar";
            this.Cemefar.Size = new System.Drawing.Size(75, 21);
            this.Cemefar.TabIndex = 2;
            this.Cemefar.TabStop = true;
            this.Cemefar.Text = "Cemefar";
            this.Cemefar.UseVisualStyleBackColor = true;
            // 
            // Empsephar
            // 
            this.Empsephar.AutoSize = true;
            this.Empsephar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empsephar.Location = new System.Drawing.Point(19, 58);
            this.Empsephar.Name = "Empsephar";
            this.Empsephar.Size = new System.Drawing.Size(92, 21);
            this.Empsephar.TabIndex = 1;
            this.Empsephar.TabStop = true;
            this.Empsephar.Text = "Empsephar";
            this.Empsephar.UseVisualStyleBackColor = true;
            // 
            // Cofarma
            // 
            this.Cofarma.AutoSize = true;
            this.Cofarma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cofarma.Location = new System.Drawing.Point(19, 20);
            this.Cofarma.Name = "Cofarma";
            this.Cofarma.Size = new System.Drawing.Size(76, 21);
            this.Cofarma.TabIndex = 0;
            this.Cofarma.TabStop = true;
            this.Cofarma.Text = "Cofarma";
            this.Cofarma.UseVisualStyleBackColor = true;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucursal.Location = new System.Drawing.Point(383, 410);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(59, 17);
            this.Sucursal.TabIndex = 8;
            this.Sucursal.Text = "Sucursal";
            // 
            // Principal
            // 
            this.Principal.AutoSize = true;
            this.Principal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Principal.Location = new System.Drawing.Point(575, 406);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(76, 21);
            this.Principal.TabIndex = 9;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // Secundaria
            // 
            this.Secundaria.AutoSize = true;
            this.Secundaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secundaria.Location = new System.Drawing.Point(699, 406);
            this.Secundaria.Name = "Secundaria";
            this.Secundaria.Size = new System.Drawing.Size(91, 21);
            this.Secundaria.TabIndex = 10;
            this.Secundaria.Text = "Secundaria";
            this.Secundaria.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.Confirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(675, 521);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(85, 32);
            this.Confirmar.TabIndex = 11;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(809, 521);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(86, 32);
            this.Borrar.TabIndex = 12;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // FormularioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 586);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Secundaria);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Sucursal);
            this.Controls.Add(this.groupBoxDistribuidor);
            this.Controls.Add(this.Distribuidor);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.comboBoxTipoMedicamento);
            this.Controls.Add(this.TipoMedicamento);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.NombreMedicamento);
            this.Name = "FormularioPedido";
            this.Text = "Form1";
            this.groupBoxDistribuidor.ResumeLayout(false);
            this.groupBoxDistribuidor.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxDistribuidor;
        private System.Windows.Forms.RadioButton Cofarma;
        private System.Windows.Forms.RadioButton Cemefar;
        private System.Windows.Forms.RadioButton Empsephar;
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.CheckBox Principal;
        private System.Windows.Forms.CheckBox Secundaria;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Borrar;
    }
}

