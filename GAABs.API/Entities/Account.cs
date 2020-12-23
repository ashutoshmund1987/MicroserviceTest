using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAABs.API.Entities
{
    /// <summary>
    /// Business entities with the name account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the account subtype code
        /// </summary>
        public string AccountSubTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the account subtype description
        /// </summary>
        public string AccountSubTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the account status code
        /// </summary>
        public string AccountStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the external account number format
        /// </summary>
        public string ExternalAccountNoFormat { get; set; }

        /// <summary>
        /// Gets or sets the account description
        /// </summary>
        public string AccountDescription { get; set; }

        /// <summary>
        /// Gets or sets the account validate format
        /// </summary>
        public string AccountValidateFormat { get; set; }

        /// <summary>
        /// Gets or sets the balances
        /// </summary>
        public string Balance { get; set; }

        /// <summary>
        /// Gets or sets the available balance
        /// </summary>
        public string AvailableBalance { get; set; }
    }
}
