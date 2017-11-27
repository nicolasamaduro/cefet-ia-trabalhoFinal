using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cefet_ia_trabalhoFinal.tela
{
    partial class Tela : Form
    {
        private MotorInferencia motorInferencia;
        public Tela(MotorInferencia motorInferencia, List<Fato> sistomas)
        {
            InitializeComponent();
            this.Size = new Size(500, 450);

            this.motorInferencia = motorInferencia;

            panel2.Visible = true;
            panel2.Location = new Point(12, 25);

            panel3.Location = new Point(12, 25);
            panel3.Visible = false;
            panel1.Visible = false;
            richTextBox3.Text = motorInferencia.baseConhecimento.ToString();
            foreach (Fato sintoma in sistomas)
            {
                listBox1.Items.Add(sintoma);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Fato> sintomasSelecionados = new List<Fato>();
            foreach(Object sintoma in listBox1.SelectedItems){
                sintomasSelecionados.Add((Fato)sintoma);
            }

            Dictionary<string, Fato> doencas = motorInferencia.buscar(sintomasSelecionados);

            string value = "";
            foreach (KeyValuePair<string, Fato> doenca in doencas)
            {
                value += doenca.Value.ToString() + "\n";
            }
            if (value == "")
            {
                value = "Nenhuma doença encontrada";
            }
            richTextBox2.Text = value;
        }

        private void baseDeConhecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void diagnosticarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;

        }
    }
}
