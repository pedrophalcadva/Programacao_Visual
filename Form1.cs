using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcular(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(textBoxPeso.Text);
            double altura = Convert.ToDouble(textBoxAltura.Text);

            double imc = peso / Math.Pow(altura,2);

            //textBoxIMC.Text = Convert.ToString(imc);
            textBoxIMC.Text = Math.Round(imc,2).ToString();

            if (imc<17) {
                pictureBoxIMC.Image = Image.FromFile("imgs/img1.jpg");
            }else if (imc >= 17 && imc < 18.5){
                pictureBoxIMC.Image = Image.FromFile("imgs/img2.jpg");
            }else if (imc >= 18.5 && imc < 25){
                pictureBoxIMC.Image = Image.FromFile("imgs/img3.jpg");
            }else if (imc >= 25 && imc < 38){
                pictureBoxIMC.Image = Image.FromFile("imgs/img4.jpg");
            }else if (imc >= 38 && imc < 35){
                pictureBoxIMC.Image = Image.FromFile("imgs/img5.jpg");
            }else if (imc >= 35 && imc < 40){
                pictureBoxIMC.Image = Image.FromFile("imgs/img6.jpg");
            }else{
                pictureBoxIMC.Image = Image.FromFile("imgs/img7.jpg");
                }
            }
    }
}
