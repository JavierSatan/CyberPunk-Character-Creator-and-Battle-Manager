using Microsoft.AspNetCore.Mvc;

namespace CyberPunk2020.ViewModels
{
    public class CreatePlayerViewModel
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string? Name { get; set; }
        public int? HP { get; set; }
        public int? BTM { get; set; }
    }
}
