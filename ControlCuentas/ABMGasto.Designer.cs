﻿namespace ControlCuentas
{
    partial class ABMGasto
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
            this.components = new System.ComponentModel.Container();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.selectListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxMedio = new System.Windows.Forms.CheckBox();
            this.cbMedio = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxHasta = new System.Windows.Forms.CheckBox();
            this.checkBoxDesde = new System.Windows.Forms.CheckBox();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoListViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectListItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoListViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioBindingSource)).BeginInit();
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
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.selectListItemBindingSource;
            this.cbCategoria.DisplayMember = "Desc";
            this.cbCategoria.Enabled = false;
            this.cbCategoria.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(148, 82);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 25);
            this.cbCategoria.TabIndex = 1;
            this.cbCategoria.ValueMember = "Id";
            // 
            // selectListItemBindingSource
            // 
            this.selectListItemBindingSource.DataSource = typeof(ControlCuentas.ERP.Entities.ViewModels.SelectListItem);
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
            // cbMedio
            // 
            this.cbMedio.DataSource = this.selectListItemBindingSource;
            this.cbMedio.DisplayMember = "Desc";
            this.cbMedio.Enabled = false;
            this.cbMedio.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedio.FormattingEnabled = true;
            this.cbMedio.Location = new System.Drawing.Point(148, 47);
            this.cbMedio.Name = "cbMedio";
            this.cbMedio.Size = new System.Drawing.Size(121, 25);
            this.cbMedio.TabIndex = 0;
            this.cbMedio.ValueMember = "Id";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(278, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(152, 193);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 33);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(26, 193);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 33);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(404, 193);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 33);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(530, 193);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 33);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGastoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subcategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gastoListViewModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(624, 193);
            this.dataGridView1.TabIndex = 11;
            // 
            // idGastoDataGridViewTextBoxColumn
            // 
            this.idGastoDataGridViewTextBoxColumn.DataPropertyName = "IdGasto";
            this.idGastoDataGridViewTextBoxColumn.HeaderText = "IdGasto";
            this.idGastoDataGridViewTextBoxColumn.Name = "idGastoDataGridViewTextBoxColumn";
            this.idGastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subcategoriaDataGridViewTextBoxColumn
            // 
            this.subcategoriaDataGridViewTextBoxColumn.DataPropertyName = "Subcategoria";
            this.subcategoriaDataGridViewTextBoxColumn.HeaderText = "Subcategoria";
            this.subcategoriaDataGridViewTextBoxColumn.Name = "subcategoriaDataGridViewTextBoxColumn";
            this.subcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gastoListViewModelBindingSource
            // 
            this.gastoListViewModelBindingSource.DataSource = typeof(ControlCuentas.ERP.Entities.ViewModels.GastoListViewModel);
            // 
            // medioBindingSource
            // 
            this.medioBindingSource.DataSource = typeof(ControlCuentas.ERP.DataAccess.Medio);
            // 
            // ABMGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "ABMGasto";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.GastoUI_Load);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectListItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoListViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxHasta;
        private System.Windows.Forms.CheckBox checkBoxDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox checkBoxMedio;
        private System.Windows.Forms.ComboBox cbMedio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gastoListViewModelBindingSource;
        private System.Windows.Forms.BindingSource medioBindingSource;
        private System.Windows.Forms.BindingSource selectListItemBindingSource;
    }
}