﻿namespace WindowsFormsAppGestaoHotel
{
    partial class FormConsultaQuartoDisponivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaQuartoDisponivel));
            this.label1 = new System.Windows.Forms.Label();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarQuartoDisp = new System.Windows.Forms.Button();
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeQSair = new System.Windows.Forms.DateTimePicker();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.labelSair = new System.Windows.Forms.Label();
            this.dateTimeQEntrar = new System.Windows.Forms.DateTimePicker();
            this.labelClasse = new System.Windows.Forms.Label();
            this.comboBoxclass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classeBindingSource, "Descricao", true));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quartos Disponiveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataSource = typeof(Models.Classe);
            // 
            // buttonBuscarQuartoDisp
            // 
            this.buttonBuscarQuartoDisp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBuscarQuartoDisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarQuartoDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarQuartoDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarQuartoDisp.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search_bk;
            this.buttonBuscarQuartoDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarQuartoDisp.Location = new System.Drawing.Point(653, 91);
            this.buttonBuscarQuartoDisp.Name = "buttonBuscarQuartoDisp";
            this.buttonBuscarQuartoDisp.Size = new System.Drawing.Size(101, 33);
            this.buttonBuscarQuartoDisp.TabIndex = 7;
            this.buttonBuscarQuartoDisp.Text = "Buscar";
            this.buttonBuscarQuartoDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarQuartoDisp.UseVisualStyleBackColor = false;
            this.buttonBuscarQuartoDisp.Click += new System.EventHandler(this.buttonBuscarQuartoDisp_Click);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // quartoDataGridView
            // 
            this.quartoDataGridView.AllowUserToAddRows = false;
            this.quartoDataGridView.AllowUserToDeleteRows = false;
            this.quartoDataGridView.AllowUserToOrderColumns = true;
            this.quartoDataGridView.AutoGenerateColumns = false;
            this.quartoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn5});
            this.quartoDataGridView.DataSource = this.quartoBindingSource;
            this.quartoDataGridView.Location = new System.Drawing.Point(10, 148);
            this.quartoDataGridView.Name = "quartoDataGridView";
            this.quartoDataGridView.ReadOnly = true;
            this.quartoDataGridView.RowHeadersWidth = 47;
            this.quartoDataGridView.Size = new System.Drawing.Size(746, 297);
            this.quartoDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor da diaria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Andar";
            this.dataGridViewTextBoxColumn9.HeaderText = "Andar";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dateTimeQSair
            // 
            this.dateTimeQSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeQSair.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeQSair.Location = new System.Drawing.Point(296, 93);
            this.dateTimeQSair.Name = "dateTimeQSair";
            this.dateTimeQSair.Size = new System.Drawing.Size(110, 24);
            this.dateTimeQSair.TabIndex = 4;
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrada.Location = new System.Drawing.Point(29, 95);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(63, 18);
            this.labelEntrada.TabIndex = 1;
            this.labelEntrada.Text = "Entrada:";
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSair.Location = new System.Drawing.Point(232, 95);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(49, 18);
            this.labelSair.TabIndex = 3;
            this.labelSair.Text = "Saída:";
            // 
            // dateTimeQEntrar
            // 
            this.dateTimeQEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeQEntrar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeQEntrar.Location = new System.Drawing.Point(110, 93);
            this.dateTimeQEntrar.Name = "dateTimeQEntrar";
            this.dateTimeQEntrar.Size = new System.Drawing.Size(109, 24);
            this.dateTimeQEntrar.TabIndex = 2;
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasse.Location = new System.Drawing.Point(423, 95);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(58, 18);
            this.labelClasse.TabIndex = 5;
            this.labelClasse.Text = "Classe:";
            // 
            // comboBoxclass
            // 
            this.comboBoxclass.DataSource = this.classeBindingSource;
            this.comboBoxclass.DisplayMember = "Descricao";
            this.comboBoxclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxclass.FormattingEnabled = true;
            this.comboBoxclass.Location = new System.Drawing.Point(492, 93);
            this.comboBoxclass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxclass.Name = "comboBoxclass";
            this.comboBoxclass.Size = new System.Drawing.Size(109, 25);
            this.comboBoxclass.TabIndex = 6;
            // 
            // FormConsultaQuartoDisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 456);
            this.Controls.Add(this.comboBoxclass);
            this.Controls.Add(this.labelClasse);
            this.Controls.Add(this.labelSair);
            this.Controls.Add(this.labelEntrada);
            this.Controls.Add(this.quartoDataGridView);
            this.Controls.Add(this.buttonBuscarQuartoDisp);
            this.Controls.Add(this.dateTimeQEntrar);
            this.Controls.Add(this.dateTimeQSair);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormConsultaQuartoDisponivel";
            this.Text = "Consulta de Quartos disponíveis";
            this.Load += new System.EventHandler(this.FormConsultaQuartoDisponivel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaQuartoDisponivel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarQuartoDisp;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private System.Windows.Forms.DataGridView quartoDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimeQSair;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.Label labelSair;
        private System.Windows.Forms.DateTimePicker dateTimeQEntrar;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.ComboBox comboBoxclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}