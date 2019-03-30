using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEscola
{
    class Funcionario : Pessoa
    {
        private int cod;
        private String cart_trabalho;
        private String cargo;
        private double adicional_noturno;
        private double salario;
        private double inss;

        public int Cod { get => cod; set => cod = value; }
        public string Cart_trabalho { get => cart_trabalho; set => cart_trabalho = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Adicional_noturno { get => adicional_noturno; set => adicional_noturno = value; }
        public double Salario { get => salario; set => salario = value; }
        public double Inss { get => inss; set => inss = value; }


        public Funcionario()
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
                   " \nCargo: " + this.cargo +
                   " \nAdicional Noturno: " + this.adicional_noturno + ",00" +
                   " \nSalario: " + this.salario + ",00" + 
                   " \nINSS: " + this.inss + ",00" + 
                    " \nSalário Líquido: " + this.Sal_liquido + ",00");


        }




        public double Calcular()
        {
            Sal_liquido = adicional_noturno + salario - inss;
            return Sal_liquido;
        }

    }
}
