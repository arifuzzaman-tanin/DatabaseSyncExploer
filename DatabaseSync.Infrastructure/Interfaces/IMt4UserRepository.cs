using DatabaseSync.Core.Entities;

namespace DatabaseSync.Infrastructure.Interfaces
{
    interface IMt4UserRepository
    {
        IQueryable<Mt4User> Users();
    }
}
