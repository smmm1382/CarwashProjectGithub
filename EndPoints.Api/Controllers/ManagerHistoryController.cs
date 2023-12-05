using Carwash.Application.Service.Histories.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManagerHistoryController : ControllerBase
    {
        private readonly IGetHistoryService _historyService;
        public ManagerHistoryController(IGetHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]

        public IActionResult GetManagerHisrory()
        {
            var result = _historyService.Execute();
            return Ok(result);
        }
    }
}
