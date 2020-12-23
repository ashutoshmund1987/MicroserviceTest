using GAABs.API.Entities;
using System.Collections.Generic;

namespace GAABs.API.DataAccess
{
    public class DataAccessHelper : IDataAccessHelper
    {
        /// <summary>
        /// Gets the account list from the account database
        /// </summary>
        /// <param name="customerNumber">The customer number</param>
        /// <returns>The account list</returns>
        public List<Account> getAccountsFromDatabase(string customerNumber)
        {
            return new List<Account>
            {
                new Account {AccountSubTypeCode = "1234", AccountSubTypeDesc="Current Account -1", AccountDescription = "Current Account -1", AccountValidateFormat="1234/123456", ExternalAccountNoFormat="1234 123456", Balance="132.34", AvailableBalance="7.8", AccountStatusCode="0"},
                new Account {AccountSubTypeCode = "1234", AccountSubTypeDesc="Current Account -1", AccountDescription = "Current Account -1", AccountValidateFormat="5643/896754", ExternalAccountNoFormat="5643 896754", Balance="7.89", AvailableBalance="3.0", AccountStatusCode="0"},
                new Account {AccountSubTypeCode = "1234", AccountSubTypeDesc="Current Account -1", AccountDescription = "Current Account -1", AccountValidateFormat="7654/989876", ExternalAccountNoFormat="7654 989876", Balance="102.34", AvailableBalance="67.56", AccountStatusCode="0"},
                new Account {AccountSubTypeCode = "1234", AccountSubTypeDesc="Current Account -1", AccountDescription = "Current Account -1", AccountValidateFormat="1234/765345", ExternalAccountNoFormat="1234 765345", Balance="1500.34", AvailableBalance="1200.34", AccountStatusCode="0"},
                new Account {AccountSubTypeCode = "1234", AccountSubTypeDesc="Current Account -1", AccountDescription = "Current Account -1", AccountValidateFormat="1234/786543", ExternalAccountNoFormat="1234 786543", Balance="2300.34", AvailableBalance="700.8", AccountStatusCode="0"},
            };
        }
    }
}
