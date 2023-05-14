using CyberPunk2020.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberPunk2020.ViewModels
{
    public class EditGameViewModel
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? Round { get; set; }

        public IFormFile Image { get; set; }
        public string? URL { get; set; }
        public List<Player>? Players { get; set; }
        public List<Npc>? Npcs { get; set; }
        /*{
            get
            {
                if (Players == null)
                {
                    return new List<Player>();
                }
                else
                {
                    return Players;
                }

            }
            set
            {
                Players = value;
            }
        }*/
    }
}
