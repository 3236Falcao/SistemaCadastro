using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCadastro.MVC.Dominio.Entidades
{
    public class Cliente
    {
        //Estados
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email{ get; set; }

        public DateTime DataCadastro  { get; set; }

        public bool Ativo { get; set; }

        //Regras de negócios // Comportamentos

        //Metodo que valida se o cliente é ativo e tem , no minimo, 5 anos
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
