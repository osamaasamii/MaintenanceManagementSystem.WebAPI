namespace maintenance.DTOs.MaintenanceRequest
{
    public class MaintenanceRequestResponseDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
