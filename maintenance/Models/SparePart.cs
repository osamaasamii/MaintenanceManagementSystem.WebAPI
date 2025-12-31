namespace maintenance.Models
{
    public class SparePart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<RequestPart> RequestParts { get; set; }
    }
}
