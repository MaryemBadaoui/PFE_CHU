using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace PFE_CHU.Models
{
    public class user
    {
        int? id { get; set; }
        string nom { get; set; }
        string prenom { get; set; }
        string login { get; set; }
        [DataType(DataType.Password)]
        string password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        string confirmepswd { get; set; }
        Role role { get; set; }
        int RoleId { get; set; }
 


    }
}
