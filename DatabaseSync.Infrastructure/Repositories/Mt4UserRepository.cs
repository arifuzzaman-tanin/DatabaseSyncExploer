using DatabaseSync.Core.Entities;
using DatabaseSync.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSync.Infrastructure.Repositories
{
    public class Mt4UserRepository : IMt4UserRepository
    {
        private readonly UserContext _userContext;
        public Mt4UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }
        public IQueryable<Mt4User> Users()
        {
            throw new NotImplementedException();
        }
    }
}
