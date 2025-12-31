namespace maintenance.DTOs.Equipment
{
    public class EquipmentCreateDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        public int CustomerId { get; set; }
    }
}
