namespace PFE_CHU.Models
{
    public class Role
    {
        public int? Id { get; set; }
        public string Libelle { get; set; }

        public ICollection<User> Users { get; set; }//One to many
        public ICollection<Devision> Devision { get; set; }//One to many
        public ICollection<Service> Services { get; set; }//Many to many
		public ICollection<Hopitaux> Hopitauxes { get; set; }//Many to many
	}
}
