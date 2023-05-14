using System.ComponentModel.DataAnnotations;

namespace CyberPunk2020.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? HP { get; set; }
        public int? BTM { get; set; }

    }
}
