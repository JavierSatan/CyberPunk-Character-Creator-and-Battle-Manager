using CyberPunk2020.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPunk2020.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public int StatPoints { get; set; } = 0;
        public int age { get; set; }
        public RoleCategory Role { get; set; }

        [ForeignKey("Stats")]
        public int? StatstId { get; set; }
        public Stats? Stats { get; set; }

        //Skill stuff
        [ForeignKey("Skill")]
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }
    }
}
