namespace EDA3_ControlEscolar
{
    partial class frmCalificaciones
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
            this.components = new System.ComponentModel.Container();
            this.BotonDataViewGrid = new System.Windows.Forms.Button();
            this.CalificacionDataViewGrid = new System.Windows.Forms.DataGridView();
            this.idcalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eDA_3DataSet = new EDA3_ControlEscolar.EDA_3DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_calificacionID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_calificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.carreasmateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carreas_materiasTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.carreas_materiasTableAdapter();
            this.calificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calificacionesTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.calificacionesTableAdapter();
            this.calificacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.alumnosTableAdapter();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.materiasTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionDataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carreasmateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonDataViewGrid
            // 
            this.BotonDataViewGrid.Location = new System.Drawing.Point(304, 388);
            this.BotonDataViewGrid.Name = "BotonDataViewGrid";
            this.BotonDataViewGrid.Size = new System.Drawing.Size(171, 23);
            this.BotonDataViewGrid.TabIndex = 24;
            this.BotonDataViewGrid.Text = "Mostrar informacion";
            this.BotonDataViewGrid.UseVisualStyleBackColor = true;
            // 
            // CalificacionDataViewGrid
            // 
            this.CalificacionDataViewGrid.AllowUserToOrderColumns = true;
            this.CalificacionDataViewGrid.AutoGenerateColumns = false;
            this.CalificacionDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalificacionDataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcalificacion,
            this.calificacionDataGridViewTextBoxColumn,
            this.idalumnoDataGridViewTextBoxColumn,
            this.idmateriaDataGridViewTextBoxColumn});
            this.CalificacionDataViewGrid.DataSource = this.calificacionesBindingSource2;
            this.CalificacionDataViewGrid.Location = new System.Drawing.Point(301, 36);
            this.CalificacionDataViewGrid.Name = "CalificacionDataViewGrid";
            this.CalificacionDataViewGrid.ReadOnly = true;
            this.CalificacionDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CalificacionDataViewGrid.Size = new System.Drawing.Size(445, 334);
            this.CalificacionDataViewGrid.TabIndex = 23;
            this.CalificacionDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalificacionDataViewGrid_CellClick);
            // 
            // idcalificacion
            // 
            this.idcalificacion.DataPropertyName = "id_calificacion";
            this.idcalificacion.HeaderText = "id_calificacion";
            this.idcalificacion.Name = "idcalificacion";
            this.idcalificacion.ReadOnly = true;
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            this.calificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            this.idmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calificacionesBindingSource2
            // 
            this.calificacionesBindingSource2.DataMember = "calificaciones";
            this.calificacionesBindingSource2.DataSource = this.eDA_3DataSet;
            // 
            // eDA_3DataSet
            // 
            this.eDA_3DataSet.DataSetName = "EDA_3DataSet";
            this.eDA_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_calificacionID);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(21, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 22;
            // 
            // txt_calificacionID
            // 
            this.txt_calificacionID.Location = new System.Drawing.Point(16, 30);
            this.txt_calificacionID.Name = "txt_calificacionID";
            this.txt_calificacionID.Size = new System.Drawing.Size(146, 20);
            this.txt_calificacionID.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Calificacion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.comboBoxMateria);
            this.panel1.Controls.Add(this.cmbAlumno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_calificacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(21, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 271);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "id_materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "id_alumno";
            // 
            // txt_calificacion
            // 
            this.txt_calificacion.Location = new System.Drawing.Point(16, 40);
            this.txt_calificacion.Name = "txt_calificacion";
            this.txt_calificacion.Size = new System.Drawing.Size(149, 20);
            this.txt_calificacion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "calificacion";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(21, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carreasmateriasBindingSource
            // 
            this.carreasmateriasBindingSource.DataMember = "carreas_materias";
            this.carreasmateriasBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // carreas_materiasTableAdapter
            // 
            this.carreas_materiasTableAdapter.ClearBeforeFill = true;
            // 
            // calificacionesBindingSource
            // 
            this.calificacionesBindingSource.DataMember = "calificaciones";
            this.calificacionesBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // calificacionesTableAdapter
            // 
            this.calificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // calificacionesBindingSource1
            // 
            this.calificacionesBindingSource1.DataMember = "calificaciones";
            this.calificacionesBindingSource1.DataSource = this.eDA_3DataSet;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DataSource = this.alumnosBindingSource;
            this.cmbAlumno.DisplayMember = "matricula";
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(15, 117);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(150, 21);
            this.cmbAlumno.TabIndex = 12;
            this.cmbAlumno.ValueMember = "id_alumno";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.DataSource = this.materiasBindingSource;
            this.comboBoxMateria.DisplayMember = "nombre";
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(16, 190);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(149, 21);
            this.comboBoxMateria.TabIndex = 13;
            this.comboBoxMateria.ValueMember = "id_materia";
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(102, 226);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(73, 20);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonDataViewGrid);
            this.Controls.Add(this.CalificacionDataViewGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalificaciones";
            this.Text = "frmCalificaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalificaciones_FormClosed);
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionDataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carreasmateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonDataViewGrid;
        private System.Windows.Forms.DataGridView CalificacionDataViewGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_calificacionID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_calificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private EDA_3DataSet eDA_3DataSet;
        private System.Windows.Forms.BindingSource carreasmateriasBindingSource;
        private EDA_3DataSetTableAdapters.carreas_materiasTableAdapter carreas_materiasTableAdapter;
        private System.Windows.Forms.BindingSource calificacionesBindingSource;
        private EDA_3DataSetTableAdapters.calificacionesTableAdapter calificacionesTableAdapter;
        private System.Windows.Forms.BindingSource calificacionesBindingSource1;
        private System.Windows.Forms.BindingSource calificacionesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private EDA_3DataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private EDA_3DataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
    }
}