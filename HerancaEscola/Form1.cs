using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaEscola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor abrir = new frmProfessor();
            abrir.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno abrir = new frmAluno();
            abrir.ShowDialog();
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiretor abrir = new frmDiretor();
            abrir.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario abrir = new frmFuncionario();
            abrir.ShowDialog();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmAluno abrir = new frmAluno();
            abrir.ShowDialog();
        }

        private void btnDiretor_Click(object sender, EventArgs e)
        {
            frmDiretor abrir = new frmDiretor();
            abrir.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario abrir = new frmFuncionario();
            abrir.ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            frmProfessor abrir = new frmProfessor();
            abrir.ShowDialog();
        }
    }
}
