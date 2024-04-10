using CarteiraDoInvestidor.Domain.Conta.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Conta.Dto
{
    public record UsuarioInputDto(string Nome, Email Email, Password Password);
    public record UsuarioOutputDto(Guid Id, string Nome, Email Email, Password Password);
}
