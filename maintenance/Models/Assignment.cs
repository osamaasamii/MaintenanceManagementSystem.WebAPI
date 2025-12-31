using maintenance.Models;

public class Assignment
{
    public int Id { get; set; }

    public int TechnicianId { get; set; }
    public Technician Technician { get; set; }

    public int MaintenanceRequestId { get; set; }
    public MaintenanceRequest MaintenanceRequest { get; set; }

    public DateTime AssignedAt { get; set; }
    public bool IsActive { get; set; }
}
