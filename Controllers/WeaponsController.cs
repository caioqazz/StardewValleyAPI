using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StardewValleyAPI.API.Services;
using StardewValleyAPI.ResourceParameters;

namespace StardewValleyAPI.Controllers
{
    [ApiController]
    [Route("api/weapons")]
    public class WeaponsController : ControllerBase
    {
        private readonly IStardewValleyLibraryRepository _stardewValleyLibraryRepository;

        public WeaponsController(IStardewValleyLibraryRepository stardewValleyLibraryRepository)
        {
            _stardewValleyLibraryRepository = stardewValleyLibraryRepository ??
                throw new ArgumentNullException(nameof(stardewValleyLibraryRepository));
        }

        [HttpGet()]
        [HttpHead]
        public IActionResult GetWeapons([FromQuery] WeaponsResourceParameters weaponsResourceParameters)
        {
            Console.WriteLine(weaponsResourceParameters.Type);
            Console.WriteLine(weaponsResourceParameters.SearchQuery);
            var weaponsFromRepo = _stardewValleyLibraryRepository.GetWeapons(weaponsResourceParameters);
            return Ok(weaponsFromRepo);
        }

        [HttpGet("{weaponId}")]
        public IActionResult GetWeapon(Guid weaponId)
        {
            var weaponFromRepo = _stardewValleyLibraryRepository.GetWeapon(weaponId);

            if (weaponFromRepo == null)
            {
                return NotFound();
            }

            return Ok(weaponFromRepo);
        }
    }

}