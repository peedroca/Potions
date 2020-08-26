using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PotionsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsAPI.Contexts
{
    public class PotionContext
    {
        private readonly IMongoDatabase _database = null;

        public PotionContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Potion> Potions
        {
            get
            {
                return _database.GetCollection<Potion>("Potion");
            }
        }
    }
}
