namespace AuthenticateAPI.Entities
{
    /// <summary>
    /// Authenticate channel response business entities
    /// </summary>
    public class AuthenticateChannelResponse
    {
        /// <summary>
        /// Gets or sets the customer number
        /// </summary>
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or sets the signature
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// Gets or sets the signed data
        /// </summary>
        public SignedData SignedData { get; set; }
    }
}
