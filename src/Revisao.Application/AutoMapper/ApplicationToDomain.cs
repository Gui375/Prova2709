using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {

            CreateMap<CriancaViewModel, Crianca>()
                .ConstructUsing(q => new Crianca(q.Id,q.Nome,q.Idade,q.Rua,q.Bairro,q.NumeroCasa,q.Cidade,q.Estado,q.Carta));

            CreateMap<NovaCriancaViewModel, Crianca>()
               .ConstructUsing(q => new Crianca(q.Id,q.Nome, q.Idade, q.Rua, q.Bairro, q.NumeroCasa, q.Cidade, q.Estado, q.Carta));


        }
    }
}
