namespace EDA3_ControlEscolar
{
    partial class frmProfesor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.profesorDataViewGrid = new System.Windows.Forms.DataGridView();
            this.idprofesoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDA_3DataSet = new EDA3_ControlEscolar.EDA_3DataSet();
            this.txt_profesore = new System.Windows.Forms.TextBox();
            this.profesoresTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.profesoresTableAdapter();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.personasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorDataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnActulizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(32, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 271);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "id_persona";
            // 
            // txtNomina
            // 
            this.txtNomina.Location = new System.Drawing.Point(24, 40);
            this.txtNomina.Name = "txtNomina";
            this.txtNomina.Size = new System.Drawing.Size(146, 20);
            this.txtNomina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nomina";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(24, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID Profesore";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Mostrar Informacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profesorDataViewGrid
            // 
            this.profesorDataViewGrid.AutoGenerateColumns = false;
            this.profesorDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profesorDataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprofesoresDataGridViewTextBoxColumn,
            this.nominaDataGridViewTextBoxColumn,
            this.idpersonaDataGridViewTextBoxColumn});
            this.profesorDataViewGrid.DataSource = this.profesoresBindingSource;
            this.profesorDataViewGrid.Location = new System.Drawing.Point(296, 39);
            this.profesorDataViewGrid.Name = "profesorDataViewGrid";
            this.profesorDataViewGrid.ReadOnly = true;
            this.profesorDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profesorDataViewGrid.Size = new System.Drawing.Size(366, 297);
            this.profesorDataViewGrid.TabIndex = 15;
            this.profesorDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profesorDataViewGrid_CellClick);
            // 
            // idprofesoresDataGridViewTextBoxColumn
            // 
            this.idprofesoresDataGridViewTextBoxColumn.DataPropertyName = "id_profesores";
            this.idprofesoresDataGridViewTextBoxColumn.HeaderText = "id_profesores";
            this.idprofesoresDataGridViewTextBoxColumn.Name = "idprofesoresDataGridViewTextBoxColumn";
            this.idprofesoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominaDataGridViewTextBoxColumn
            // 
            this.nominaDataGridViewTextBoxColumn.DataPropertyName = "nomina";
            this.nominaDataGridViewTextBoxColumn.HeaderText = "nomina";
            this.nominaDataGridViewTextBoxColumn.Name = "nominaDataGridViewTextBoxColumn";
            this.nominaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpersonaDataGridViewTextBoxColumn
            // 
            this.idpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.Name = "idpersonaDataGridViewTextBoxColumn";
            this.idpersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "profesores";
            this.profesoresBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // eDA_3DataSet
            // 
            this.eDA_3DataSet.DataSetName = "EDA_3DataSet";
            this.eDA_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_profesore
            // 
            this.txt_profesore.Location = new System.Drawing.Point(47, 349);
            this.txt_profesore.Name = "txt_profesore";
            this.txt_profesore.Size = new System.Drawing.Size(146, 20);
            this.txt_profesore.TabIndex = 14;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(105, 162);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(75, 23);
            this.btnActulizar.TabIndex = 11;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.personasBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id_persona";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.profesorDataViewGrid);
            this.Controls.Add(this.txt_profesore);
            this.Name = "frmProfesor";
            this.Text = "frmProfesor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProfesor_FormClosed);
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorDataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView profesorDataViewGrid;
        private System.Windows.Forms.TextBox txt_profesore;
        private EDA_3DataSet eDA_3DataSet;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private EDA_3DataSetTableAdapters.profesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprofesoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EDA_3DataSetTableAdapters.personasTableAdapter personasTableAdapter;
    }
}