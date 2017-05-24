﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultiBETA.Model;
using ConsultiBETA.Controller;

namespace ConsultiBETA
{
    public partial class FormAddFuncionarios : Form
    {
        FuncionarioController funcionarios = new FuncionarioController();
        public FormAddFuncionarios()
        {
            InitializeComponent();
            
        }
        public FormAddFuncionarios(DataGridView form1)
        {
            Funcionario funcionario = funcionarios.getFunc(int.Parse(form1.Rows[form1.CurrentRow.Index].Cells[0].Value.ToString()));
            InitializeComponent();
            lbID.Text = funcionario.Id.ToString();
            txtCPF.SelectedText = funcionario.Cpf;
            txtNome.SelectedText = funcionario.Nome;
            txtRua.SelectedText = funcionario.Endereco;
            txtNro.SelectedText = funcionario.Nro;
            txtBairro.SelectedText = funcionario.Bairro;
            txtCidade.SelectedText = funcionario.Cidade;
            cbEstado.SelectedItem = funcionario.Uf;
            txtCEP.SelectedText = funcionario.Cep;
            cbCargo.SelectedItem = funcionario.Cargo;
            txtTelefone.SelectedText = funcionario.Telefone;
            txtSalario.SelectedText = funcionario.Salario.ToString();
            txtSenha.SelectedText = funcionario.Senha;
            switch (FormLogin.nivelAcesso)
            {
                case "Atendente":
                    txtBairro.ReadOnly = true;
                    txtCEP.ReadOnly = true;
                    txtCidade.ReadOnly = true;
                    txtCPF.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtNro.ReadOnly = true;
                    txtRua.ReadOnly = true;
                    txtTelefone.ReadOnly = true;
                    txtSalario.Visible = false;
                    txtSenha.Visible = false;
                    lbSenha.Visible = false;
                    lbSalario.Visible = false;
                    btnSalvar.Visible = false;
                    break;
                case "Administrativo":
                    lbSenha.Visible = false;
                    txtSenha.Visible = false;
                    break;

            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Funcionario funcionario = new Funcionario();

            if (lbID.Text == "Funcionario ID")
            {
                
                funcionario.Cpf = txtCPF.Text;
                funcionario.Nome = txtNome.Text;
                funcionario.Endereco = txtRua.Text;
                funcionario.Nro = txtNro.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cidade = txtCidade.Text;
                funcionario.Uf = cbEstado.Text;
                funcionario.Cep = txtCEP.Text;
                funcionario.Cargo = cbCargo.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Salario = float.Parse(txtSalario.Text);
                funcionario.Senha = txtSenha.Text;

                funcionarios.Cadastrar(funcionario);
                MessageBox.Show("Funcionario Cadastrado com sucesso", "Consulti", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
                FormFuncionarios f = Application.OpenForms["FormFuncionarios"] as FormFuncionarios;

                if (f != null)
                {
                    f.Exibir();
                }
            }
            else
            {
                int id = int.Parse(lbID.Text);
                funcionario.Id = id;
                funcionario.Cpf = txtCPF.Text;
                funcionario.Nome = txtNome.Text;
                funcionario.Endereco = txtRua.Text;
                funcionario.Nro = txtNro.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cidade = txtCidade.Text;
                funcionario.Uf = cbEstado.Text;
                funcionario.Cep = txtCEP.Text;
                funcionario.Cargo = cbCargo.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Salario = float.Parse(txtSalario.Text);
                funcionario.Senha = txtSenha.Text;

                funcionarios.Editar(funcionario);
                MessageBox.Show("Funcionario Alterado com sucesso", "Consulti", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
                FormFuncionarios f = Application.OpenForms["FormFuncionarios"] as FormFuncionarios;

                if (f != null)
                {
                    f.Exibir();
                }
            }
        }
                
    }
}
