using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpaceLaunches.Repositories;
using System.Threading.Tasks;

namespace SpaceLaunches.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchController : ControllerBase
    {
        private readonly ILogger<LaunchController> _logger;

        public LaunchController(ILogger<LaunchController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetLaunches()
        {
            try
            {
                var repo = new LaunchRepository();
                var launches = await repo.GetLaunchListAsync();

                return Ok(launches);
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Failed to get launches: {ex}");
            }

            return BadRequest("Failed to get launches");
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetRockets()
        {
            try
            {
                var repo = new LaunchRepository();
                var rockets = await repo.GetRocketListAsync();

                return Ok(rockets);
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Failed to get rockets: {ex}");
            }

            return BadRequest("Failed to get rockets");
        }
    }
}