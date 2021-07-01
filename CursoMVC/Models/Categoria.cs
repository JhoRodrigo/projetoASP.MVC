using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")] // Função para aplicar o acento na variavel
        [Required(ErrorMessage = "O campo descrição é obrigatório")] // Para trazer uma mensagem em baixo do textbox
        public string Descricao { get; set; }

    }
}
