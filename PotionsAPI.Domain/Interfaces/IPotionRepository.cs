using PotionsAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PotionsAPI.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório de poções
    /// </summary>
    public interface IPotionRepository
    {
        /// <summary>
        /// Adiciona uma nova poção
        /// </summary>
        /// <param name="item">Poção que será adicionada</param>
        /// <returns></returns>
        Task AddPotion(PotionEntity item);

        /// <summary>
        /// Listar todas as poções
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PotionEntity>> GetAllPotions();
    }
}
