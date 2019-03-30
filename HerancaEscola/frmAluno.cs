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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }


        private void frmAluno_Load(object sender, EventArgs e)
        {

        }




        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Aluno ALU = new Aluno();
            ALU.Nome = Convert.ToString(txtNome.Text);
            ALU.Cpf = Convert.ToString(mskCPF.Text);
            ALU.Rg = Convert.ToString(mskRG.Text);
            ALU.Endereco = Convert.ToString(txtEndereco.Text);
            ALU.Cidade = Convert.ToString(txtCidade.Text);
            ALU.Telefone = Convert.ToString(mskTelefone.Text);
            ALU.Email = Convert.ToString(txtEmail.Text);
            ALU.Sexo = Convert.ToString(cmbSexo.SelectedItem);
            ALU.Idade = Convert.ToInt16(nudIdade.Text);

            ALU.Rm = Convert.ToInt16(txtRm.Text);
            ALU.Curso = Convert.ToString(txtCurso.Text);
            ALU.Modulo = Convert.ToString(txtModulo.Text);

            MessageBox.Show(ALU.mostrar());


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa PEOPLE = new Pessoa();
            MessageBox.Show(PEOPLE.Cadastrar());
        }
    }
}
