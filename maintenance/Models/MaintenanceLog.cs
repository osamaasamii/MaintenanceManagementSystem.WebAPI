namespace maintenance.Models
{
    public class MaintenanceLog
    {
        public int Id { get; set; }
        public int MaintenanceRequestId { get; set; }
        public string Notes { get; set; }
        public DateTime LogTime { get; set; }

        public MaintenanceRequest MaintenanceRequest { get; set; }
    }
}
