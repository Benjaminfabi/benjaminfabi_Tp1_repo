using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Player
    {
        public Player()
        {
        }
        public Player(int Id, string NickName, string Email, string PhoneNumber, string FirstName, string LastName, PlayerLevel level)
        {
            this.Id = Id;
            this.NickName = NickName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;
        }
        public void EditFrom(Player p)
        {
            this.Id = p.Id;
            this.NickName = p.NickName;
            this.Email = p.Email;
            this.PhoneNumber = p.PhoneNumber;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Level = p.Level;
            this.TeamId = p.TeamId;
        }

        [Key]
        [Required]
        public int Id { get; set; }

        public string NickName { get; set; }
        [EmailAddress(ErrorMessage = "The address is invalid. Try another.")]
        [Required]
        [MaxLength(50, ErrorMessage = "50 caractères maximum")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Please use this format : ###:###:####")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "A first name is required.")]
        [MaxLength(50, ErrorMessage = "50 caractères maximum")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A last name is required.")]
        [MaxLength(50, ErrorMessage = "50 caractères maximum")]
        public string LastName { get; set; }

        public PlayerLevel Level { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }


    }
}