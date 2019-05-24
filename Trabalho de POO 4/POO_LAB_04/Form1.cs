using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_LAB_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbMV.Clear();
            if(textBox3.Text == "")
            {
                Vetor2D v = new Vetor2D(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                rtbMV.AppendText("O módulo vetorial é:" + Math.Round(v.moduloVetorial(), 3));
            }
            else
            {
                Vetor3D v = new Vetor3D(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                rtbMV.AppendText("O módulo vetorial é:" + Math.Round(v.moduloVetorial3D(), 3));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbPV.Clear();
            Vetor3D vr;
            Vetor3D v1 = new Vetor3D(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            Vetor3D v2 = new Vetor3D(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox7.Text));
            vr = v1.produtoVetorial(v2);
            rtbPV.AppendText("O vetor resultado é: (" + vr.getX() + "," + vr.getY() + "," + vr.getZ() + ")");
        }
    }
}
