using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("CaseName")]
        public string CaseName { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [BsonElement("Priority")]
        public string Priority { get; set; }

        [BsonElement("HandlerEID")]
        public Handler Handler { get; set; }

        [BsonElement("EmployeeEID")]
        public Employee Employee { get; set; }

        [BsonElement("Deadline")]
        public int Deadline { get; set; }
    }
}
