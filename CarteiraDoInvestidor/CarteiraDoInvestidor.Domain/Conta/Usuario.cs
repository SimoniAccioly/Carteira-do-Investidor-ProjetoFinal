using CarteiraDoInvestidor.CrossCuting.Entity;
using CarteiraDoInvestidor.CrossCuting.Utils;
using CarteiraDoInvestidor.Domain.Conta.Rules;
using CarteiraDoInvestidor.Domain.Conta.ValueObject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Domain.Conta
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }

        public void SetPassword()
        {
            Password.Valor = SecurityUtils.HashSHA1(Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);
    }
}
