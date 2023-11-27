namespace EDA3_ControlEscolar
{
    partial class frmAlumnos
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
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDA_3DataSet = new EDA3_ControlEscolar.EDA_3DataSet();
            this.comboBoxPersona = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlumnosDataViewGrid = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.alumnosTableAdapter();
            this.BotonDataViewGrid = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.personasTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.personasTableAdapter();
            this.carrerasTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.carrerasTableAdapter();
            this.btnACtulizar = new System.Windows.Forms.Button();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnACtulizar);
            this.panel1.Controls.Add(this.comboBoxCarrera);
            this.panel1.Controls.Add(this.comboBoxPersona);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMatricula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 302);
            this.panel1.TabIndex = 17;
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.DataSource = this.carrerasBindingSource;
            this.comboBoxCarrera.DisplayMember = "nombre";
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Location = new System.Drawing.Point(24, 193);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCarrera.TabIndex = 13;
            this.comboBoxCarrera.ValueMember = "id_carreras";
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "carreras";
            this.carrerasBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // eDA_3DataSet
            // 
            this.eDA_3DataSet.DataSetName = "EDA_3DataSet";
            this.eDA_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxPersona
            // 
            this.comboBoxPersona.DataSource = this.personasBindingSource;
            this.comboBoxPersona.DisplayMember = "nombre";
            this.comboBoxPersona.FormattingEnabled = true;
            this.comboBoxPersona.Location = new System.Drawing.Point(24, 39);
            this.comboBoxPersona.Name = "comboBoxPersona";
            this.comboBoxPersona.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPersona.TabIndex = 12;
            this.comboBoxPersona.ValueMember = "id_persona";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id_carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(24, 111);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(146, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id_persona";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(57, 225);
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
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID alumno";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboID);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-1, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 176);
            this.panel2.TabIndex = 18;
            // 
            // AlumnosDataViewGrid
            // 
            this.AlumnosDataViewGrid.AllowUserToOrderColumns = true;
            this.AlumnosDataViewGrid.AutoGenerateColumns = false;
            this.AlumnosDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosDataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.idpersonaDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.idcarreraDataGridViewTextBoxColumn});
            this.AlumnosDataViewGrid.DataSource = this.alumnosBindingSource;
            this.AlumnosDataViewGrid.Location = new System.Drawing.Point(300, 0);
            this.AlumnosDataViewGrid.Name = "AlumnosDataViewGrid";
            this.AlumnosDataViewGrid.ReadOnly = true;
            this.AlumnosDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlumnosDataViewGrid.Size = new System.Drawing.Size(478, 334);
            this.AlumnosDataViewGrid.TabIndex = 19;
            this.AlumnosDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlumnosDataViewGrid_CellClick);
            this.AlumnosDataViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlumnosDataViewGrid_CellContentClick);
            // 
            // id_alumno
            // 
            this.id_alumno.DataPropertyName = "id_alumno";
            this.id_alumno.HeaderText = "id_alumno";
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.ReadOnly = true;
            // 
            // idpersonaDataGridViewTextBoxColumn
            // 
            this.idpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.Name = "idpersonaDataGridViewTextBoxColumn";
            this.idpersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcarreraDataGridViewTextBoxColumn
            // 
            this.idcarreraDataGridViewTextBoxColumn.DataPropertyName = "id_carrera";
            this.idcarreraDataGridViewTextBoxColumn.HeaderText = "id_carrera";
            this.idcarreraDataGridViewTextBoxColumn.Name = "idcarreraDataGridViewTextBoxColumn";
            this.idcarreraDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BotonDataViewGrid
            // 
            this.BotonDataViewGrid.Location = new System.Drawing.Point(295, 351);
            this.BotonDataViewGrid.Name = "BotonDataViewGrid";
            this.BotonDataViewGrid.Size = new System.Drawing.Size(171, 23);
            this.BotonDataViewGrid.TabIndex = 20;
            this.BotonDataViewGrid.Text = "Mostrar informacion";
            this.BotonDataViewGrid.UseVisualStyleBackColor = true;
            this.BotonDataViewGrid.Click += new System.EventHandler(this.BotonDataViewGrid_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(804, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "Asignar calificacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(804, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Asignar Grupo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // btnACtulizar
            // 
            this.btnACtulizar.Location = new System.Drawing.Point(138, 225);
            this.btnACtulizar.Name = "btnACtulizar";
            this.btnACtulizar.Size = new System.Drawing.Size(109, 24);
            this.btnACtulizar.TabIndex = 14;
            this.btnACtulizar.Text = "Actulizar";
            this.btnACtulizar.UseVisualStyleBackColor = true;
            this.btnACtulizar.Click += new System.EventHandler(this.btnACtulizar_Click);
            // 
            // comboID
            // 
            this.comboID.DataSource = this.alumnosBindingSource2;
            this.comboID.DisplayMember = "matricula";
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(16, 29);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(197, 21);
            this.comboID.TabIndex = 17;
            this.comboID.ValueMember = "id_alumno";
            // 
            // alumnosBindingSource1
            // 
            this.alumnosBindingSource1.DataMember = "alumnos";
            this.alumnosBindingSource1.DataSource = this.eDA_3DataSet;
            // 
            // alumnosBindingSource2
            // 
            this.alumnosBindingSource2.DataMember = "alumnos";
            this.alumnosBindingSource2.DataSource = this.eDA_3DataSet;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BotonDataViewGrid);
            this.Controls.Add(this.AlumnosDataViewGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAlumnos_FormClosed);
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AlumnosDataViewGrid;
        private EDA_3DataSet eDA_3DataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private EDA_3DataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button BotonDataViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxPersona;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EDA_3DataSetTableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private EDA_3DataSetTableAdapters.carrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.Button btnACtulizar;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.BindingSource alumnosBindingSource1;
        private System.Windows.Forms.BindingSource alumnosBindingSource2;
    }
}