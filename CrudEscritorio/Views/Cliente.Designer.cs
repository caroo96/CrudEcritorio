namespace CrudEscritorio.Views
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnCerrarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCiente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.lbformularioClientes = new System.Windows.Forms.Label();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.GdListaClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GdListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(71, 98);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(71, 131);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 1;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(74, 170);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 2;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(74, 205);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(38, 13);
            this.lbCorreo.TabIndex = 3;
            this.lbCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(143, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 170);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(143, 205);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // btnCerrarCliente
            // 
            this.btnCerrarCliente.Location = new System.Drawing.Point(703, 363);
            this.btnCerrarCliente.Name = "btnCerrarCliente";
            this.btnCerrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarCliente.TabIndex = 8;
            this.btnCerrarCliente.Text = "Cerrar";
            this.btnCerrarCliente.UseVisualStyleBackColor = true;
            this.btnCerrarCliente.Click += new System.EventHandler(this.btnCerrarCliente_Click);
            // 
            // btnGuardarCiente
            // 
            this.btnGuardarCiente.Location = new System.Drawing.Point(143, 248);
            this.btnGuardarCiente.Name = "btnGuardarCiente";
            this.btnGuardarCiente.Size = new System.Drawing.Size(100, 39);
            this.btnGuardarCiente.TabIndex = 9;
            this.btnGuardarCiente.Text = "Guardar";
            this.btnGuardarCiente.UseVisualStyleBackColor = true;
            this.btnGuardarCiente.Click += new System.EventHandler(this.btnGuardarCiente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(514, 248);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(82, 39);
            this.btnEditarCliente.TabIndex = 10;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // lbformularioClientes
            // 
            this.lbformularioClientes.AutoSize = true;
            this.lbformularioClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lbformularioClientes.Location = new System.Drawing.Point(276, 9);
            this.lbformularioClientes.Name = "lbformularioClientes";
            this.lbformularioClientes.Size = new System.Drawing.Size(171, 47);
            this.lbformularioClientes.TabIndex = 11;
            this.lbformularioClientes.Text = "Clientes";
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Location = new System.Drawing.Point(422, 248);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(86, 39);
            this.btnConsultarClientes.TabIndex = 12;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(602, 249);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 38);
            this.btnEliminarCliente.TabIndex = 13;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // GdListaClientes
            // 
            this.GdListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdListaClientes.Location = new System.Drawing.Point(349, 98);
            this.GdListaClientes.Name = "GdListaClientes";
            this.GdListaClientes.Size = new System.Drawing.Size(398, 127);
            this.GdListaClientes.TabIndex = 14;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Location = new System.Drawing.Point(71, 66);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(16, 13);
            this.IdCliente.TabIndex = 15;
            this.IdCliente.Text = "Id";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(143, 63);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 16;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.IdCliente);
            this.Controls.Add(this.GdListaClientes);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.lbformularioClientes);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnGuardarCiente);
            this.Controls.Add(this.btnCerrarCliente);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnCerrarCliente;
        private System.Windows.Forms.Button btnGuardarCiente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Label lbformularioClientes;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.DataGridView GdListaClientes;
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}