using CarteiraDoInvestidor.Application.Conta.Dto;
using CarteiraDoInvestidor.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioOutputDto>();
            CreateMap<UsuarioInputDto, Usuario>();

        }
    }
}
