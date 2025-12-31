namespace maintenance.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Model { get; set; }
        public string SerialNumber { get; set; }

     


        public ICollection<MaintenanceRequest> MaintenanceRequests { get; set; }

    }
}
