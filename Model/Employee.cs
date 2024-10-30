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

        public Employee(string firstName, string lastName, string email, string phoneNumber, ERole role, string salt, string hashedPassword, EDepartment department, string accessToken = null, string id = null) : base(firstName, lastName, id)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Salt = salt;
            HashedPassword = hashedPassword;
            Department = department;
            AccessToken = accessToken;
        }
    }
}
