using System.ComponentModel.DataAnnotations;

namespace CyberPunk2020.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public ICollection<Character> Characters { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
