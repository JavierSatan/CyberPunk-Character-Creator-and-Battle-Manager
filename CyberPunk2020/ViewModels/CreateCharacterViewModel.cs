using CyberPunk2020.Data.Enum;
using CyberPunk2020.Models;

namespace CyberPunk2020.ViewModels
{
    public class CreateCharacterViewModel
    {
        public int Id { get; set; }
        public IFormFile? Image { get; set; }
        public string? Name { get; set; }
        public int StatPoints { get; set; } = 0;
        public int age { get; set; }
        public RoleCategory Role { get; set; }
        public Stats? Stats { get; set; }
        public Skill? Skill { get; set; }
    }
}
