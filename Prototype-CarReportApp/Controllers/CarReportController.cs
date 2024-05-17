using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype_CarReportApp.Services;
using Prototype_CarReportApp_Models;

namespace Prototype_CarReportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarReportController : ControllerBase
    {
        private ICarReport<Car> _car;

        public CarReportController(ICarReport<Car> car)
        {
            _car = car;
        }

        [HttpGet("all")]
        public async Task<ActionResult<Car>> GetAll()
        {
            try
            {
                return Ok(await _car.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("{regNr}")]
        public async Task<ActionResult<Car>> GetCar(string regNr)
        {
            try
            {
                regNr = regNr.ToUpper();
                var result = await _car.GetSpecificString(regNr);

                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Car with registration number {regNr} could not be found . . .");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("{regNr}/{title}/{description}")]
        public async Task<ActionResult<Report>> CreateNewReport(string regNr, string title, string description)
        {
            try
            {
                regNr = regNr.ToUpper();
                var result = await _car.GetSpecificString(regNr);
                if (result != null)
                {
                    var report = await _car.Add(result, title, description);
                    return Ok(result);
                }
                return NotFound($"Car with registration number {regNr} could not be found . . .");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
