﻿namespace CarteiraDoInvestidor.Domain.Conta.ValueObject
{
    public class Email
    {
        public Email()
        {

        }

        public Email(string email)
        {
            Valor = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string Valor { get; set; }
    }
}
