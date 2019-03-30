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
    public partial class frmDiretor : Form
    {
        public frmDiretor()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Diretor DIR = new Diretor();
            DIR.Nome = Convert.ToString(txtNome.Text);
            DIR.Cpf = Convert.ToString(mskCPF.Text);
            DIR.Rg = Convert.ToString(mskRG.Text);
            DIR.Endereco = Convert.ToString(txtEndereco.Text);
            DIR.Cidade = Convert.ToString(txtCidade.Text);
            DIR.Telefone = Convert.ToString(mskTelefone.Text);
            DIR.Email = Convert.ToString(txtEmail.Text);
            DIR.Sexo = Convert.ToString(cmbSexo.SelectedItem);
            DIR.Idade = Convert.ToInt16(nudIdade.Text);

            DIR.Cod = Convert.ToInt16(txtCodigo.Text);
            DIR.Cart_trabalho = Convert.ToString(txtCarteiraTrabalho.Text);
            DIR.Bonificacao = Convert.ToDouble(txtBonificacao.Text);
            DIR.Salario = Convert.ToDouble(txtSalario.Text);
            DIR.Sal_liquido = Convert.ToDouble(lblSalLiquido.Text);


            MessageBox.Show(DIR.mostrar());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Diretor DIR = new Diretor();
            DIR.Salario = Convert.ToDouble(txtSalario.Text);
            DIR.Bonificacao = Convert.ToDouble(txtBonificacao.Text);

            DIR.Calcular();
            lblSalLiquido.Text = Convert.ToString(DIR.Sal_liquido + ",00");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa PEOPLE = new Pessoa();
            MessageBox.Show(PEOPLE.Cadastrar());
        }
    }
}
