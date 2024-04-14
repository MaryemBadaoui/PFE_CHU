namespace PFE_CHU.Models
{
    public class Role
    {
        public int? Id { get; set; }
        public string Libelle { get; set; }

        public ICollection<User>? Users { get; set; }//One to many
	}
}
