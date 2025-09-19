namespace VistavkaApp.Data
{
    public class Posetitel
    {
        public int PosetitelId { get; set; }
        public string? PosetitelSurname { get; set; }
        public string? PosetitelName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Bilet>? Bilets { get; set; }
    }
}
