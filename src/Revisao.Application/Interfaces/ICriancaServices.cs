using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICriancaServices
    {
        IEnumerable<CriancaViewModel> ObterTodos();
        Task<CriancaViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CriancaViewModel>> ObterPorCategoria(int codigo);

        void Adicionar(NovaCriancaViewModel NovaCriancaViewMoel);
        void Atualizar(CriancaViewModel produto);
    }
}
