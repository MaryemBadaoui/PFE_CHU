namespace PFE_CHU.Models
{
    public class Service
    {

        public int? Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<User>? Users { get; set; }
        public Devision? Devision { get; set; }
        public int? DevisionId { get; set; }

    }
}
