using System.Collections.Generic;

namespace ProjetoModelo.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity getById(int Id);

        IEnumerable<TEntity> GetAll();
        void UpDate(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
