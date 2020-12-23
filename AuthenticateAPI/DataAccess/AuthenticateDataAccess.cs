using AuthenticateAPI.Entities;

namespace AuthenticateAPI.DataAccess
{
    public class AuthenticateDataAccess : IAuthenticateDataAccess
    {
        /// <summary>
        /// Get signed data from using valid certificate
        /// </summary>
        /// <param name="signedData">The signed data</param>
        /// <returns>The string value</returns>
        public SignedData getSignedData()
        {
            return new SignedData();
        }

        /// <summary>
        /// Get the signature from the valid certificate
        /// </summary>
        /// <returns>The string value</returns>
        public string getSignature()
        {
            return "public key";
        }

        /// <summary>
        /// Get customer number using device GUID
        /// </summary>
        /// <param name="deviceGuid">The device GUID</param>
        /// <returns>The valid customer number</returns>
        public string getCustomerNumber(string deviceGuid)
        {
            return "1234567890";
        }
    }
}
