// @DEVELOPED By Luis Paulo de Souza Reis, SJC, SP

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Fmr_Calculadora : Form
    {
        float vResultado = 0;
        float vNumber1 = 0;
        float vNumber2 = 0;
        string adicao = "false";
        string subtracao = "false";
        string multiplicacao = "false";
        string divisao = "false";
        string final = "false";


        public Fmr_Calculadora()
        {
            InitializeComponent();
        }

        private void Fmr_Calculadora_Load(object sender, EventArgs e)
        {

        }

        // TECLADO NÚMERICO
        private void btn_Number0_Click(object sender, EventArgs e) // Adicionar o Número 0
        {
            txt_Resultado.Text = txt_Resultado.Text + "0";
        }

        private void btn_Number1_Click(object sender, EventArgs e) // Adicionar o Número 1
        {
            txt_Resultado.Text = txt_Resultado.Text + "1";
        }

        private void btn_Number2_Click(object sender, EventArgs e) // Adicionar o Número 2
        {
            txt_Resultado.Text = txt_Resultado.Text + "2";
        }

        private void btn_Number3_Click(object sender, EventArgs e) // Adicionar o Número 3
        {
            txt_Resultado.Text = txt_Resultado.Text + "3";
        }

        private void btn_Number4_Click(object sender, EventArgs e) // Adicionar o Número 4
        {
            txt_Resultado.Text = txt_Resultado.Text + "4";
        }

        private void btn_Number5_Click(object sender, EventArgs e) // Adicionar o Número 5
        {
            txt_Resultado.Text = txt_Resultado.Text + "5";
        }

        private void btn_Number6_Click(object sender, EventArgs e) // Adicionar o Número 6
        {
            txt_Resultado.Text = txt_Resultado.Text + "6";
        }

        private void btn_Number7_Click(object sender, EventArgs e) // Adicionar o Número 7
        {
            txt_Resultado.Text = txt_Resultado.Text + "7";
        }

        private void btn_Number8_Click(object sender, EventArgs e) // Adicionar o Número 8
        {
            txt_Resultado.Text = txt_Resultado.Text + "8";
        }

        private void btn_Number9_Click(object sender, EventArgs e) // Adicionar o Número 9
        {
            txt_Resultado.Text = txt_Resultado.Text + "9";
        }

        private void btn_Virgula_Click(object sender, EventArgs e) // Vírgula
        {
            txt_Resultado.Text = txt_Resultado.Text + ",";
        }

        // OPERADORES
        private void btn_Adicao_Click(object sender, EventArgs e) // Botão de Adição
        {
            vNumber1 = float.Parse(txt_Resultado.Text);
            lbl_SubTitle.Text = vNumber1 + " +";
            txt_Resultado.Text = "";
            adicao = "true";
            final = "false";
        }

        private void btn_Subtracao_Click(object sender, EventArgs e) // Botão Operador de Subtração
        {
            vNumber1 = float.Parse(txt_Resultado.Text);
            lbl_SubTitle.Text = vNumber1 + " -";
            txt_Resultado.Text = "";
            subtracao = "true";
            final = "false";
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e) // Botão Operador de multiplicação
        {
            vNumber1 = float.Parse(txt_Resultado.Text);
            lbl_SubTitle.Text = vNumber1 + " x";
            txt_Resultado.Text = "";
            multiplicacao = "true";
            final = "false";
        }

        private void btn_Divisao_Click(object sender, EventArgs e) // Botão Operador de Divisão
        {
            vNumber1 = float.Parse(txt_Resultado.Text);
            lbl_SubTitle.Text = vNumber1 + " ÷";
            txt_Resultado.Text = "";
            divisao = "true";
            final = "false";
        }


        private void btn_Porcentagem_Click(object sender, EventArgs e)
        {
            vNumber2 = vNumber2 / 100;
        }

        private void btn_Apagar_Click(object sender, EventArgs e) // Botão apagar o ultimo caractere (backspace)
        {
            txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.Text.Length - 1);
        }

        private void btn_C_Click(object sender, EventArgs e) // Limpar toda a operação
        {
            txt_Resultado.Clear();
            lbl_SubTitle.Text = "";
            vNumber1 = 0;
            vNumber2 = 0;
            vResultado = 0;
            final = "false";
        }

        private void btn_CE_Click(object sender, EventArgs e) // Limpar a TextBox
        {
            if (final == "false")
            {
                txt_Resultado.Clear();
            }

            else 
            {
                txt_Resultado.Clear();
                lbl_SubTitle.Text = "";
                vNumber1 = 0;
                vNumber2 = 0;
                vResultado = 0;
                final = "false";
            }
        }

        
        private void btn_Igual_Click(object sender, EventArgs e) // Botão igual
        {
            // REALIZANDO AS OPERAÇÕES
            if (adicao == "true") // Realiza a operação de Adição
            {
                vNumber2 = float.Parse(txt_Resultado.Text);
                lbl_SubTitle.Text = vNumber1 + " + " + vNumber2;
                txt_Resultado.Text = "";
                txt_Resultado.Clear();
                lbl_SubTitle.Text = vNumber1 + " + " + vNumber2 + " =";
                vResultado = (vNumber1 + vNumber2); // Realiza a Adição
                txt_Resultado.Text = vResultado.ToString();
                vNumber1 = vResultado;
                adicao = "false";
                final = "true";
            }

            if (subtracao == "true") // Realiza a operação de Subtração
            {
                vNumber2 = float.Parse(txt_Resultado.Text);
                lbl_SubTitle.Text = vNumber1 + " - " + vNumber2;
                txt_Resultado.Text = "";
                txt_Resultado.Clear();
                lbl_SubTitle.Text = vNumber1 + " - " + vNumber2 + " =";
                vResultado = (vNumber1 - vNumber2); // Realiza a Subtração
                txt_Resultado.Text = vResultado.ToString();
                vNumber1 = vResultado;
                subtracao = "false";
                final = "true";
            }

            if (multiplicacao == "true") // Realiza a operação de Multiplicação
            {
                vNumber2 = float.Parse(txt_Resultado.Text);
                lbl_SubTitle.Text = vNumber1 + " x " + vNumber2;
                txt_Resultado.Text = "";
                txt_Resultado.Clear();
                lbl_SubTitle.Text = vNumber1 + " x " + vNumber2 + " =";
                vResultado = (vNumber1 * vNumber2); // Realiza a Multiplicação
                txt_Resultado.Text = vResultado.ToString();
                vNumber1 = vResultado;
                multiplicacao = "false";
                final = "true";
            }

            if (divisao == "true") // Realiza a operação de Divisão
            {
                vNumber2 = float.Parse(txt_Resultado.Text);
                lbl_SubTitle.Text = vNumber1 + " ÷ " + vNumber2;
                txt_Resultado.Text = "";
                txt_Resultado.Clear();
                lbl_SubTitle.Text = vNumber1 + " ÷ " + vNumber2 + " =";
                vResultado = (vNumber1 / vNumber2); // Realiza a Divisão
                txt_Resultado.Text = vResultado.ToString();
                vNumber1 = vResultado;
                divisao = "false";
                final = "true";
            }
        }
    }
}
