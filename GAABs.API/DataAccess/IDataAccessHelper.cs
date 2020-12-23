using GAABs.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAABs.API.DataAccess
{
    public interface IDataAccessHelper
    {
        List<Account> getAccountsFromDatabase(string customerNumber);
    }
}
