using ProjetoModeloDDD.Domain.Entityes;
using System;

namespace ProjetoModelo.Domain.Entitys
{
    public class Produto
    {
        public int ProductId { get; set; }
        public String Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
