namespace maintenance.DTOs.Assignment
{
    public class AssignmentResponseDto
    {
        public int Id { get; set; }

        public int MaintenanceRequestId { get; set; }
        public string TechnicianName { get; set; }

        public DateTime AssignedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
