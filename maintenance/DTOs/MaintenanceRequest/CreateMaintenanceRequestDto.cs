namespace maintenance.DTOs.MaintenanceRequest
{
    public class CreateMaintenanceRequestDto
    {
        public int CustomerId { get; set; }
        public int EquipmentId { get; set; }
        public string Description { get; set; }
    }
}
