﻿using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroDeFuncionario : Form
    {
        public int Id;
        public FormCadastroDeFuncionario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
                funcionarioBindingSource.EndEdit();
                if (Id == 0)
                    funcionarioBLL.Inserir((Funcionario)funcionarioBindingSource.Current, textBoxConfirmarSenha.Text);
                else
                    if(senhaTextBox.Modified == true)
                        funcionarioBLL.AlteraracaoComSenha((Funcionario)funcionarioBindingSource.Current, textBoxConfirmarSenha.Text);
                    else
                        funcionarioBLL.Alterar((Funcionario)funcionarioBindingSource.Current, textBoxConfirmarSenha.Text);
                MessageBox.Show("Registro salvo com sucesso!");
                //Close();
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroDeFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    funcionarioBindingSource.AddNew();
                else
                {
                    tituloLabel.Text = "Editar Funcionário";
                    funcionarioBindingSource.DataSource = new FuncionarioBLL().BuscarPorId(Id);
                }

                sexoBindingSource.DataSource = new SexoBLL().BuscarPorTodos();
                comboBox1.Text = ((Funcionario)funcionarioBindingSource.Current).Sexo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroDeFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonCancelarCadastro_Click(null, null);
            }
        }
    }
}
