﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultiBETA
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAddFuncionarios form = new FormAddFuncionarios();
            form.Show();
        }
    }
}