namespace AuthenticateAPI.Entities
{
    /// <summary>
    /// Authenticate channel request model
    /// </summary>
    public class AuthenticateChannelRequest
    {
        /// <summary>
        /// Gets or sets the app upgrade require 
        /// </summary>
        public bool AppUpgradeRequire { get; set; }

        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the stip active flag
        /// </summary>        
        public bool StipActive { get; set; }

        /// <summary>
        /// Gets or sets the device guid
        /// </summary>
        public string DeviceGUID { get; set; }

        /// <summary>
        /// Gets or sets the app invalid
        /// </summary>
        public bool AppInvalid { get; set; }

        /// <summary>
        /// Gets or sets the client reference
        /// </summary>
        public string ClientReference { get; set; }
    }
}
