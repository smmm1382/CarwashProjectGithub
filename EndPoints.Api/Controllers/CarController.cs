using Carwash.Application.Service.Cars.Commands.Create;
using Carwash.Application.Service.Cars.Commands.Delete;
using Carwash.Application.Service.Cars.Commands.SaveCar;
using Carwash.Application.Service.Cars.Commands.Update;
using Carwash.Application.Service.Cars.Queries.GetCar;
using Carwash.Application.Service.Cars.Queries.GetCarById;
using Carwash.Application.Service.Cars.Queries.SearchCar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IGetCarService _getCar;
        private readonly ICreateCarService _createCar;
        private readonly IGetCarByIdService _getCarById;
        private readonly IDeleteCarService _deleteCar;
        private readonly IUpdateCarService _updateCar;
        private readonly ISearchCarService _searchCar;
        private readonly ISaveCarService _saveCar;
        public CarController(IGetCarService getCar, ICreateCarService createCar, IGetCarByIdService getCarById, IDeleteCarService deleteCar, IUpdateCarService updateCar, ISearchCarService searchCar, ISaveCarService saveCar)
        {
            _getCar = getCar;
            _createCar = createCar;
            _getCarById = getCarById;
            _deleteCar = deleteCar;
            _updateCar = updateCar;
            _searchCar = searchCar;
            _saveCar = saveCar;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="carListDto"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCar([FromQuery]CarListDto carListDto)
        {
            var car =  _getCar.Execute(carListDto);
            return StatusCode(car.StatusCode, car);
        }
        /// <summary>
        /// نمایش یک ماشین از طریق شناسه
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCarById(int id)
        {
            var car = await _getCarById.Execute(id);
            return StatusCode(car.StatusCode, car);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCar([FromQuery]CreateCarDto createCarDto)
        {
            var car = await _createCar.Execute(createCarDto);
            return StatusCode(car.StatusCode, car);
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _deleteCar.Execute(id);
            return StatusCode(car.StatusCode, car);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCar(UpdateCarDto updateCarDto)
        {
            var car = await _updateCar.Execute(updateCarDto);
            return StatusCode(car.StatusCode,car);
        }

        [HttpGet]

        public async Task<IActionResult> SearchCar([FromQuery]SearchCarDto searchCarDto)
        {
            var car = await _searchCar.Execute(searchCarDto);
            return StatusCode(car.StatusCode, car);
        }

        [HttpPost]

        public async Task<IActionResult> SaveCar([FromQuery]SaveCarDto saveCarDto)
        {
            var car = await _saveCar.Execute(saveCarDto);
            return StatusCode(car.StatusCode, car);
        }
    }
}
