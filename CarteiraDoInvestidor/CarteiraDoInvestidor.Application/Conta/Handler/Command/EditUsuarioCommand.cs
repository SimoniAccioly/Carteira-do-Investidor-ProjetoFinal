using CarteiraDoInvestidor.Application.Conta.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Conta.Handler.Command
{
    public class EditUsuarioCommand : IRequest<EditUsuarioCommandResponse>
    {
        public Guid Id { get; set; }
        public UsuarioInputDto Usuario { get; set; }

        public EditUsuarioCommand(UsuarioInputDto usuario)
        {
            Usuario = usuario;
        }
    }

    public class EditUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public EditUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
