using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CriancaServices : ICriancaServices
    {
        private readonly ICriancaRepository _criancaRepository;
        private IMapper _mapper;

        public CriancaServices (ICriancaRepository criancaRepository, IMapper mapper)
        {
            _criancaRepository = criancaRepository;
            _mapper = mapper;
        }

        public void Adicionar(NovaCriancaViewModel NovaCriancaViewMoel)
        {
            var NovaCrianca = _mapper.Map<Crianca>(NovaCriancaViewMoel);
            _criancaRepository.Adicionar(NovaCrianca);
        }

        public void Atualizar(CriancaViewModel produto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CriancaViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<CriancaViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CriancaViewModel> ObterTodos()
        {
          return _mapper.Map<IEnumerable<CriancaViewModel>>(_criancaRepository.ObterTodos());
        }
    }
}
