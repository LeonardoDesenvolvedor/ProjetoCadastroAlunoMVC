using CadastroAluno.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroAluno.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext(): base("Escola") { }

        public DbSet<Cadastro> Cadastros { get; set; }
    }
}