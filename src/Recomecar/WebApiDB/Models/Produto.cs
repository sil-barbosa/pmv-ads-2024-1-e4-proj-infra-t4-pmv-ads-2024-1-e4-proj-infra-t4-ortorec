﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string? NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }

        [ForeignKey("Categorias")]
        public int? CategoriaID { get; set; }
        public Categorias? Categorias { get; set; }
    }
}
