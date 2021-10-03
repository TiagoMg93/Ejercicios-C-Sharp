
namespace ExamenParcial
{
    partial class FMRLavadero
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
            this.DTGVDatos = new System.Windows.Forms.DataGridView();
            this.Codigo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado_Lavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa_Veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio_Lavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Lavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.CBEncargado = new System.Windows.Forms.ComboBox();
            this.BTNAddEncargado = new System.Windows.Forms.Button();
            this.BTNRemEncargado = new System.Windows.Forms.Button();
            this.TBPlaca = new System.Windows.Forms.TextBox();
            this.TBVeh = new System.Windows.Forms.TextBox();
            this.TBTipo = new System.Windows.Forms.TextBox();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.TBServicio = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LBPlaca = new System.Windows.Forms.Label();
            this.LBVeh = new System.Windows.Forms.Label();
            this.LBTipo = new System.Windows.Forms.Label();
            this.LBServicio = new System.Windows.Forms.Label();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.LBMenCliente = new System.Windows.Forms.Label();
            this.LBMenIng = new System.Windows.Forms.Label();
            this.LBClientes = new System.Windows.Forms.Label();
            this.LBIngresos = new System.Windows.Forms.Label();
            this.LBEncargado = new System.Windows.Forms.Label();
            this.BTNBorrar = new System.Windows.Forms.Button();
            this.BTNEditar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVDatos
            // 
            this.DTGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Cliente,
            this.Encargado_Lavado,
            this.Placa_Veh,
            this.Vehiculo_Cliente,
            this.Tipo_Veh,
            this.Servicio_Lavado,
            this.Precio_Lavado});
            this.DTGVDatos.Location = new System.Drawing.Point(23, 198);
            this.DTGVDatos.Name = "DTGVDatos";
            this.DTGVDatos.Size = new System.Drawing.Size(628, 176);
            this.DTGVDatos.TabIndex = 14;
            // 
            // Codigo_Cliente
            // 
            this.Codigo_Cliente.HeaderText = "Código";
            this.Codigo_Cliente.Name = "Codigo_Cliente";
            this.Codigo_Cliente.Width = 45;
            // 
            // Encargado_Lavado
            // 
            this.Encargado_Lavado.HeaderText = "Encargado";
            this.Encargado_Lavado.Name = "Encargado_Lavado";
            this.Encargado_Lavado.Width = 80;
            // 
            // Placa_Veh
            // 
            this.Placa_Veh.HeaderText = "Placa";
            this.Placa_Veh.Name = "Placa_Veh";
            this.Placa_Veh.Width = 60;
            // 
            // Vehiculo_Cliente
            // 
            this.Vehiculo_Cliente.HeaderText = "Vehículo";
            this.Vehiculo_Cliente.Name = "Vehiculo_Cliente";
            // 
            // Tipo_Veh
            // 
            this.Tipo_Veh.HeaderText = "Tipo";
            this.Tipo_Veh.Name = "Tipo_Veh";
            // 
            // Servicio_Lavado
            // 
            this.Servicio_Lavado.HeaderText = "Servicio";
            this.Servicio_Lavado.Name = "Servicio_Lavado";
            // 
            // Precio_Lavado
            // 
            this.Precio_Lavado.HeaderText = "Precio";
            this.Precio_Lavado.Name = "Precio_Lavado";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Enabled = false;
            this.BTNGuardar.Location = new System.Drawing.Point(506, 32);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 10;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Enabled = false;
            this.BTNActualizar.Location = new System.Drawing.Point(506, 112);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 12;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Enabled = false;
            this.BTNLimpiar.Location = new System.Drawing.Point(292, 153);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 8;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // CBEncargado
            // 
            this.CBEncargado.FormattingEnabled = true;
            this.CBEncargado.Location = new System.Drawing.Point(61, 21);
            this.CBEncargado.Name = "CBEncargado";
            this.CBEncargado.Size = new System.Drawing.Size(121, 21);
            this.CBEncargado.TabIndex = 0;
            this.CBEncargado.SelectedIndexChanged += new System.EventHandler(this.CBEncargado_SelectedIndexChanged);
            // 
            // BTNAddEncargado
            // 
            this.BTNAddEncargado.Location = new System.Drawing.Point(211, 10);
            this.BTNAddEncargado.Name = "BTNAddEncargado";
            this.BTNAddEncargado.Size = new System.Drawing.Size(75, 34);
            this.BTNAddEncargado.TabIndex = 1;
            this.BTNAddEncargado.Text = "Agregar Encargado";
            this.BTNAddEncargado.UseVisualStyleBackColor = true;
            this.BTNAddEncargado.Click += new System.EventHandler(this.BTNAddEncargado_Click);
            // 
            // BTNRemEncargado
            // 
            this.BTNRemEncargado.Location = new System.Drawing.Point(292, 10);
            this.BTNRemEncargado.Name = "BTNRemEncargado";
            this.BTNRemEncargado.Size = new System.Drawing.Size(75, 34);
            this.BTNRemEncargado.TabIndex = 2;
            this.BTNRemEncargado.Text = "Eliminar Encargado";
            this.BTNRemEncargado.UseVisualStyleBackColor = true;
            this.BTNRemEncargado.Click += new System.EventHandler(this.BTNRemEncargado_Click);
            // 
            // TBPlaca
            // 
            this.TBPlaca.Enabled = false;
            this.TBPlaca.Location = new System.Drawing.Point(135, 56);
            this.TBPlaca.Name = "TBPlaca";
            this.TBPlaca.Size = new System.Drawing.Size(100, 20);
            this.TBPlaca.TabIndex = 3;
            // 
            // TBVeh
            // 
            this.TBVeh.Enabled = false;
            this.TBVeh.Location = new System.Drawing.Point(135, 82);
            this.TBVeh.Name = "TBVeh";
            this.TBVeh.Size = new System.Drawing.Size(100, 20);
            this.TBVeh.TabIndex = 4;
            // 
            // TBTipo
            // 
            this.TBTipo.Enabled = false;
            this.TBTipo.Location = new System.Drawing.Point(135, 108);
            this.TBTipo.Name = "TBTipo";
            this.TBTipo.Size = new System.Drawing.Size(100, 20);
            this.TBTipo.TabIndex = 5;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(560, 390);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 15;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // TBServicio
            // 
            this.TBServicio.Enabled = false;
            this.TBServicio.Location = new System.Drawing.Point(135, 134);
            this.TBServicio.Name = "TBServicio";
            this.TBServicio.Size = new System.Drawing.Size(100, 20);
            this.TBServicio.TabIndex = 6;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Enabled = false;
            this.TBPrecio.Location = new System.Drawing.Point(135, 160);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(100, 20);
            this.TBPrecio.TabIndex = 7;
            // 
            // LBPlaca
            // 
            this.LBPlaca.AutoSize = true;
            this.LBPlaca.Location = new System.Drawing.Point(70, 59);
            this.LBPlaca.Name = "LBPlaca";
            this.LBPlaca.Size = new System.Drawing.Size(34, 13);
            this.LBPlaca.TabIndex = 15;
            this.LBPlaca.Text = "Placa";
            // 
            // LBVeh
            // 
            this.LBVeh.AutoSize = true;
            this.LBVeh.Location = new System.Drawing.Point(54, 85);
            this.LBVeh.Name = "LBVeh";
            this.LBVeh.Size = new System.Drawing.Size(50, 13);
            this.LBVeh.TabIndex = 16;
            this.LBVeh.Text = "Vehículo";
            // 
            // LBTipo
            // 
            this.LBTipo.AutoSize = true;
            this.LBTipo.Location = new System.Drawing.Point(76, 111);
            this.LBTipo.Name = "LBTipo";
            this.LBTipo.Size = new System.Drawing.Size(28, 13);
            this.LBTipo.TabIndex = 17;
            this.LBTipo.Text = "Tipo";
            // 
            // LBServicio
            // 
            this.LBServicio.AutoSize = true;
            this.LBServicio.Location = new System.Drawing.Point(59, 137);
            this.LBServicio.Name = "LBServicio";
            this.LBServicio.Size = new System.Drawing.Size(45, 13);
            this.LBServicio.TabIndex = 18;
            this.LBServicio.Text = "Servicio";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(67, 163);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(37, 13);
            this.LBPrecio.TabIndex = 19;
            this.LBPrecio.Text = "Precio";
            // 
            // LBMenCliente
            // 
            this.LBMenCliente.AutoSize = true;
            this.LBMenCliente.Location = new System.Drawing.Point(322, 72);
            this.LBMenCliente.Name = "LBMenCliente";
            this.LBMenCliente.Size = new System.Drawing.Size(74, 13);
            this.LBMenCliente.TabIndex = 20;
            this.LBMenCliente.Text = "Total Clientes:";
            // 
            // LBMenIng
            // 
            this.LBMenIng.AutoSize = true;
            this.LBMenIng.Location = new System.Drawing.Point(295, 108);
            this.LBMenIng.Name = "LBMenIng";
            this.LBMenIng.Size = new System.Drawing.Size(101, 13);
            this.LBMenIng.TabIndex = 21;
            this.LBMenIng.Text = "Total de Ingresos: $";
            // 
            // LBClientes
            // 
            this.LBClientes.AutoSize = true;
            this.LBClientes.Location = new System.Drawing.Point(402, 72);
            this.LBClientes.Name = "LBClientes";
            this.LBClientes.Size = new System.Drawing.Size(13, 13);
            this.LBClientes.TabIndex = 22;
            this.LBClientes.Text = "0";
            // 
            // LBIngresos
            // 
            this.LBIngresos.AutoSize = true;
            this.LBIngresos.Location = new System.Drawing.Point(402, 108);
            this.LBIngresos.Name = "LBIngresos";
            this.LBIngresos.Size = new System.Drawing.Size(13, 13);
            this.LBIngresos.TabIndex = 23;
            this.LBIngresos.Text = "0";
            // 
            // LBEncargado
            // 
            this.LBEncargado.AutoSize = true;
            this.LBEncargado.Location = new System.Drawing.Point(91, 5);
            this.LBEncargado.Name = "LBEncargado";
            this.LBEncargado.Size = new System.Drawing.Size(59, 13);
            this.LBEncargado.TabIndex = 24;
            this.LBEncargado.Text = "Encargado";
            // 
            // BTNBorrar
            // 
            this.BTNBorrar.Enabled = false;
            this.BTNBorrar.Location = new System.Drawing.Point(506, 153);
            this.BTNBorrar.Name = "BTNBorrar";
            this.BTNBorrar.Size = new System.Drawing.Size(75, 23);
            this.BTNBorrar.TabIndex = 13;
            this.BTNBorrar.Text = "Borrar";
            this.BTNBorrar.UseVisualStyleBackColor = true;
            this.BTNBorrar.Click += new System.EventHandler(this.BTNBorrar_Click);
            // 
            // BTNEditar
            // 
            this.BTNEditar.Enabled = false;
            this.BTNEditar.Location = new System.Drawing.Point(506, 72);
            this.BTNEditar.Name = "BTNEditar";
            this.BTNEditar.Size = new System.Drawing.Size(75, 23);
            this.BTNEditar.TabIndex = 11;
            this.BTNEditar.Text = "Editar";
            this.BTNEditar.UseVisualStyleBackColor = true;
            this.BTNEditar.Click += new System.EventHandler(this.BTNEditar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Enabled = false;
            this.BTNSalir.Location = new System.Drawing.Point(391, 153);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 9;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // FMRLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 425);
            this.ControlBox = false;
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNEditar);
            this.Controls.Add(this.BTNBorrar);
            this.Controls.Add(this.LBEncargado);
            this.Controls.Add(this.LBIngresos);
            this.Controls.Add(this.LBClientes);
            this.Controls.Add(this.LBMenIng);
            this.Controls.Add(this.LBMenCliente);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.LBServicio);
            this.Controls.Add(this.LBTipo);
            this.Controls.Add(this.LBVeh);
            this.Controls.Add(this.LBPlaca);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBServicio);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.TBTipo);
            this.Controls.Add(this.TBVeh);
            this.Controls.Add(this.TBPlaca);
            this.Controls.Add(this.BTNRemEncargado);
            this.Controls.Add(this.BTNAddEncargado);
            this.Controls.Add(this.CBEncargado);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.DTGVDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRLavadero";
            this.Text = "Lavadero";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVDatos;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.ComboBox CBEncargado;
        private System.Windows.Forms.Button BTNAddEncargado;
        private System.Windows.Forms.Button BTNRemEncargado;
        private System.Windows.Forms.TextBox TBPlaca;
        private System.Windows.Forms.TextBox TBVeh;
        private System.Windows.Forms.TextBox TBTipo;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.TextBox TBServicio;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label LBPlaca;
        private System.Windows.Forms.Label LBVeh;
        private System.Windows.Forms.Label LBTipo;
        private System.Windows.Forms.Label LBServicio;
        private System.Windows.Forms.Label LBPrecio;
        private System.Windows.Forms.Label LBMenCliente;
        private System.Windows.Forms.Label LBMenIng;
        private System.Windows.Forms.Label LBClientes;
        private System.Windows.Forms.Label LBIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado_Lavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa_Veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio_Lavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Lavado;
        private System.Windows.Forms.Label LBEncargado;
        private System.Windows.Forms.Button BTNBorrar;
        private System.Windows.Forms.Button BTNEditar;
        private System.Windows.Forms.Button BTNSalir;
    }
}

