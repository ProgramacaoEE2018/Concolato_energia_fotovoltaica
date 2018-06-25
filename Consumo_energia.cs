using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Concolato
{
    public partial class Estimativa_paineis_solares : Form
    {
        public Estimativa_paineis_solares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double adulto, bCons, aCons, mCons, consumo, area;


            adulto = Convert.ToDouble(textBox1.Text);

            

            bCons = Convert.ToDouble(textBox5.Text);

            aCons = Convert.ToDouble(textBox3.Text);

            mCons = Convert.ToDouble(textBox4.Text);


            consumo = adulto * ( bCons * 20 + mCons * 90 + aCons *162);

        
            area = consumo*0.056;

            label8.Text = consumo.ToString();

            label9.Text = area.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            label8.Text = "";
            label9.Text = "";


       
        }
    }
}
