namespace ControlCuentas
{
    partial class GastoUI
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
            if (disposing && (components != null)) {
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
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDesde = new System.Windows.Forms.CheckBox();
            this.checkBoxHasta = new System.Windows.Forms.CheckBox();
            this.cbMedio = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            this.checkBoxMedio = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.checkBoxCategoria);
            this.gbAcciones.Controls.Add(this.cbCategoria);
            this.gbAcciones.Controls.Add(this.checkBoxMedio);
            this.gbAcciones.Controls.Add(this.cbMedio);
            this.gbAcciones.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(26, 31);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(310, 135);
            this.gbAcciones.TabIndex = 7;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Filtros:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(278, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxHasta);
            this.groupBox1.Controls.Add(this.checkBoxDesde);
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(342, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha gasto:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(404, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(530, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "Listar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtDesde
            // 
            this.dtDesde.Enabled = false;
            this.dtDesde.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(136, 45);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(137, 25);
            this.dtDesde.TabIndex = 0;
            // 
            // dtHasta
            // 
            this.dtHasta.Enabled = false;
            this.dtHasta.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(136, 76);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(137, 25);
            this.dtHasta.TabIndex = 1;
            // 
            // checkBoxDesde
            // 
            this.checkBoxDesde.AutoSize = true;
            this.checkBoxDesde.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesde.Location = new System.Drawing.Point(15, 49);
            this.checkBoxDesde.Name = "checkBoxDesde";
            this.checkBoxDesde.Size = new System.Drawing.Size(76, 21);
            this.checkBoxDesde.TabIndex = 2;
            this.checkBoxDesde.Text = "Desde:";
            this.checkBoxDesde.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasta
            // 
            this.checkBoxHasta.AutoSize = true;
            this.checkBoxHasta.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHasta.Location = new System.Drawing.Point(15, 80);
            this.checkBoxHasta.Name = "checkBoxHasta";
            this.checkBoxHasta.Size = new System.Drawing.Size(72, 21);
            this.checkBoxHasta.TabIndex = 3;
            this.checkBoxHasta.Text = "Hasta:";
            this.checkBoxHasta.UseVisualStyleBackColor = true;
            // 
            // cbMedio
            // 
            this.cbMedio.Enabled = false;
            this.cbMedio.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedio.FormattingEnabled = true;
            this.cbMedio.Location = new System.Drawing.Point(148, 47);
            this.cbMedio.Name = "cbMedio";
            this.cbMedio.Size = new System.Drawing.Size(121, 25);
            this.cbMedio.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Enabled = false;
            this.cbCategoria.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(148, 82);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 25);
            this.cbCategoria.TabIndex = 1;
            // 
            // checkBoxCategoria
            // 
            this.checkBoxCategoria.AutoSize = true;
            this.checkBoxCategoria.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCategoria.Location = new System.Drawing.Point(17, 80);
            this.checkBoxCategoria.Name = "checkBoxCategoria";
            this.checkBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.checkBoxCategoria.TabIndex = 5;
            this.checkBoxCategoria.Text = "Categoria:";
            this.checkBoxCategoria.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedio
            // 
            this.checkBoxMedio.AutoSize = true;
            this.checkBoxMedio.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMedio.Location = new System.Drawing.Point(17, 49);
            this.checkBoxMedio.Name = "checkBoxMedio";
            this.checkBoxMedio.Size = new System.Drawing.Size(74, 21);
            this.checkBoxMedio.TabIndex = 4;
            this.checkBoxMedio.Text = "Medio:";
            this.checkBoxMedio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 193);
            this.dataGridView1.TabIndex = 11;
            // 
            // GastoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GastoUI";
            this.Text = "Gastos";
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxHasta;
        private System.Windows.Forms.CheckBox checkBoxDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox checkBoxMedio;
        private System.Windows.Forms.ComboBox cbMedio;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}