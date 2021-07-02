using first.Dtos;
using first.Interfaces;
using iFramework.Common.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first.Controllers
{
    [Route("api/DAL")]
    [ApiController]
    public class DALController : ControllerBase
    {
        private readonly IDALService _dALService;
        private readonly ILogger _logger;

        public DALController(IDALService dALService, ILogger<DALController> logger)
        {
            _dALService = dALService;
            _logger = logger;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetDAL(Guid id)
        {
            _logger.LogDebug("DALController: Entered GetDALAction");
            var request = new GetDALRequest() { Id = id };
            return Ok(await _dALService.GetDALAsync(request));
        }

        [Route("all")]
        [HttpGet]
        public async Task<IActionResult> GetAllDAL()
        {
            _logger.LogDebug("DALController: Entered GetDALAction");
            return Ok(await _smscampaignService.SearchDALAsync(new DALModel()));
        }

        [Route("new")]
        [HttpPost]
        public async Task<IActionResult> AddDAL(DALModel model)
        {
            _logger.LogDebug("DALController: Entered AddDALAction");
            var request = new GetDALRequest() { DAL = model };
            return Ok(await _dALService.AddDALAsync(request));
        }

        [Route("{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateDAL(Guid id, DALModel model)
        {
            _logger.LogDebug("DALController: Entered UpdateDALAction");
            var request = new GetDALRequest() { DAL = model, Id = id };
            return Ok(await _dALService.UpdateDALAsync(request));
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteDAL(Guid id)
        {
            _logger.LogDebug("DALController: Entered DeleteDALAction");
            return Ok(await _dALService.DeleteDALAsync(id));
        }

    }
}
