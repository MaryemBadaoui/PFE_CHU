namespace PFE_CHU.Models
{
    public class Role
    {
        int? id { get; set; }
        string libelle { get; set; }

        ICollection<user >   users{ get; set; }
    }
}
