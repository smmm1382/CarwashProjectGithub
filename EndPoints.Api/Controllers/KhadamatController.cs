using Carwash.Application.Service.Khadamats.Commands.Create;
using Carwash.Application.Service.Khadamats.Commands.Delete;
using Carwash.Application.Service.Khadamats.Commands.SaveKhadamat;
using Carwash.Application.Service.Khadamats.Commands.Update;
using Carwash.Application.Service.Khadamats.Queries.GetKhadamat;
using Carwash.Application.Service.Khadamats.Queries.GetKhadamatById;
using Carwash.Application.Service.Khadamats.Queries.SearchKhadamat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KhadamatController : ControllerBase
    {
        private readonly IGetKhadamatService _getKhadamat;
        private readonly IGetKhadamatByIdService _getKhadamatById;
        private readonly ISearchKhadamatService _searchKhadamat;
        private readonly ISaveKhadamatService _saveKhadamat;
        private readonly ICreateKhadamatService _createKhadamat;
        private readonly IDeleteKhadamatService _deleteKhadamat;
        private readonly IUpdateKhadamatService _updateKhadamat;

        public KhadamatController(IGetKhadamatService getKhadamat, ISearchKhadamatService searchKhadamat, ISaveKhadamatService saveKhadamat, IGetKhadamatByIdService getKhadamatById, ICreateKhadamatService createKhadamat, IDeleteKhadamatService deleteKhadamat, IUpdateKhadamatService updateKhadamat)
        {
            _getKhadamat = getKhadamat;
            _searchKhadamat = searchKhadamat;
            _saveKhadamat = saveKhadamat;
            _getKhadamatById = getKhadamatById;
            _createKhadamat = createKhadamat;
            _deleteKhadamat = deleteKhadamat;
            _updateKhadamat = updateKhadamat;
        }

        [HttpGet]

        public async Task<IActionResult> GetKhadamat()
        {
            var khadamat = await _getKhadamat.Execute();
            return StatusCode(khadamat.StatusCode, khadamat);
        }

        [HttpGet]

        public async Task<IActionResult> GetKhadamatById(int id)
        {
            var khadamat = await _getKhadamatById.Execute(id);
            return StatusCode(khadamat.StatusCode,khadamat);
        }

        [HttpGet]

        public IActionResult SearchKhadamat([FromQuery] SearchKhadamatDto searchKhadamatDto)
        {
            var car = _searchKhadamat.Execute(searchKhadamatDto);
            return Ok(car);
        }

        [HttpPost]

        public async Task<IActionResult> CreateKhadamat([FromQuery]CreateKhadamatDto createKhadamatDto)
        {
            var khadamat = await _createKhadamat.Execute(createKhadamatDto);
            return StatusCode(khadamat.StatusCode, khadamat);
        }

        [HttpPost]

        public async Task<IActionResult> SaveKhadamat([FromQuery]SaveKhadamatDto saveKhadamatDto)
        {
            var khadamat = await _saveKhadamat.Execute(saveKhadamatDto);
            return StatusCode(khadamat.StatusCode, khadamat);
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteKhadamat(int id)
        {
            var khadamat = await _deleteKhadamat.Execute(id);
            return StatusCode(khadamat.StatusCode,khadamat);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateKhadamat([FromQuery]UpdateKhadamatDto updateKhadamatDto)
        {
            var khadamat = await _updateKhadamat.Execute(updateKhadamatDto);
            return StatusCode(khadamat.StatusCode, khadamat);
        }
    }
}
