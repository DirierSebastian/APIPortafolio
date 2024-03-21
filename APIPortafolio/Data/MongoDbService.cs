using MongoDB.Driver;

namespace APIPortafolio.Data
{
    public class MongoDbService
    {
        private readonly IMongoDatabase _database;

        public MongoDbService(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DbConnection");
            var mongoClient = new MongoClient(connectionString);
            _database = mongoClient.GetDatabase("PortafolioDirier");
        }

        public IMongoDatabase Database => _database;
    }
}
