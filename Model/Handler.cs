using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;

namespace Model
{
    public class Handler
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyOrder(-1)]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        [JsonPropertyOrder(-1)]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        [JsonPropertyOrder(-1)]
        public string LastName { get; set; }

        public Handler(string firstName, string lastName, string id = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
