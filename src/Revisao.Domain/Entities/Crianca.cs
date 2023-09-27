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
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Carta { get; set; }
        #endregion

        #region Funções
        public int AumentarIdade(int age)
        {
            return Idade = +age;
        }
        #endregion
    }
}
