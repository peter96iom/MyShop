using System.Linq;
using MyShop.core.Models;

namespace MyShop.core
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable Collection();
        void Commit();
        void Delete(string id);
        T Find(string Id);
        void insert(T t);
        void update(T t);
    }
}