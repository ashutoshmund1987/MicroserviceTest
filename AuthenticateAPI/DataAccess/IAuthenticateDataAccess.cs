using AuthenticateAPI.Entities;

namespace AuthenticateAPI.DataAccess
{
    public interface IAuthenticateDataAccess
    {
        /// <summary>
        /// Get signed data using valid certificate
        /// </summary>
        /// <returns>The string value</returns>
        SignedData getSignedData();

        /// <summary>
        /// Get the signature from the valid certificate
        /// </summary>
        /// <returns>The string value</returns>
        string getSignature();

        /// <summary>
        /// Get the customer number
        /// </summary>
        /// <param name="deviceGuid">The device GUID</param>
        /// <returns>The string value</returns>
        string getCustomerNumber(string deviceGuid);
    }
}
