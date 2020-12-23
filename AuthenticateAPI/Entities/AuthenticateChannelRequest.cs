namespace AuthenticateAPI.Entities
{
    public class AuthenticateChannelRequest
    {
        public bool AppUpgradeRequire { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public bool StipActive { get; set; }

        public string DeviceGUID { get; set; }

        public bool AppInvalid { get; set; }

        public string ClientReference { get; set; }
    }
}
