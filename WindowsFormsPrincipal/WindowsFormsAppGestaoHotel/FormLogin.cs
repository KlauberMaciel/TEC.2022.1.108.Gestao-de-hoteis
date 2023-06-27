﻿using System;
using BLL;
using System.Windows.Forms;
using Models;
using Infra;

namespace WindowsFormsPrincipal1
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Gravar("Abrir a tela de login");
                new FuncionarioBLL().Autenticar(textBoxUsuario.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxEntrar_Click(null, null);
            }
            if (e.KeyCode == Keys.Up)
            {
                textBoxUsuario.Focus();
            }
        }
        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxSenha.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxSenha.Focus();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.F1)
            {
                linkLabelsuporte_LinkClicked(null, null);
            }
        }

        public void linkLabelsuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rangersonti.github.io/hotelogix-suporte/index.html");
        }

        private void buttonsSuporte_Click(object sender, EventArgs e)
        {
            linkLabelsuporte_LinkClicked(null,null);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (FormCadastroDeFuncionario frm = new FormCadastroDeFuncionario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
