using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PotionsAPI.Domain.Entities
{
    /// <summary>
    /// Poção
    /// </summary>
    public class PotionEntity
    {
        /// <summary>
        /// Identificação interna do Mongo DB
        /// </summary>
        [BsonId]
        public ObjectId InternalId { get; set; }

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

        /// <summary>
        /// Ingredientes
        /// </summary>
        public string Ingredients { get; set; } = string.Empty;

        /// <summary>
        /// Modo de Preparo
        /// </summary>
        public string PrepareMode { get; set; } = string.Empty;

        /// <summary>
        /// Imagens da poção
        /// </summary>
        public IEnumerable<PotionImageEntity> PotionImage { get; set; } = new List<PotionImageEntity>();

        /// <summary>
        /// Data de atualização
        /// BsonDateTimeOptions permite salvar com a data e hora UTC.
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        /// <summary>
        /// Data de criação
        /// BsonDateTimeOptions permite salvar com a data e hora UTC.
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
