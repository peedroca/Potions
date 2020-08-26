using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PotionsAPI.Models;
using PotionsAPI.Models.Interfaces;

namespace PotionsAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PotionsController : ControllerBase
    {
        private readonly IPotionRepository _potionRepository;

        public PotionsController(IPotionRepository potionRepository)
        {
            _potionRepository = potionRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Potion>> Get()
        {
            return await _potionRepository.GetAllPotions();
        }

        [HttpPost]
        public void Post([FromBody] PotionParam newPotion)
        {
            _potionRepository.AddPotion(new Potion
            {
                Id = newPotion.Id,
                Description = newPotion.Description,
                UpdatedOn = DateTime.Now,
                Name = newPotion.Name
            });
        }
    }
}
