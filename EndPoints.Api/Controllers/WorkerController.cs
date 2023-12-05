using Carwash.Application.Service.Workers.Command.Create;
using Carwash.Application.Service.Workers.Command.Delete;
using Carwash.Application.Service.Workers.Command.SaveWorker;
using Carwash.Application.Service.Workers.Command.Update;
using Carwash.Application.Service.Workers.Commands.Create;
using Carwash.Application.Service.Workers.Queries.GetWorker;
using Carwash.Application.Service.Workers.Queries.GetWorkerById;
using Carwash.Application.Service.Workers.Queries.SearchWorker;
using Carwash.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IGetWorkerService _getWorker;
        private readonly IGetWorkerByIdService _getWorkerById;
        private readonly ICreateWorkerService _createWorker;
        private readonly IDeleteWorkerService _deleteWorker;
        private readonly IUpdateWorkerService _updateWorker;
        private readonly ISaveWorkerService _saveWorker;
        private readonly ISearchWorkerService _searchWorker;
        public WorkerController(IGetWorkerService getWorker, IGetWorkerByIdService getWorkerById, ICreateWorkerService createWorker, IDeleteWorkerService deleteWorker, IUpdateWorkerService updateWorker, ISaveWorkerService saveWorker, ISearchWorkerService searchWorker)
        {
            _getWorker = getWorker;
            _getWorkerById = getWorkerById;
            _createWorker = createWorker;
            _deleteWorker = deleteWorker;
            _updateWorker = updateWorker;
            _saveWorker = saveWorker;
            _searchWorker = searchWorker;
        }

        [HttpGet]

        public async Task<IActionResult> GetWorker()
        {
            var worker = await _getWorker.Execute();
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpGet]

        public async Task<IActionResult> GetWorkerById(int id)
        {
            var worker = await _getWorkerById.Execute(id);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromQuery] CreateWorkerDto createWorkerDto)
        {
            var worker = await _createWorker.Execute(createWorkerDto);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var worker = await _deleteWorker.Execute(id);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromQuery] UpdateWorkerDto createWorkerDto)
        {
            var worker1 = await _updateWorker.Execute(createWorkerDto);
            return StatusCode(worker1.StatusCode, worker1);
        }

        [HttpPost]

        public async Task<IActionResult> SaveWorker([FromQuery]SaveWorkerDto saveWorkerDto)
        {
            var worker = await _saveWorker.Execute(saveWorkerDto);
            return StatusCode(worker.StatusCode, worker);
        }

        [HttpGet]

        public async Task<IActionResult> SearchWorker([FromQuery]SearchWorkerDto searchWorkerDto)
        {
            var worker = await _searchWorker.Execute(searchWorkerDto);
            return StatusCode(worker.StatusCode, worker);
        }
    }
}
