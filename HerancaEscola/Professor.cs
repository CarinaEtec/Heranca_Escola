using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEscola
{
    class Professor : Pessoa
    {
        private int cod;
        private String graduacao;
        private String especialidade;
        private String cart_trabalho;
        private double valor_hora;
        private int horas_trabalhadas;

        public int Cod { get => cod; set => cod = value; }
        public string Graduacao { get => graduacao; set => graduacao = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public string Cart_trabalho { get => cart_trabalho; set => cart_trabalho = value; }
        public double Valor_hora { get => valor_hora; set => valor_hora = value; }
        public int Horas_trabalhadas { get => horas_trabalhadas; set => horas_trabalhadas = value; }

        public Professor()
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
                   " \nGraduação: " + this.graduacao +
                   " \nEspecialidade: " + this.especialidade +
                   " \nCarteira de Trabalho: " + this.cart_trabalho +
                   " \nValor hora: " + this.valor_hora + ",00" +
                   " \nHoras trabalhadas: " + this.horas_trabalhadas +
                    " \nSalário Líquido: " + this.Sal_liquido + ",00");
        }



        public double Calcular()
        {
            Sal_liquido = valor_hora * horas_trabalhadas;
            return Sal_liquido;
        }


    }
}
