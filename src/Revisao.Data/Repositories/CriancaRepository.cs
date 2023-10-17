using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CriancaRepository : ICriancaRepository
    {
        private readonly string _produtoCaminhoArquivo;

        public CriancaRepository()
        {
            _produtoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Natal.json");

        }

        public void Adicionar(Crianca crianca)
        {
            List<Crianca> criancas = LerProdutosDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            criancas.Add(crianca);
            EscreverProdutosNoArquivo(criancas);
        }

        public void Atualizar(Crianca crianca)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Crianca>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Crianca> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Crianca> ObterTodos()
        {
            return LerProdutosDoArquivo();
        }

        #region Métodos arquivo
        private List<Crianca> LerProdutosDoArquivo()
        {
            if (!System.IO.File.Exists(_produtoCaminhoArquivo))
            {
                return new List<Crianca>();
            }

            string json = System.IO.File.ReadAllText(_produtoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Crianca>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Crianca> produtos = LerProdutosDoArquivo();
            if (produtos.Any())
            {
                return produtos.Max(p => p.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverProdutosNoArquivo(List<Crianca> produtos)
        {
            string json = JsonConvert.SerializeObject(produtos);
            System.IO.File.WriteAllText(_produtoCaminhoArquivo, json);
        }
        #endregion
    }
}
