using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Model.Enums;

namespace Model
{
    public class Employee : Handler
    {
        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Role")]
        public ERole Role { get; set; }

        [BsonElement("Salt")]
        public string Salt { get; set; }

        [BsonElement("HashedPassword")]
        public string HashedPassword { get; set; }

        [BsonElement("Department")]
        public EDepartment Department { get; set; }

        [BsonElement("AccessToken")]
        public string AccessToken { get; set; }
    }
}
