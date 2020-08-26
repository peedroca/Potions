using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PotionsAPI.Contexts;
using PotionsAPI.Models;
using PotionsAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsAPI.Repositories
{
    public class PotionRepository : IPotionRepository
    {
        private readonly PotionContext _context = null;

        public PotionRepository(IOptions<Settings> settings)
        {
            _context = new PotionContext(settings);
        }

        public async Task AddPotion(Potion item)
        {
            try
            {
                await _context.Potions.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Potion>> GetAllPotions()
        {
            try
            {
                return await _context.Potions
                        .Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
