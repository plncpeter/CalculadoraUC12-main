﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variável global:
        bool clicouNoOperador = true;
        int n;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            txtTela.Text += btnClicado.Text;
            clicouNoOperador = false;
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            // Só atribuir na tela se não tiver clicado no operador:
            if (clicouNoOperador == false)
            {
                n += int.Parse(txtTela.Text);
                txtAux.Text = txtTela.Text + btnClicado.Text;
                txtTela.Text = "";
                clicouNoOperador = true;
                operador = btnClicado.Text;

            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    txtTela.Text = (n + int.Parse(txtTela.Text)).ToString();
                    break;
                case "-":
                    txtTela.Text = (n - int.Parse(txtTela.Text)).ToString();
                    break;
                case "*":
                    txtTela.Text = (n * int.Parse(txtTela.Text)).ToString();
                    break;
                case "/":
                    txtTela.Text = (n / int.Parse(txtTela.Text)).ToString();
                    break;



            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtTela.Text = "";
            n = 0;
            operador = "";
            txtAux.Text = "";
        }
    }
}
