using Model.Enums;
using Model;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Api.DTO
{
    public class TicketDTO
    {
        public string CaseName { get; set; }

        public ETicketType Type { get; set; }

        public ETicketStatus Status { get; set; }

        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public ETicketPriority Priority { get; set; }

        public Handler Handler { get; set; }

        public TicketEmployeeDTO Employee { get; set; }

        public int Deadline { get; set; }

        public Ticket RevertModel()
        {
            return new Ticket(CaseName, Type, Status, Description, Timestamp, Priority, Handler, Employee.RevertModel(), Deadline);
        }
        public Ticket RevertModel(string id)
        {
            return new Ticket(CaseName, Type, Status, Description, Timestamp, Priority, Handler, Employee.RevertModel(), Deadline, id);
        }

        public TicketDTO ConvertModel(Ticket ticket)
        {
            CaseName = ticket.CaseName;
            Type = ticket.Type;
            Status = ticket.Status;
            Description = ticket.Description;
            Timestamp = ticket.Timestamp;
            Priority = ticket.Priority;
            Handler = ticket.Handler;
            Employee = Employee.ConvertModel(ticket.Employee);
            Deadline = ticket.Deadline;
            return this;
        }

    }
}
