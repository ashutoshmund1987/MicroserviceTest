using System.Collections.Generic;

namespace GAABs.API.Entities
{
    /// <summary>
    /// Business entity with the name get accounts and balances
    /// </summary>
    public class GetAccountsAndBalancesResponse
    {
        /// <summary>
        /// Gets or sets the account list
        /// </summary>
        public List<Account> accountList { get; set; }
    }
}
