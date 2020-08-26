﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PotionsAPI.Models
{
    /// <summary>
    /// Poção
    /// </summary>
    public class Potion
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
        /// Data de atualização
        /// BsonDateTimeOptions permite salvar com a data e hora UTC.
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
