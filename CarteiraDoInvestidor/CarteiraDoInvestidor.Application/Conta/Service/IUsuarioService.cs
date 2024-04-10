using CarteiraDoInvestidor.Application.Conta.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Conta.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDto> Create(UsuarioInputDto dto);
        Task<UsuarioOutputDto> Edit(Guid id, UsuarioInputDto dto);
        Task<UsuarioOutputDto> Delete(Guid id);
        Task<List<UsuarioOutputDto>> GetAll();
        Task<UsuarioOutputDto> GetId(Guid id);

    }
}
