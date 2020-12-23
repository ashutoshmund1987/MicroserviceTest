using System.ComponentModel.DataAnnotations;

namespace GAABs.API.Entities
{
    /// <summary>
    /// API - GetAccountsAndBalances service
    /// </summary>
    public class GetAccountsAndBalancesRequest
    {
        /// <summary>
        /// Gets or sets the customer number
        /// </summary>
        [MaxLength(10)]
        [Required]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or sets the channel id
        /// </summary>
        public string ChannelID { get; set; }

        /// <summary>
        /// Gets or sets the filter account list
        /// </summary>        
        public bool FilterAccountList { get; set; }
    }
}
