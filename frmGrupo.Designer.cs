namespace EDA3_ControlEscolar
{
    partial class frmGrupo
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
            this.GrupoDataViewGrid = new System.Windows.Forms.DataGridView();
            this.idgrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDA_3DataSet = new EDA3_ControlEscolar.EDA_3DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_GrupoID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Periodo = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gruposTableAdapter = new EDA3_ControlEscolar.EDA_3DataSetTableAdapters.gruposTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoDataViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonDataViewGrid
            // 
            this.BotonDataViewGrid.Location = new System.Drawing.Point(310, 389);
            this.BotonDataViewGrid.Name = "BotonDataViewGrid";
            this.BotonDataViewGrid.Size = new System.Drawing.Size(171, 23);
            this.BotonDataViewGrid.TabIndex = 28;
            this.BotonDataViewGrid.Text = "Mostrar informacion";
            this.BotonDataViewGrid.UseVisualStyleBackColor = true;
            // 
            // GrupoDataViewGrid
            // 
            this.GrupoDataViewGrid.AllowUserToOrderColumns = true;
            this.GrupoDataViewGrid.AutoGenerateColumns = false;
            this.GrupoDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrupoDataViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgrupoDataGridViewTextBoxColumn,
            this.semestreDataGridViewTextBoxColumn,
            this.periodoDataGridViewTextBoxColumn});
            this.GrupoDataViewGrid.DataSource = this.gruposBindingSource;
            this.GrupoDataViewGrid.Location = new System.Drawing.Point(310, 36);
            this.GrupoDataViewGrid.Name = "GrupoDataViewGrid";
            this.GrupoDataViewGrid.ReadOnly = true;
            this.GrupoDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrupoDataViewGrid.Size = new System.Drawing.Size(352, 334);
            this.GrupoDataViewGrid.TabIndex = 27;
            this.GrupoDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrupoDataViewGrid_CellClick);
            // 
            // idgrupoDataGridViewTextBoxColumn
            // 
            this.idgrupoDataGridViewTextBoxColumn.DataPropertyName = "id_grupo";
            this.idgrupoDataGridViewTextBoxColumn.HeaderText = "id_grupo";
            this.idgrupoDataGridViewTextBoxColumn.Name = "idgrupoDataGridViewTextBoxColumn";
            this.idgrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semestreDataGridViewTextBoxColumn
            // 
            this.semestreDataGridViewTextBoxColumn.DataPropertyName = "semestre";
            this.semestreDataGridViewTextBoxColumn.HeaderText = "semestre";
            this.semestreDataGridViewTextBoxColumn.Name = "semestreDataGridViewTextBoxColumn";
            this.semestreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "periodo";
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            this.periodoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "grupos";
            this.gruposBindingSource.DataSource = this.eDA_3DataSet;
            // 
            // eDA_3DataSet
            // 
            this.eDA_3DataSet.DataSetName = "EDA_3DataSet";
            this.eDA_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_GrupoID);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(21, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 26;
            // 
            // txt_GrupoID
            // 
            this.txt_GrupoID.Location = new System.Drawing.Point(16, 30);
            this.txt_GrupoID.Name = "txt_GrupoID";
            this.txt_GrupoID.Size = new System.Drawing.Size(146, 20);
            this.txt_GrupoID.TabIndex = 14;
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
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID grupo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Periodo);
            this.panel1.Controls.Add(this.txtSemestre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(21, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 271);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Periodo";
            // 
            // txt_Periodo
            // 
            this.txt_Periodo.Location = new System.Drawing.Point(24, 111);
            this.txt_Periodo.Name = "txt_Periodo";
            this.txt_Periodo.Size = new System.Drawing.Size(146, 20);
            this.txt_Periodo.TabIndex = 5;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(24, 40);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(146, 20);
            this.txtSemestre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "semestre";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(18, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonDataViewGrid);
            this.Controls.Add(this.GrupoDataViewGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGrupo";
            this.Text = "frmGrupo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGrupo_FormClosed);
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoDataViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDA_3DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonDataViewGrid;
        private System.Windows.Forms.DataGridView GrupoDataViewGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_GrupoID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Periodo;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private EDA_3DataSet eDA_3DataSet;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private EDA_3DataSetTableAdapters.gruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}