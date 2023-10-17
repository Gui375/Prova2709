using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Crianca
    {
        #region Construtores
        //public Crianca(string nome,int idade,string rua,string bairro,int nmroCasa,string cidade,string estado,string carta) 
        //{
        //    Nome = nome;
        //    Idade = idade;
        //    Rua = rua;
        //    Bairro = bairro;
        //    NumeroCasa = nmroCasa;
        //    Cidade = cidade;
        //    Estado = estado;
        //    Carta = carta;
            
        //}
        public Crianca(int id,string nome, int idade, string rua, string bairro, int nmroCasa, string cidade, string estado, string carta)
        {
            Id=id;
            Nome = nome;
            Idade = idade;
            Rua = rua;
            Bairro = bairro;
            NumeroCasa = nmroCasa;
            Cidade = cidade;
            Estado = estado;
            Carta = carta;

        }
        #endregion
        #region Atributos
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public int NumeroCasa { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Carta { get; private set; }
        #endregion

        #region Funções
        public int AumentarIdade(int age)
        {
            return Idade = +age;
        }
        #endregion
    }
}
