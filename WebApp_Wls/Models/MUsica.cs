using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Wls.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Título é obrigatório")]
        [Remote("VerificaTitulo", "Musicas", ErrorMessage = "Este Título já existe !!")]
        [MaxLength(400, ErrorMessage ="Máximo 400 caracteres")]
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        public TipoMidia TipoMidia { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}