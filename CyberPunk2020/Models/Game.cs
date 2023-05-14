using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPunk2020.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? Round { get; set; }
        public string? Image { get; set; }
        public List<Player>? Players { get; set; }
        public List<Npc>? Npcs { get; set; }
    }
}
