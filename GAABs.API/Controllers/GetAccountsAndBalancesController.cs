using GAABs.API.DataAccess;
using GAABs.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GAABs.API.Controllers
{
    [Route("api_gaabs/v1/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class GetAccountsAndBalancesController : ControllerBase
    {
        private IDataAccessHelper _dataAccess;

        public GetAccountsAndBalancesController(IDataAccessHelper dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        /// <summary>
        /// POST - api_gaabs/v1/getaccountsandbalancescontroller/getaccountsandbalances
        /// </summary>
        /// <param name="apiRequest">The get accounts and balances request</param>
        /// <returns>The get accounts and balances response model</returns>
        [HttpPost]
        public IActionResult GetAccountsAndBalances([FromBody] GetAccountsAndBalancesRequest apiRequest)
        {
            var response = _dataAccess.getAccountsFromDatabase(apiRequest.CustomerNumber);
            return Ok(response);
        }
    }
}
