namespace CrudEscritorio.Views
{
    partial class DetallePedido
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
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.txtIdProductoDetalle = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgregarProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Location = new System.Drawing.Point(23, 144);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(59, 13);
            this.lbIdProducto.TabIndex = 0;
            this.lbIdProducto.Text = "IdProducto";
            // 
            // txtIdProductoDetalle
            // 
            this.txtIdProductoDetalle.Location = new System.Drawing.Point(88, 141);
            this.txtIdProductoDetalle.Name = "txtIdProductoDetalle";
            this.txtIdProductoDetalle.Size = new System.Drawing.Size(50, 20);
            this.txtIdProductoDetalle.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(231, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(51, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // txtAgregarProducto
            // 
            this.txtAgregarProducto.Location = new System.Drawing.Point(88, 213);
            this.txtAgregarProducto.Name = "txtAgregarProducto";
            this.txtAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.txtAgregarProducto.TabIndex = 4;
            this.txtAgregarProducto.Text = "Agregar";
            this.txtAgregarProducto.UseVisualStyleBackColor = true;
            this.txtAgregarProducto.Click += new System.EventHandler(this.txtAgregarProducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // DetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAgregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdProductoDetalle);
            this.Controls.Add(this.lbIdProducto);
            this.Name = "DetallePedido";
            this.Text = "DetallePedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdProducto;
        private System.Windows.Forms.TextBox txtIdProductoDetalle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtAgregarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}