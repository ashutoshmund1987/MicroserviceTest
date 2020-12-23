using GAABs.API.DataAccess;
using GAABs.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GAABs.API.Controllers
{
    [Route("api_gaabs/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GetAccountsAndBalancesController : ControllerBase
    {
        private IDataAccessHelper _dataAccess;

        public GetAccountsAndBalancesController(IDataAccessHelper dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        // GET api_gaabs/v1
        [HttpPost]
        public IActionResult GetAccountsAndBalances([FromBody] GetAccountsAndBalancesRequest apiRequest)
        {
            var response = _dataAccess.getAccountsFromDatabase(apiRequest.CustomerNumber);
            return Ok(response);
        }
    }
}
