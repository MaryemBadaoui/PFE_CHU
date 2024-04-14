namespace PFE_CHU.Models
{
	public class Hopitaux
	{
		public int? Id { get; set; }
		public String Libelle { get; set; }
        public ICollection<User>? Users { get; set; }//One to many

    }
}
