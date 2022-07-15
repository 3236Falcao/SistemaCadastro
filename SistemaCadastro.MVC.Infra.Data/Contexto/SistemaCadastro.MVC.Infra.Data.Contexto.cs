using SistemaCadastro.MVC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SistemaCadastro.MVC.Infra.Data.Contexto
{
    public class SistemaCadastroContexto : DbContext
    {
        public SistemaCadastroContexto()
            : base("SistemaCadastro") 
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
