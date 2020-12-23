namespace AuthenticateAPI.Entities
{
    /// <summary>
    /// Signed Data business entities
    /// </summary>
    public class SignedData
    {
        /// <summary>
        /// Gets or sets the upgrade require
        /// </summary>
        public bool UpgradeRequire { get; set; }

        /// <summary>
        /// Gets or sets the challenge
        /// </summary>
        public string Challenge { get; set; }

        /// <summary>
        /// Gets or sets the auth key id
        /// </summary>
        public string AuthKeyId { get; set; }

        /// <summary>
        /// Gets or sets the TLSHash
        /// </summary>
        public string TLSHash { get; set; }

        /// <summary>
        /// Gets or sets the STIP active mode
        /// </summary>
        public string StipActive { get; set; }

        /// <summary>
        /// Gets or sets the public key
        /// </summary>
        public string PublicKey { get; set; }
    }
}
