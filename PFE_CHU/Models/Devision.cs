namespace PFE_CHU.Models
{
	public class Devision
	{
		public int? Id { get; set; }
		public String Libelle { get; set; }
        public ICollection<User>? Users { get; set; }//One to many
        public ICollection<Service>? Services { get; set; }
    }
}
