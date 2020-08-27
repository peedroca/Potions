using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PotionsAPI.Domain.Entities;
using PotionsAPI.Domain.Interfaces;
using PotionsAPI.Models;

namespace PotionsAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PotionsController : ControllerBase
    {
        private readonly IPotionRepository potionRepository;
        private readonly IMapper mapper;

        public PotionsController(IMapper mapper, IPotionRepository potionRepository)
        {
            this.potionRepository = potionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PotionView>> Get()
        {
            var potions = await potionRepository.GetAllPotions();
            return mapper.Map<IEnumerable<PotionView>>(potions);
        }

        [HttpPost]
        public void Post([FromBody] PotionView newPotion)
        {
            potionRepository.AddPotion(mapper.Map<PotionEntity>(newPotion));
        }
    }
}
