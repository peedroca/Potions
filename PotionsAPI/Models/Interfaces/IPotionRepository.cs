using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsAPI.Models.Interfaces
{
    public interface IPotionRepository
    {
        /// <summary>
        /// Adiciona uma nova poção
        /// </summary>
        /// <param name="item">Poção que será adicionada</param>
        /// <returns></returns>
        Task AddPotion(Potion item);

        /// <summary>
        /// Listar todas as poções
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Potion>> GetAllPotions();
    }
}
