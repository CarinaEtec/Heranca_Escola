using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEscola
{
    class Diretor : Pessoa
    {
        private int cod;
        private String cart_trabalho;
        private Double bonificacao;
        private Double salario;

        public int Cod { get => cod; set => cod = value; }
        public string Cart_trabalho { get => cart_trabalho; set => cart_trabalho = value; }
        public double Bonificacao { get => bonificacao; set => bonificacao = value; }
        public double Salario { get => salario; set => salario = value; }

        public Diretor()
        {
        }

        public String mostrar()
        {
            return ("Nome: " + this.Nome +
                   " \nCPF: " + this.Cpf +
                   " \nRG: " + this.Rg +
                   " \nEndereco: " + this.Endereco +
                   " \nCidade: " + this.Cidade +
                   " \nTelefone: " + this.Telefone +
                   " \nEmail: " + this.Email +
                   " \nSexo: " + this.Sexo +
                   " \nIdade: " + this.Idade +


                   " \nCódigo: " + this.cod +
                   " \nCarteira de Trabalho: " + this.cart_trabalho +
                   " \nBonificação: " + this.bonificacao + ",00" +
                   " \nSalario: " + this.salario + ",00" +
                    " \nSalário Líquido: " + this.Sal_liquido + ",00" );

        }

        public double Calcular()
        {
            Sal_liquido = bonificacao + salario;
            return Sal_liquido;
        }



    }
}
