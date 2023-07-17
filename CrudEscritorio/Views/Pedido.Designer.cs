namespace CrudEscritorio.Views
{
    partial class Pedido
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
            this.lbClientePedido = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.fechaPedido = new System.Windows.Forms.Label();
            this.txtClientePedido = new System.Windows.Forms.TextBox();
            this.btnCerrarPedido = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrecioTotal = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClientePedido
            // 
            this.lbClientePedido.AutoSize = true;
            this.lbClientePedido.Location = new System.Drawing.Point(65, 177);
            this.lbClientePedido.Name = "lbClientePedido";
            this.lbClientePedido.Size = new System.Drawing.Size(39, 13);
            this.lbClientePedido.TabIndex = 1;
            this.lbClientePedido.Text = "Cliente";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(122, 144);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // fechaPedido
            // 
            this.fechaPedido.AutoSize = true;
            this.fechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fechaPedido.Location = new System.Drawing.Point(65, 144);
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.Size = new System.Drawing.Size(37, 13);
            this.fechaPedido.TabIndex = 0;
            this.fechaPedido.Text = "Fecha";
            // 
            // txtClientePedido
            // 
            this.txtClientePedido.Location = new System.Drawing.Point(122, 177);
            this.txtClientePedido.Name = "txtClientePedido";
            this.txtClientePedido.Size = new System.Drawing.Size(100, 20);
            this.txtClientePedido.TabIndex = 3;
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.Location = new System.Drawing.Point(715, 355);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarPedido.TabIndex = 6;
            this.btnCerrarPedido.Text = "Cerarr";
            this.btnCerrarPedido.UseVisualStyleBackColor = true;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Location = new System.Drawing.Point(122, 268);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(100, 32);
            this.btnGuardarPedido.TabIndex = 4;
            this.btnGuardarPedido.Text = "Crear";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(290, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "PEDIDOS";
            // 
            // lbPrecioTotal
            // 
            this.lbPrecioTotal.AutoSize = true;
            this.lbPrecioTotal.Location = new System.Drawing.Point(65, 220);
            this.lbPrecioTotal.Name = "lbPrecioTotal";
            this.lbPrecioTotal.Size = new System.Drawing.Size(31, 13);
            this.lbPrecioTotal.TabIndex = 8;
            this.lbPrecioTotal.Text = "Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(122, 213);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioTotal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 128);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lbPrecioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.txtClientePedido);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lbClientePedido);
            this.Controls.Add(this.fechaPedido);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbClientePedido;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label fechaPedido;
        private System.Windows.Forms.TextBox txtClientePedido;
        private System.Windows.Forms.Button btnCerrarPedido;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}