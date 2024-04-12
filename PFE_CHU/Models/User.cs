using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace PFE_CHU.Models
{
    public class User
    {
        public int? Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Required]
        public string Confirmepswd { get; set; }
        public Role Role { get; set; } // pour faire les jointures 
        public int RoleId { get; set; }//Clé etrangere f User dyal la class Role 
        public Service Service { get; set; }
        public int ServiceId { get; set; }
        public Devision Devision { get; set; }
        public int DevisionId { get; set; }
        public Hopitaux Hopitaux { get; set; }
        public int HopitauxId { get; set; }







    }
}
