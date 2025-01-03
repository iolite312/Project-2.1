﻿using Model.Enums;
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
        public ETicketType Type { get; set; }

        [BsonElement("Status")]
        public ETicketStatus Status { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [BsonElement("Priority")]
        public ETicketPriority Priority { get; set; }

        [BsonElement("HandlerEID")]
        public Handler Handler { get; set; }

        [BsonElement("EmployeeEID")]
        public Employee Employee { get; set; }

        [BsonElement("Deadline")]
        public int Deadline { get; set; }

        public Ticket(string caseName, ETicketType type, ETicketStatus status, string description, DateTime timestamp, ETicketPriority priority, Handler handler, Employee employee, int deadline, string id = null)
        {
            Id = id;
            CaseName = caseName;
            Type = type;
            Status = status;
            Description = description;
            Timestamp = timestamp;
            Priority = priority;
            Handler = handler;
            Employee = employee;
            Deadline = deadline;
        }
    }
}
