using maintenance.Enum;

namespace maintenance.Models
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EquipmentId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public RequestStatus Status { get; set; } // enum

        public Customer Customer { get; set; }
        public Equipment Equipment { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<MaintenanceLog> Logs { get; set; }
        public Invoice Invoice { get; set; }
    }
}
