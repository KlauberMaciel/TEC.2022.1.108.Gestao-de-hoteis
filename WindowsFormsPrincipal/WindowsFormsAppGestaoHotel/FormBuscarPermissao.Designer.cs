﻿namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarPermissao
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
            System.Windows.Forms.Label nomeGrupoLabel;
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarPermissao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.grupoFuncionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeGrupoTextBox1 = new System.Windows.Forms.TextBox();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(14, 44);
            nomeGrupoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(58, 13);
            nomeGrupoLabel.TabIndex = 2;
            nomeGrupoLabel.Text = "Descrição:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(41, 21);
            idLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(32, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Cód.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonDescricao);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarPermissao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(431, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonTodos.Location = new System.Drawing.Point(10, 17);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(72, 22);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonDescricao.Location = new System.Drawing.Point(95, 17);
            this.radioButtonDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(95, 22);
            this.radioButtonDescricao.TabIndex = 1;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 55);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(382, 26);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBuscarPermissao.FlatAppearance.BorderSize = 0;
            this.buttonBuscarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarPermissao.Image")));
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(397, 52);
            this.buttonBuscarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarPermissao.MaximumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarPermissao.MinimumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarPermissao.TabIndex = 3;
            this.buttonBuscarPermissao.UseVisualStyleBackColor = false;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // grupoFuncionarioDataGridView
            // 
            this.grupoFuncionarioDataGridView.AllowUserToAddRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoFuncionarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoFuncionarioDataGridView.AutoGenerateColumns = false;
            this.grupoFuncionarioDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grupoFuncionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoFuncionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn});
            this.grupoFuncionarioDataGridView.DataSource = this.permissaoBindingSource;
            this.grupoFuncionarioDataGridView.Location = new System.Drawing.Point(4, 17);
            this.grupoFuncionarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.grupoFuncionarioDataGridView.Name = "grupoFuncionarioDataGridView";
            this.grupoFuncionarioDataGridView.ReadOnly = true;
            this.grupoFuncionarioDataGridView.RowHeadersVisible = false;
            this.grupoFuncionarioDataGridView.RowHeadersWidth = 51;
            this.grupoFuncionarioDataGridView.RowTemplate.Height = 24;
            this.grupoFuncionarioDataGridView.Size = new System.Drawing.Size(416, 206);
            this.grupoFuncionarioDataGridView.TabIndex = 8;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.idTextBox);
            this.groupBox5.Controls.Add(this.nomeGrupoTextBox1);
            this.groupBox5.Controls.Add(nomeGrupoLabel);
            this.groupBox5.Controls.Add(idLabel1);
            this.groupBox5.Location = new System.Drawing.Point(11, 346);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(424, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dados do Acesso";
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(76, 19);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(38, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nomeGrupoTextBox1
            // 
            this.nomeGrupoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeGrupoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.nomeGrupoTextBox1.Location = new System.Drawing.Point(76, 42);
            this.nomeGrupoTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.nomeGrupoTextBox1.Multiline = true;
            this.nomeGrupoTextBox1.Name = "nomeGrupoTextBox1";
            this.nomeGrupoTextBox1.ReadOnly = true;
            this.nomeGrupoTextBox1.Size = new System.Drawing.Size(325, 49);
            this.nomeGrupoTextBox1.TabIndex = 3;
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirPermissao.Image")));
            this.buttonExcluirPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(315, 459);
            this.buttonExcluirPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(120, 33);
            this.buttonExcluirPermissao.TabIndex = 12;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirPermissao.UseVisualStyleBackColor = false;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonAlterarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarPermissao.Image")));
            this.buttonAlterarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(167, 459);
            this.buttonAlterarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(120, 33);
            this.buttonAlterarPermissao.TabIndex = 11;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarPermissao.UseVisualStyleBackColor = false;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarPermissao.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarPermissao.Image")));
            this.buttonAdicionarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(15, 459);
            this.buttonAdicionarPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(128, 33);
            this.buttonAdicionarPermissao.TabIndex = 10;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = false;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grupoFuncionarioDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(11, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(424, 227);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acessos cadastrados";
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(446, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 542);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 542);
            this.Name = "FormBuscarPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HOTELOGIX - Consulta de Acessos";
            this.Load += new System.EventHandler(this.FormBuscarPermissao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoFuncionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.DataGridView grupoFuncionarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeGrupoTextBox1;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}