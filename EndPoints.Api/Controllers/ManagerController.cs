
using Carwash.Application.Service.Jwt;
using Carwash.Application.Service.Managers.Commands.Create;
using Carwash.Application.Service.Managers.Commands.Delete;
using Carwash.Application.Service.Managers.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ManagerController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IGetManagerService _getManager;
        private readonly ICreateManagerService _createManager;
        private readonly IDeleteManagerService _deleteManager;

        public ManagerController(IJwtService jwtService, IGetManagerService getManager, ICreateManagerService createManager, IDeleteManagerService deleteManager)
        {
            _jwtService = jwtService;
            _getManager = getManager;
            _createManager = createManager;
            _deleteManager = deleteManager;
        }


        [HttpGet]

        public IActionResult GetManager()
        {
            var manager = _getManager.Execute();
            return Ok(manager);
        }

        [HttpPost]

        public IActionResult CreateManager([FromForm]CreateManagerDto createManagerDto)
        {
            var manager = _createManager.Execute(createManagerDto);
            return Ok(manager);
        }

        [HttpDelete]

        public IActionResult DeleteManager(int id)
        {
            _deleteManager.Execute(id);
            return Ok();
        }

        [HttpGet]
       [AllowAnonymous]
        public IActionResult Login([FromQuery]LoginDto loginDto)
        {
            var manager = _jwtService.Generate(loginDto);
            return Ok(manager);
        }
    }
}
