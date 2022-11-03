namespace WindowsPresentacionColecciones
{
    partial class Form1
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
            this.btnGuardarAlumnosLista = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lstPrecioProducto = new System.Windows.Forms.ListBox();
            this.btnCrearClientes = new System.Windows.Forms.Button();
            this.btnCrearEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarAlumnosLista
            // 
            this.btnGuardarAlumnosLista.Location = new System.Drawing.Point(102, 53);
            this.btnGuardarAlumnosLista.Name = "btnGuardarAlumnosLista";
            this.btnGuardarAlumnosLista.Size = new System.Drawing.Size(164, 36);
            this.btnGuardarAlumnosLista.TabIndex = 0;
            this.btnGuardarAlumnosLista.Text = "Guardar productos en Lista";
            this.btnGuardarAlumnosLista.UseVisualStyleBackColor = true;
            this.btnGuardarAlumnosLista.Click += new System.EventHandler(this.btnGuardarAlumnosLista_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(312, 53);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(172, 36);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(102, 136);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(266, 225);
            this.gridProductos.TabIndex = 2;
            // 
            // lstPrecioProducto
            // 
            this.lstPrecioProducto.FormattingEnabled = true;
            this.lstPrecioProducto.Location = new System.Drawing.Point(518, 136);
            this.lstPrecioProducto.Name = "lstPrecioProducto";
            this.lstPrecioProducto.Size = new System.Drawing.Size(120, 95);
            this.lstPrecioProducto.TabIndex = 3;
            // 
            // btnCrearClientes
            // 
            this.btnCrearClientes.Location = new System.Drawing.Point(518, 37);
            this.btnCrearClientes.Name = "btnCrearClientes";
            this.btnCrearClientes.Size = new System.Drawing.Size(155, 23);
            this.btnCrearClientes.TabIndex = 4;
            this.btnCrearClientes.Text = "Crear Clientes";
            this.btnCrearClientes.UseVisualStyleBackColor = true;
            this.btnCrearClientes.Click += new System.EventHandler(this.btnCrearClientes_Click);
            // 
            // btnCrearEmpleados
            // 
            this.btnCrearEmpleados.Location = new System.Drawing.Point(518, 87);
            this.btnCrearEmpleados.Name = "btnCrearEmpleados";
            this.btnCrearEmpleados.Size = new System.Drawing.Size(155, 23);
            this.btnCrearEmpleados.TabIndex = 5;
            this.btnCrearEmpleados.Text = "Crear Empleados";
            this.btnCrearEmpleados.UseVisualStyleBackColor = true;
            this.btnCrearEmpleados.Click += new System.EventHandler(this.btnCrearEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEmpleados);
            this.Controls.Add(this.btnCrearClientes);
            this.Controls.Add(this.lstPrecioProducto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardarAlumnosLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAlumnosLista;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.ListBox lstPrecioProducto;
        private System.Windows.Forms.Button btnCrearClientes;
        private System.Windows.Forms.Button btnCrearEmpleados;
    }
}

