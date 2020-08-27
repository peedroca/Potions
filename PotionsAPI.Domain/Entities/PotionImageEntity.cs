using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PotionsAPI.Domain.Entities
{
    /// <summary>
    /// Imagem da Poção
    /// </summary>
    public class PotionImageEntity
    {
        /// <summary>
        /// Identificação interna do Mongo DB
        /// </summary>
        [BsonId]
        public ObjectId InternalId { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string Url { get; set; }
    }
}
