namespace EFCustomerLibrary.Intefaces
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
        void DeleteAll();

    }
}
