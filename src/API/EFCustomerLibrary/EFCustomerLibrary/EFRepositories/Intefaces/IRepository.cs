namespace EFCustomerLibrary.Intefaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Create(TEntity entity);

        void Update(TEntity entity);

        TEntity Delete(int id);
        void DeleteAll();

    }
}
