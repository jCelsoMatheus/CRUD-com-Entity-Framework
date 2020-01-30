using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVCEF.Models
{
    public class pessoa
    {
        //Atribuir a Referência para o Entity entender que o Código é uma chave primária
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}