using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variaveis para armazenar os valores
            double npeso = 0;
            double naltura = 0;
            double resultado = 0;

            if (txtaltura.Text != "" && txtpeso.Text != "")
            {
                npeso = double.Parse(txtpeso.Text);
                naltura = double.Parse(txtaltura.Text);
            }

            //Verificar
            resultado = npeso / (naltura * naltura);
            lblresultado.Text = resultado.ToString();
            if (resultado < 18.5)
            {
                
                lblsituacao.Text = "Vamo come vamo";
            } else if (resultado > 18.6 && resultado < 24.9)
            {
                 
                lblsituacao.Text    = "Ta xiq";
            }else if (resultado > 25.0 && resultado < 29.9)
            {
               
                lblsituacao.Text = "Ce parar de beber agora ta suave!";
            }else if (resultado > 30.0 && resultado < 34.9)
            {
                
                lblsituacao.Text = "Ta parecendo um bolinha";
            }else if (resultado > 35.0 && resultado < 39.9)
            {
               
                lblsituacao.Text = "Ta gigante amigao";
            }else if (resultado > 40.00)
            {
               
                lblsituacao.Text = "Vai explodir";
            }





        }
    }
}
