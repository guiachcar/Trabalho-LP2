﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Controller;
using ConsultiBETA.Model;

namespace ConsultiBETA
{
    public partial class FormLogin : Form
    {
        frm_splash frm_splash;
        public static int usuarioLogado;
        public static string nivelAcesso;
        public static string usuarioLogadoNome;

       
        public FormLogin()
        {
            InitializeComponent();
        }
        public FormLogin(frm_splash frm_splash1)
        {
            frm_splash = frm_splash1;
            InitializeComponent();
            txtSenha.MaxLength = 10;
            txtSenha.PasswordChar = '*';
        }
        protected bool ValidarCampos()
        {
            if(txUsuario.TextLength != 11 || txtSenha.TextLength < 4)
            {
                MessageBox.Show("Favor preeencher os campos corrretamente, CPF somente numeros e senha maior que 4 digitos", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtSenha.Text = "";
                lbAguarde.Visible = false;
                btCancelar.Visible = true;
                btEntrar.Visible = true;
                return false;
            }else
            {
                return true;
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            lbAguarde.Visible = true;
            btCancelar.Visible = false;
            btEntrar.Visible = false;
            if (ValidarCampos())
            {
                FuncionarioController controller = new FuncionarioController();
                bool verifica = controller.verificarLogin(txUsuario.Text, txtSenha.Text);
                if (verifica)
                {
                    Funcionario funcionario;
                    funcionario = controller.getFuncCPF(txUsuario.Text);
                    usuarioLogado = funcionario.Id;
                    nivelAcesso = funcionario.Cargo;
                    usuarioLogadoNome = funcionario.Nome;
                    this.Visible = false;
                    Principal form_principal = new Principal(this, frm_splash);
                    form_principal.Show();
                    txtSenha.Text = "";
                    lbAguarde.Visible = false;
                    btCancelar.Visible = true;
                    btEntrar.Visible = true;

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Invalidos", "Consulti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSenha.Text = "";
                    lbAguarde.Visible = false;
                    btCancelar.Visible = true;
                    btEntrar.Visible = true;
                }
            }

            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_splash.Close();
        }
    }
}
