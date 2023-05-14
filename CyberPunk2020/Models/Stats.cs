using System.ComponentModel.DataAnnotations;

namespace CyberPunk2020.Models
{
    public class Stats
    {
        [Key]
        public int Id { get; set; }
        public int INT { get; set; } = 0;
        public int REF { get; set; } = 0;
        public int TECH { get; set; } = 0;
        public int COOL { get; set; } = 0;
        public int ATTR { get; set; } = 0;
        public int LUCK { get; set; } = 0;
        public int MA { get; set; } = 0;
        public int BODY { get; set; } = 0;
        public int EMP { get; set; } = 0;
        public int Humanity { get; set; } = 0;
        public int Run { get; set; } = 0;
        public double Leap { get; set; } = 0;
        public int Lift { get; set; } = 0;
        public int Carry { get; set; } = 0;
        public int Save { get; set; } = 0;
        public int BTM { get; set; } = 0;

    }
}