

using ProjetoModelo.Domain.Entitys;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
