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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Funcionario FUNC = new Funcionario();
            FUNC.Nome = Convert.ToString(txtNome.Text);
            FUNC.Cpf = Convert.ToString(mskCPF.Text);
            FUNC.Rg = Convert.ToString(mskRG.Text);
            FUNC.Endereco = Convert.ToString(txtEndereco.Text);
            FUNC.Cidade = Convert.ToString(txtCidade.Text);
            FUNC.Telefone = Convert.ToString(mskTelefone.Text);
            FUNC.Email = Convert.ToString(txtEmail.Text);
            FUNC.Sexo = Convert.ToString(cmbSexo.SelectedItem); 
            FUNC.Idade = Convert.ToInt16(nudIdade.Text);


            FUNC.Cod = Convert.ToInt16(txtCodigo.Text);
            FUNC.Cart_trabalho = Convert.ToString(txtCarteiraTrabalho.Text);
            FUNC.Cargo = Convert.ToString(txtCargo.Text);
            FUNC.Adicional_noturno = Convert.ToDouble(txtAdicionalNoturno.Text);
            FUNC.Salario = Convert.ToDouble(txtSalario.Text);
            FUNC.Inss = Convert.ToDouble(txtInss.Text);
            FUNC.Sal_liquido = Convert.ToDouble(lblSalLiquido.Text);
            MessageBox.Show(FUNC.mostrar());



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario FUNC = new Funcionario();
            FUNC.Salario = Convert.ToDouble(txtSalario.Text);
            FUNC.Adicional_noturno = Convert.ToDouble(txtAdicionalNoturno.Text);
            FUNC.Inss = Convert.ToDouble(txtInss.Text);


            FUNC.Calcular();
            lblSalLiquido.Text = Convert.ToString(FUNC.Sal_liquido + ",00");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa PEOPLE = new Pessoa();
            MessageBox.Show(PEOPLE.Cadastrar());
        }
    }
}
