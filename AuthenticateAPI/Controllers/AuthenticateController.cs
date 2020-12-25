using AuthenticateAPI.CustomFilters;
using AuthenticateAPI.DataAccess;
using AuthenticateAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AuthenticateAPI.Controllers
{
    [Route("api_authenticate/v1/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    [ApiKeyAuth]
    public class AuthenticateController : ControllerBase
    {
        public IAuthenticateDataAccess _authenticateDataAccess;

        public AuthenticateController(IAuthenticateDataAccess authenticateDataAccess)
        {
            this._authenticateDataAccess = authenticateDataAccess;
        }

        /// <summary>
        /// POST api_authenticate/v1/authenticate/authenticatechannel
        /// </summary>
        /// <param name="request">The authenticate channel request model</param>
        /// <returns>The authenticate channel response model</returns>
        [HttpPost]
        [ActionName("AuthenticateChannel")]
        public IActionResult AuthenticateChannel([FromBody]AuthenticateChannelRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    string message = string.Join("; ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                    return BadRequest(message);
                }

                if (string.IsNullOrEmpty(request.UserId) || request.UserId.Length != 10)                    
                {
                    throw new MissingFieldException("Please enter valid userid with the length of 10 digit");
                }

                if (string.IsNullOrEmpty(request.Password))
                {
                    throw new MissingFieldException("Please enter valid password");
                }

                AuthenticateChannelResponse responseData = new AuthenticateChannelResponse
                {
                    Status = true,
                    Signature = _authenticateDataAccess.getSignature(),
                    CustomerNumber = _authenticateDataAccess.getCustomerNumber(request.DeviceGUID)
                };

                if (request.UserId == request.Password)
                {
                    responseData.Status = false;
                    responseData.ErrorMessage = "M001";
                    return Ok(responseData);
                }

                return Ok(responseData);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
           
        }

        /// <summary>
        /// POST api_authenticate/v1/authenticate/authenticatewithguid
        /// </summary>
        /// <param name="customerNumber">The customer number</param>
        /// <returns>True/False</returns>
        [HttpPost]
        [ActionName("AuthenticateWithGuid")]
        public IActionResult AuthenticateWithGuid([FromBody] string customerNumber)
        {
            return Ok();
        }
    }
}
