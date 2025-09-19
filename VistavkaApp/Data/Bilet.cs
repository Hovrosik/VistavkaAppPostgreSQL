namespace VistavkaApp.Data
{
    public class Bilet
    {
        public int BiletId { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public float Price { get; set; }
        public int? VistavkaId { get; set; }
        public int? PosetitelId { get; set; }
        public virtual Vistavka? Vistavka { get; set; }
        public virtual Posetitel? Posetitel { get; set; }
    }
}
