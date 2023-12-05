using Carwash.Application.Service.WorkerInKhadamats.Commands.Create;
using Carwash.Application.Service.WorkerInKhadamats.Queries.GetWorkerInKhadamat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkerInKhadamatController : ControllerBase
    {

        [HttpPost]
        public IActionResult AddWorkerInKhadamat([FromServices] ICreateWorkerInKhadamatService _service, CreateWorkerInKhadamatDto model)
        {
            var result = _service.Execute(model);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet]

        public IActionResult GetWorkerInKhadamat([FromServices] IGetWorkerInKhadamat _getWorker, int workerId)
        {
            var result = _getWorker.Execute(workerId);
            return StatusCode(result.StatusCode, result);
        }
    }
}
