using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_LAB_03
{
    public partial class AlunoMateria : Form
    {

        Materia[] materia = new Materia[20];
        Materia[] lista_materia = new Materia[20];

        Aluno[] aluno = new Aluno[30];

        int i, j, k, id = 0;
        
        public AlunoMateria()
        {
            InitializeComponent();
        }

        private void ButtonSalvarAluno_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != " " && textBoxPeriodo.Text != " " && textBoxMatricula.Text != " ")
            {
                aluno[i] = new Aluno();
                aluno[i].setNome(textBoxNome.Text);
                aluno[i].setPeriodo(textBoxPeriodo.Text);
                aluno[i].setMatricula(textBoxMatricula.Text);
                comboBoxAluno.Items.Add(textBoxNome.Text);
                comboBoxRelatorio.Items.Add(textBoxNome.Text);
                textBoxNome.Text = " ";
                textBoxPeriodo.Text = " ";
                textBoxMatricula.Text = " ";
                i++;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

            private void ButtonSalvarMateria_Click(object sender, EventArgs e)
        {
            if (textBoxMateria.Text != " " && textBoxCodigo.Text != " ")
            {
                materia[j] = new Materia();
                materia[j].setNome(textBoxMateria.Text);
                materia[j].setCodigo(textBoxCodigo.Text);
                comboBoxMaterias.Items.Add(textBoxMateria.Text);
                textBoxMateria.Text = " ";
                textBoxCodigo.Text = " ";
                j++;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (comboBoxAluno.Text != " " && comboBoxMaterias.Text != " ")
            {
                int k = 0;
                for (k = 0; k < 20; k++)
                    if (materia[k].getNome() == comboBoxMaterias.Text)
                        break;
                aluno[id].setMaterias(materia[k]);
                comboBoxMaterias.Text = " ";
                comboBoxAluno.Text = " ";
            }
            else
            {
                MessageBox.Show("Selecione matéria/aluno!");
            }
        }

        private void ComboBoxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = 0;
            for (id = 0; id < 30; id++)
            {
                if (comboBoxAluno.SelectedItem.Equals(aluno[id].getNome()))
                {
                    break;
                }
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            textBoxRelatorio.Text = " ";
            int s = 0;
            for (s = 0; s < 30; id++)
            {
                if (comboBoxRelatorio.SelectedItem.Equals(aluno[s].getNome()))
                {
                    break;
                }
            }
            textBoxRelatorio.Text = "Nome: " + aluno[s].getNome() + Environment.NewLine + "Periodo: " +
                aluno[s].getPeriodo() + Environment.NewLine + "Matricula: " + aluno[s].getMatricula();
            textBoxRelatorio.Text = textBoxRelatorio.Text + Environment.NewLine + "Materias Cadastradas:\n";
            while (true)
            {
                textBoxRelatorio.Text = textBoxRelatorio.Text + Environment.NewLine + aluno[s].getMaterias(k);
                k++;
                if (aluno[s].getMaterias(k) == "fim")
                {
                    break;
                }
            }
            k = 0;
        }


       

        
        }
    }

