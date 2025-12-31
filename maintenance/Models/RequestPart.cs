namespace maintenance.Models
{
    public class RequestPart
    {
        public int Id { get; set; }
        public int SparePartId { get; set; }
        public int MaintenanceRequestId { get; set; }
        public int Quantity { get; set; }

        public SparePart SparePart { get; set; }
        public MaintenanceRequest MaintenanceRequest { get; set; }
    }
}
