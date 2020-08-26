using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsAPI.Models
{
    /// <summary>
    /// Parâmetros de Poções
    /// </summary>
    public class PotionParam
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome da poção
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Descrição
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
