using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PotionsAPI.Domain.Entities;
using PotionsAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PotionsAPI.Data.Contexts
{
    /// <summary>
    /// Contexto de Poções
    /// </summary>
    public class PotionContext
    {
        private readonly IMongoDatabase _database = null;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="settings"></param>
        public PotionContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        /// <summary>
        /// Poções
        /// </summary>
        public IMongoCollection<PotionEntity> Potions
        {
            get
            {
                return _database.GetCollection<PotionEntity>("Potion");
            }
        }
    }
}
