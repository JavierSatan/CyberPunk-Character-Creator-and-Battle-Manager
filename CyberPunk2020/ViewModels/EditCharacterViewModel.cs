using CyberPunk2020.Data.Enum;
using CyberPunk2020.Models;

namespace CyberPunk2020.ViewModels
{
    public class EditCharacterViewModel
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }
        public string Name { get; set; }
        public string? URL { get; set; }
        public int StatPoints { get; set; }
        public int age { get; set; }
        public RoleCategory Role { get; set; }

        //Stats
        public int? StatsId { get; set; }
        public Stats? Stats { get; set; }

        //skills
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }
    }
}
