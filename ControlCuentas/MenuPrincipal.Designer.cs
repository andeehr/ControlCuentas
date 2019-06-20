namespace ControlCuentas
{
    partial class MenuPrincipal
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
            if (disposing && (components != null)) {
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
            this.gbDisponible = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCajaDeAhorro = new System.Windows.Forms.TextBox();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.gbDisponible.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDisponible
            // 
            this.gbDisponible.Controls.Add(this.tbTotal);
            this.gbDisponible.Controls.Add(this.label3);
            this.gbDisponible.Controls.Add(this.tbCajaDeAhorro);
            this.gbDisponible.Controls.Add(this.tbEfectivo);
            this.gbDisponible.Controls.Add(this.label2);
            this.gbDisponible.Controls.Add(this.label1);
            this.gbDisponible.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponible.Location = new System.Drawing.Point(297, 25);
            this.gbDisponible.Name = "gbDisponible";
            this.gbDisponible.Size = new System.Drawing.Size(300, 178);
            this.gbDisponible.TabIndex = 0;
            this.gbDisponible.TabStop = false;
            this.gbDisponible.Text = "Disponible";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(141, 117);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(121, 25);
            this.tbTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // tbCajaDeAhorro
            // 
            this.tbCajaDeAhorro.Enabled = false;
            this.tbCajaDeAhorro.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCajaDeAhorro.Location = new System.Drawing.Point(141, 80);
            this.tbCajaDeAhorro.Name = "tbCajaDeAhorro";
            this.tbCajaDeAhorro.Size = new System.Drawing.Size(121, 25);
            this.tbCajaDeAhorro.TabIndex = 3;
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.Enabled = false;
            this.tbEfectivo.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfectivo.Location = new System.Drawing.Point(141, 44);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Size = new System.Drawing.Size(121, 25);
            this.tbEfectivo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caja de ahorro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo:";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnEstadisticas);
            this.gbAcciones.Controls.Add(this.btnGastos);
            this.gbAcciones.Controls.Add(this.btnIngresos);
            this.gbAcciones.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(24, 25);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(228, 178);
            this.gbAcciones.TabIndex = 6;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(23, 123);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(120, 33);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnGastos
            // 
            this.btnGastos.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Location = new System.Drawing.Point(23, 84);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(120, 33);
            this.btnGastos.TabIndex = 1;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Location = new System.Drawing.Point(23, 45);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(120, 33);
            this.btnIngresos.TabIndex = 0;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 341);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbDisponible);
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.gbDisponible.ResumeLayout(false);
            this.gbDisponible.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDisponible;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCajaDeAhorro;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnIngresos;
    }
}

