using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEscola
{
    class Aluno : Pessoa
    {
        private int rm;
        private String curso;
        private String modulo;

        public int Rm { get => rm; set => rm = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Modulo { get => modulo; set => modulo = value; }



        public Aluno()
        {
        }


        public String mostrar()
        {
            return
                   ("Nome: " + this.Nome +
                      " \nCPF: " + this.Cpf +
                      " \nRG: " + this.Rg +
                      " \nEndereco: " + this.Endereco +
                      " \nCidade: " + this.Cidade +
                      " \nTelefone: " + this.Telefone +
                      " \nEmail: " + this.Email +
                      " \nSexo: " + this.Sexo +
                      " \nIdade: " + this.Idade +



                      " \nRM: " + this.rm +
                      " \nCurso: " + this.curso +
                      " \nMódulo: " + this.modulo);

        }


    }
}
