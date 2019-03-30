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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            Professor PROF = new Professor();
            PROF.Nome = Convert.ToString(txtNome.Text);
            PROF.Cpf = Convert.ToString(mskCPF.Text);
            PROF.Rg = Convert.ToString(mskRG.Text);
            PROF.Endereco = Convert.ToString(txtEndereco.Text);
            PROF.Cidade = Convert.ToString(txtCidade.Text);
            PROF.Telefone = Convert.ToString(mskTelefone.Text);
            PROF.Email = Convert.ToString(txtEmail.Text);
            PROF.Sexo = Convert.ToString(cmbSexo.SelectedItem);
            PROF.Idade = Convert.ToInt16(nudIdade.Text);

            PROF.Cod = Convert.ToInt16(txtCodigo.Text);
            PROF.Graduacao = Convert.ToString(txtGraduacao.Text);
            PROF.Especialidade = Convert.ToString(txtEspecialidade.Text);

            PROF.Cart_trabalho = Convert.ToString(txtCarteiraTrabalho.Text);
            PROF.Valor_hora = Convert.ToDouble(txtValorHora.Text);
            PROF.Horas_trabalhadas = Convert.ToInt16(nudHorasTrabalhadas.Text);
            PROF.Sal_liquido = Convert.ToDouble(lblSalLiquido.Text);
            MessageBox.Show(PROF.mostrar());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Professor PROF = new Professor();
            PROF.Valor_hora = Convert.ToDouble(txtValorHora.Text);
            PROF.Horas_trabalhadas = Convert.ToInt16(nudHorasTrabalhadas.Text);

            PROF.Calcular();
            lblSalLiquido.Text = Convert.ToString(PROF.Sal_liquido + ",00");

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa PEOPLE = new Pessoa();
            MessageBox.Show(PEOPLE.Cadastrar());
        }
    }
}
