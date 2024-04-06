namespace PFE_CHU.Models
{
    public class Service
    {

        public int? Id { get; set; }
        public string Libelle { get; set; }

        public ICollection<Role> Roles { get; set; }//One to many
		
	}
}
