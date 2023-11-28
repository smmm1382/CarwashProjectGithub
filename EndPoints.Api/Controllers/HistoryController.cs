using Carwash.Application.Service.Histories.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IGetHistoryService _historyService;
        public HistoryController(IGetHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]

        public IActionResult GetHisrory()
        {
            _historyService.Execute();
            return Ok();
        }
    }
}
