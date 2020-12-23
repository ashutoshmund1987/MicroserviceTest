using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateAPI.DataAccess;
using AuthenticateAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticateAPI.Controllers
{
    [Route("api_authenticate/v1/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        public IAuthenticateDataAccess _authenticateDataAccess;

        public AuthenticateController(IAuthenticateDataAccess authenticateDataAccess)
        {
            this._authenticateDataAccess = authenticateDataAccess;
        }

        // GET api_authenticate/v1
        [HttpPost]
        [ActionName("AuthenticateChannel")]
        public IActionResult AuthenticateChannel([FromBody]AuthenticateChannelRequest request)
        {
            if(!ModelState.IsValid)
            {
                string message = string.Join("; ", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(message);
            }

            AuthenticateChannelResponse responseData = new AuthenticateChannelResponse
            {
                SignedData = _authenticateDataAccess.getSignedData(),
                Signature = _authenticateDataAccess.getSignature(),
                CustomerNumber = _authenticateDataAccess.getCustomerNumber(request.DeviceGUID)
            };

            return Ok(responseData);
        }

        [HttpPost]
        [ActionName("AuthenticateWithGuid")]
        public IActionResult AuthenticateWithGuid([FromBody] string customerNumber)
        {
            return Ok();
        }
    }
}
