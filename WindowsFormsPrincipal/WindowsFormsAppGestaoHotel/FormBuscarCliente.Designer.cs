﻿namespace WindowsFormsPrincipal1
{
    partial class FormBuscarCliente
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
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idSexoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.celularMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.Location = new System.Drawing.Point(21, 248);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(80, 25);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(35, 204);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(0, 154);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(102, 25);
            enderecoLabel.TabIndex = 10;
            enderecoLabel.Text = "Endereço:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_nascimentoLabel.Location = new System.Drawing.Point(374, 110);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(114, 25);
            data_nascimentoLabel.TabIndex = 8;
            data_nascimentoLabel.Text = "Data Nasc.:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(424, 65);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(64, 25);
            sexoLabel.TabIndex = 4;
            sexoLabel.Text = "Sexo:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(43, 110);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(58, 25);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(37, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 25);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel1.Location = new System.Drawing.Point(41, 24);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(60, 25);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Cód.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonCPF);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(624, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonTodos.Location = new System.Drawing.Point(5, 21);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(85, 25);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = false;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonCPF.Location = new System.Drawing.Point(216, 21);
            this.radioButtonCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(72, 25);
            this.radioButtonCPF.TabIndex = 2;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNome.Location = new System.Drawing.Point(119, 21);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(83, 25);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBuscar.Location = new System.Drawing.Point(5, 54);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(558, 30);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarCliente.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search_bk1;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(578, 54);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(40, 37);
            this.buttonBuscarCliente.TabIndex = 4;
            this.buttonBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.funcionarioDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(17, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(624, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóspedes cadastrados";
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AllowUserToAddRows = false;
            this.funcionarioDataGridView.AllowUserToDeleteRows = false;
            this.funcionarioDataGridView.AllowUserToOrderColumns = true;
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.ColumnHeadersHeight = 30;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.idSexoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.funcionarioDataGridView.DataSource = this.clienteBindingSource;
            this.funcionarioDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(5, 21);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.ReadOnly = true;
            this.funcionarioDataGridView.RowHeadersVisible = false;
            this.funcionarioDataGridView.RowHeadersWidth = 10;
            this.funcionarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.funcionarioDataGridView.RowTemplate.Height = 24;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(613, 266);
            this.funcionarioDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            dataGridViewCellStyle1.NullValue = "0";
            this.cPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            this.enderecoDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascimentoDataGridViewTextBoxColumn.Visible = false;
            this.datanascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSexoDataGridViewTextBoxColumn
            // 
            this.idSexoDataGridViewTextBoxColumn.DataPropertyName = "IdSexo";
            this.idSexoDataGridViewTextBoxColumn.HeaderText = "IdSexo";
            this.idSexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSexoDataGridViewTextBoxColumn.Name = "idSexoDataGridViewTextBoxColumn";
            this.idSexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSexoDataGridViewTextBoxColumn.Visible = false;
            this.idSexoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            this.sexoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Hospede);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.data_nascimentoMaskedTextBox);
            this.groupBox4.Controls.Add(this.idSexoTextBox);
            this.groupBox4.Controls.Add(this.nomeTextBox1);
            this.groupBox4.Controls.Add(this.cPFMaskedTextBox1);
            this.groupBox4.Controls.Add(this.emailTextBox1);
            this.groupBox4.Controls.Add(this.enderecoTextBox1);
            this.groupBox4.Controls.Add(celularLabel);
            this.groupBox4.Controls.Add(emailLabel);
            this.groupBox4.Controls.Add(idLabel1);
            this.groupBox4.Controls.Add(this.idTextBox1);
            this.groupBox4.Controls.Add(enderecoLabel);
            this.groupBox4.Controls.Add(this.celularMaskedTextBox1);
            this.groupBox4.Controls.Add(data_nascimentoLabel);
            this.groupBox4.Controls.Add(sexoLabel);
            this.groupBox4.Controls.Add(cPFLabel);
            this.groupBox4.Controls.Add(nomeLabel);
            this.groupBox4.Location = new System.Drawing.Point(17, 454);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(624, 288);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Pessoais";
            // 
            // data_nascimentoMaskedTextBox
            // 
            this.data_nascimentoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_nascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Data_nascimento", true));
            this.data_nascimentoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nascimentoMaskedTextBox.Location = new System.Drawing.Point(494, 105);
            this.data_nascimentoMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.data_nascimentoMaskedTextBox.Name = "data_nascimentoMaskedTextBox";
            this.data_nascimentoMaskedTextBox.ReadOnly = true;
            this.data_nascimentoMaskedTextBox.Size = new System.Drawing.Size(124, 30);
            this.data_nascimentoMaskedTextBox.TabIndex = 9;
            this.data_nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // idSexoTextBox
            // 
            this.idSexoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idSexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Sexo", true));
            this.idSexoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSexoTextBox.Location = new System.Drawing.Point(494, 60);
            this.idSexoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSexoTextBox.Name = "idSexoTextBox";
            this.idSexoTextBox.ReadOnly = true;
            this.idSexoTextBox.Size = new System.Drawing.Size(124, 30);
            this.idSexoTextBox.TabIndex = 5;
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox1.Location = new System.Drawing.Point(107, 63);
            this.nomeTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.ReadOnly = true;
            this.nomeTextBox1.Size = new System.Drawing.Size(250, 30);
            this.nomeTextBox1.TabIndex = 3;
            // 
            // cPFMaskedTextBox1
            // 
            this.cPFMaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPFMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFMaskedTextBox1.Location = new System.Drawing.Point(107, 105);
            this.cPFMaskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPFMaskedTextBox1.Mask = "000,000,000-00";
            this.cPFMaskedTextBox1.Name = "cPFMaskedTextBox1";
            this.cPFMaskedTextBox1.ReadOnly = true;
            this.cPFMaskedTextBox1.Size = new System.Drawing.Size(250, 30);
            this.cPFMaskedTextBox1.TabIndex = 7;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox1.Location = new System.Drawing.Point(107, 204);
            this.emailTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.ReadOnly = true;
            this.emailTextBox1.Size = new System.Drawing.Size(445, 30);
            this.emailTextBox1.TabIndex = 13;
            // 
            // enderecoTextBox1
            // 
            this.enderecoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox1.Location = new System.Drawing.Point(107, 154);
            this.enderecoTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enderecoTextBox1.Name = "enderecoTextBox1";
            this.enderecoTextBox1.ReadOnly = true;
            this.enderecoTextBox1.Size = new System.Drawing.Size(445, 30);
            this.enderecoTextBox1.TabIndex = 11;
            // 
            // idTextBox1
            // 
            this.idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id", true));
            this.idTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox1.Location = new System.Drawing.Point(107, 19);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.ReadOnly = true;
            this.idTextBox1.Size = new System.Drawing.Size(50, 30);
            this.idTextBox1.TabIndex = 1;
            this.idTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // celularMaskedTextBox1
            // 
            this.celularMaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Celular", true));
            this.celularMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMaskedTextBox1.Location = new System.Drawing.Point(107, 248);
            this.celularMaskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.celularMaskedTextBox1.Mask = "(99) 00000-0000";
            this.celularMaskedTextBox1.Name = "celularMaskedTextBox1";
            this.celularMaskedTextBox1.ReadOnly = true;
            this.celularMaskedTextBox1.Size = new System.Drawing.Size(181, 30);
            this.celularMaskedTextBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(520, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.BackColor = System.Drawing.Color.Gold;
            this.buttonAlterarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarCliente.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAlterarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarCliente.Image")));
            this.buttonAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterarCliente.Location = new System.Drawing.Point(249, 758);
            this.buttonAlterarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(176, 41);
            this.buttonAlterarCliente.TabIndex = 4;
            this.buttonAlterarCliente.Text = "ALTERAR";
            this.buttonAlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterarCliente.UseVisualStyleBackColor = false;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(87)))));
            this.buttonExcluirCliente.FlatAppearance.BorderSize = 0;
            this.buttonExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirCliente.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirCliente.ForeColor = System.Drawing.Color.White;
            this.buttonExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirCliente.Image")));
            this.buttonExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirCliente.Location = new System.Drawing.Point(441, 758);
            this.buttonExcluirCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(200, 41);
            this.buttonExcluirCliente.TabIndex = 5;
            this.buttonExcluirCliente.Text = "EXCLUIR";
            this.buttonExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirCliente.UseVisualStyleBackColor = false;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            this.buttonExcluirCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExcluirCliente_KeyDown);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(156)))));
            this.buttonAdicionarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarCliente.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarCliente.Image")));
            this.buttonAdicionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(22, 758);
            this.buttonAdicionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(200, 41);
            this.buttonAdicionarCliente.TabIndex = 3;
            this.buttonAdicionarCliente.Text = "ADICIONAR";
            this.buttonAdicionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionarCliente.UseVisualStyleBackColor = false;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataSource = typeof(Models.Sexo);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 810);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(594, 803);
            this.Name = "FormBuscarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Consulta de Hóspedes";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarCliente_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox enderecoTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
        private System.Windows.Forms.TextBox idSexoTextBox;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.MaskedTextBox data_nascimentoMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}