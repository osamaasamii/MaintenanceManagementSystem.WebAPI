namespace maintenance.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int MaintenanceRequestId { get; set; }
        public decimal PartsCost { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal Total => PartsCost + ServiceCost;

        public MaintenanceRequest MaintenanceRequest { get; set; }
    }
}
