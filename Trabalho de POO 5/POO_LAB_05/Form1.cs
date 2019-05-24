using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_LAB_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EmpregadoCLT eCLT = new EmpregadoCLT();
                eCLT.setprimeiroNome(textBox1.Text);
                eCLT.setCPF(textBox2.Text);
                eCLT.setEndereco(textBox3.Text);
                eCLT.setsalario_mensal(Convert.ToDouble(textBox4.Text));
                richTextBox1.Clear();
                richTextBox1.AppendText(Convert.ToString(eCLT.getSalLiquido()));
            }
            else if (radioButton2.Checked == true)
            {
                EmpregadoHorista eH = new EmpregadoHorista();
                eH.setprimeiroNome(textBox1.Text);
                eH.setCPF(textBox2.Text);
                eH.setEndereco(textBox3.Text);
                eH.setnro_horas(Convert.ToInt32(textBox5.Text));
                eH.setqtd_horas(Convert.ToDouble(textBox6.Text));
                richTextBox1.Clear();
                richTextBox1.AppendText(Convert.ToString(eH.getSalLiquido()));
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Nenhum tipo de trabalhador selecionado!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }
            if (radioButton1.Checked == false)
            {
                label4.Visible = false;
                textBox4.Visible = false;
                textBox4.Clear();
            }
            richTextBox1.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
            }
            if (radioButton2.Checked == false)
            {
                label5.Visible = false;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                textBox5.Clear();
                textBox6.Clear();
            }
            richTextBox1.Clear();
        }
    }
}
