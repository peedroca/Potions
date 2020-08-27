using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PotionsAPI.Data.Contexts;
using PotionsAPI.Domain.Entities;
using PotionsAPI.Domain.Interfaces;
using PotionsAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PotionsAPI.Data.Repositories
{
    /// <summary>
    /// Repositório de Poções
    /// </summary>
    public class PotionRepository : IPotionRepository
    {
        private readonly PotionContext _context = null;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="settings"></param>
        public PotionRepository(IOptions<Settings> settings)
        {
            _context = new PotionContext(settings);
        }

        /// <summary>
        /// Adiciona uma nova poção
        /// </summary>
        /// <param name="item">Poção que será adicionada</param>
        /// <returns></returns>
        public async Task AddPotion(PotionEntity item)
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

        /// <summary>
        /// Listar todas as poções
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PotionEntity>> GetAllPotions()
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
