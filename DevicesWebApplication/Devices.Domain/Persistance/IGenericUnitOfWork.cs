using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Domain.Persistance
{
    public interface IGenericUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task ExecuteNonQuery(string commandText, params object[] parameters);
        //void SaveChanges();
        Task SaveChangesAsync();
        void UndoChanges();
    }
}
