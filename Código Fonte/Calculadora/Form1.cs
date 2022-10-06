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
        float vPorcentagem = 0;
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
            txt_Visor.Text = txt_Visor.Text + "0";
        }

        private void btn_Number1_Click(object sender, EventArgs e) // Adicionar o Número 1
        {
            txt_Visor.Text = txt_Visor.Text + "1";
        }

        private void btn_Number2_Click(object sender, EventArgs e) // Adicionar o Número 2
        {
            txt_Visor.Text = txt_Visor.Text + "2";
        }

        private void btn_Number3_Click(object sender, EventArgs e) // Adicionar o Número 3
        {
            txt_Visor.Text = txt_Visor.Text + "3";
        }

        private void btn_Number4_Click(object sender, EventArgs e) // Adicionar o Número 4
        {
            txt_Visor.Text = txt_Visor.Text + "4";
        }

        private void btn_Number5_Click(object sender, EventArgs e) // Adicionar o Número 5
        {
            txt_Visor.Text = txt_Visor.Text + "5";
        }

        private void btn_Number6_Click(object sender, EventArgs e) // Adicionar o Número 6
        {
            txt_Visor.Text = txt_Visor.Text + "6";
        }

        private void btn_Number7_Click(object sender, EventArgs e) // Adicionar o Número 7
        {
            txt_Visor.Text = txt_Visor.Text + "7";
        }

        private void btn_Number8_Click(object sender, EventArgs e) // Adicionar o Número 8
        {
            txt_Visor.Text = txt_Visor.Text + "8";
        }

        private void btn_Number9_Click(object sender, EventArgs e) // Adicionar o Número 9
        {
            txt_Visor.Text = txt_Visor.Text + "9";
        }

        private void btn_Virgula_Click(object sender, EventArgs e) // Vírgula
        {
            txt_Visor.Text = txt_Visor.Text + ",";
        }

        // OPERADORES
        private void btn_Adicao_Click(object sender, EventArgs e) // Botão de Adição
        {
            if (adicao == "true" || txt_Visor.Text == "")
            {
                // Tramento de erro caso o usuário clique no botão e visor esteja vazio
            }
            
            else if (subtracao == "true" || multiplicacao == "true" || divisao == "true")
            {
                lbl_SubTitle.Text = vNumber1 + " +";
                adicao = "true";
                subtracao = "false";
                multiplicacao = "false";
                divisao = "false";
            }

            else
            {
                vNumber1 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " +";
                txt_Visor.Text = "";
                adicao = "true";
                final = "false";
            }
        }

        private void btn_Subtracao_Click(object sender, EventArgs e) // Botão Operador de Subtração
        {
            if (subtracao == "true" || txt_Visor.Text == "") 
            {
                // Tramento de erro caso o usuário clique no botão e visor esteja vazio
            }
            
            else if (adicao == "true" || multiplicacao == "true" || divisao == "true")
            {
                lbl_SubTitle.Text = vNumber1 + " -";
                adicao = "false";
                subtracao = "true";
                multiplicacao = "false";
                divisao = "false";
            }

            else
            {
                vNumber1 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " -";
                txt_Visor.Text = "";
                subtracao = "true";
                final = "false";
            }
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e) // Botão Operador de multiplicação
        {
            if (multiplicacao == "true" || txt_Visor.Text == "")
            {
                // Tramento de erro caso o usuário clique no botão e visor esteja vazio
            }

            else if (adicao == "true" || subtracao == "true" || divisao == "true")
            {
                lbl_SubTitle.Text = vNumber1 + " x";
                adicao = "false";
                subtracao = "false";
                multiplicacao = "true";
                divisao = "false";
            }

            else
            {
                vNumber1 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " x";
                txt_Visor.Text = "";
                multiplicacao = "true";
                final = "false";
            }
        }

        private void btn_Divisao_Click(object sender, EventArgs e) // Botão Operador de Divisão
        {
            if (divisao == "true" || txt_Visor.Text == "") 
            {
                // Tramento de erro caso o usuário clique no botão e visor esteja vazio
            }

            else if (adicao == "true" || subtracao == "true" || multiplicacao == "true")
            {
                lbl_SubTitle.Text = vNumber1 + " ÷";
                adicao = "false";
                subtracao = "false";
                multiplicacao = "false";
                divisao = "true";
            }

            else
            {
                vNumber1 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " ÷";
                txt_Visor.Text = "";
                divisao = "true";
                final = "false";
            }
        }

        // OPERAÇÃO DE PORCENTAGEM
        private void btn_Porcentagem_Click(object sender, EventArgs e)
        {
            if (adicao == "true" || subtracao == "true" || multiplicacao == "false" || divisao == "false") // Caso seja uma operação previamente de adição ou subtração
            {
                vNumber2 = float.Parse(txt_Visor.Text);
                vPorcentagem = (vNumber2 / 100) * vNumber1;
                vNumber2 = vPorcentagem;
                lbl_SubTitle.Text = lbl_SubTitle.Text + " " + vNumber2;
                final = "false";
                txt_Visor.Text = vNumber2.ToString();
            }

            else // Caso seja uma operação previamente de divisão ou multiplicação
            {
                vNumber2 = float.Parse(txt_Visor.Text); 
                vPorcentagem = vNumber2 / 100;
                vNumber2 = vPorcentagem;
                lbl_SubTitle.Text = lbl_SubTitle.Text + " " + vNumber2;
                final = "false";
                txt_Visor.Text = vNumber2.ToString();
            }

        }
        // BOTÕES DE DELEÇÃO
        private void btn_Apagar_Click(object sender, EventArgs e) // Botão apagar o ultimo caractere (backspace)
        {
            if (txt_Visor.Text == "")
            {
                // Tramento de erro caso o usuário clique no botão e visor esteja vazio
            }

            else
            {
                txt_Visor.Text = txt_Visor.Text.Substring(0, txt_Visor.Text.Length - 1);
            }
        }

        private void btn_C_Click(object sender, EventArgs e) // Limpar toda a operação
        {
            txt_Visor.Clear();
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
                txt_Visor.Clear();
            }

            else 
            {
                txt_Visor.Clear();
                lbl_SubTitle.Text = "";
                vNumber1 = 0;
                vNumber2 = 0;
                vResultado = 0;
                final = "false";
            }
        }

        // BOTÃO DE IGUAL
        private void btn_Igual_Click(object sender, EventArgs e) // Botão igual
        {
            // REALIZANDO AS OPERAÇÕES
            if (adicao == "true") // Realiza a operação de Adição
            {
                vNumber2 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " + " + vNumber2;
                txt_Visor.Text = "";
                txt_Visor.Clear();
                lbl_SubTitle.Text = vNumber1 + " + " + vNumber2 + " =";
                vResultado = (vNumber1 + vNumber2); // Realiza a Adição
                txt_Visor.Text = vResultado.ToString();
                vNumber1 = vResultado;
                adicao = "false";
                final = "true";
            }

            if (subtracao == "true") // Realiza a operação de Subtração
            {
                vNumber2 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " - " + vNumber2;
                txt_Visor.Text = "";
                txt_Visor.Clear();
                lbl_SubTitle.Text = vNumber1 + " - " + vNumber2 + " =";
                vResultado = (vNumber1 - vNumber2); // Realiza a Subtração
                txt_Visor.Text = vResultado.ToString();
                vNumber1 = vResultado;
                subtracao = "false";
                final = "true";
            }

            if (multiplicacao == "true") // Realiza a operação de Multiplicação
            {
                vNumber2 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " x " + vNumber2;
                txt_Visor.Text = "";
                txt_Visor.Clear();
                lbl_SubTitle.Text = vNumber1 + " x " + vNumber2 + " =";
                vResultado = (vNumber1 * vNumber2); // Realiza a Multiplicação
                txt_Visor.Text = vResultado.ToString();
                vNumber1 = vResultado;
                multiplicacao = "false";
                final = "true";
            }

            if (divisao == "true") // Realiza a operação de Divisão
            {
                vNumber2 = float.Parse(txt_Visor.Text);
                lbl_SubTitle.Text = vNumber1 + " ÷ " + vNumber2;
                txt_Visor.Text = "";
                txt_Visor.Clear();
                lbl_SubTitle.Text = vNumber1 + " ÷ " + vNumber2 + " =";
                vResultado = (vNumber1 / vNumber2); // Realiza a Divisão
                txt_Visor.Text = vResultado.ToString();
                vNumber1 = vResultado;
                divisao = "false";
                final = "true";
            }
        }
    }
}
