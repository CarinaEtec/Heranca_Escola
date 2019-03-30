using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEscola
{
    class Pessoa
    {
        private String nome;
        private String cpf;
        private String rg;
        private String endereco;
        private String cidade;
        private String telefone;
        private String email;
        private String sexo;
        private int idade;

        private double sal_liquido;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Sal_liquido { get => sal_liquido; set => sal_liquido = value; }

        public Pessoa()
        {
        }



        public String Cadastrar()
        {
            return "Cadastrado com sucesso";
        }

    }
}
