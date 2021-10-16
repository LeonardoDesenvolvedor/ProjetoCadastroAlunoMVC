using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroAluno.Models
{
    public class Cadastro
    {
        public long CadastroId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int  Idade { get; set; }

        public string Curso { get; set; }

      
    }
}