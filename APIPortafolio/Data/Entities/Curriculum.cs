using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace APIPortafolio.Data.Entities
{
    public class Curriculum
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        [JsonIgnore]

        public string? Id { get; set; }

        [BsonElement("descripcion"), BsonRepresentation(BsonType.String)]
        public string descripcion { get; set; }
    }
}
