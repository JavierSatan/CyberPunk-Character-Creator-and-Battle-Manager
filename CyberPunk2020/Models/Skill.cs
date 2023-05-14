using CyberPunk2020.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberPunk2020.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public SpecialAbilityCategory? SpecialAbility { get; set; }
        public int? SpecialAbilityLvl { get; set; } = 0;

        public int? WildernessSurvival { get; set; } = 0;
        //ATTR
        public int? PersonalGrooming { get; set; } = 0;
        public int? WardrobeAndStyle { get; set; } = 0;

        //BODY
        public int? Endurance { get; set; } = 0;
        public int? StrengthFeat { get; set; } = 0;
        public int? Swimming { get; set; } = 0;

        //COOL/WILL
        public int? Interrogation { get; set; } = 0;
        public int? Intimidate { get; set; } = 0;
        public int? Oratory { get; set; } = 0;
        public int? ResistTortureOrDrugs { get; set; } = 0;
        public int? Streetwise { get; set; } = 0;

        //EMPATHY
        public int? HumanPerception { get; set; } = 0;
        public int? Interview { get; set; } = 0;
        public int? Leadership { get; set; } = 0;
        public int? Social { get; set; } = 0;
        public int? PersuasionAndFastTalk { get; set; } = 0;
        public int? Perform { get; set; } = 0;
        public int? Seduction { get; set; } = 0;

        //INT
        public int? Accounting { get; set; } = 0;
        public int? Anthropology { get; set; } = 0;
        public int? AwarenessOrNotice { get; set; } = 0;
        public int? Biology { get; set; } = 0;
        public int? Botany { get; set; } = 0;
        public int? Chemistry { get; set; } = 0;// = 0;
        public int? Composition { get; set; } = 0;
        public int? DiagnoseIllness { get; set; } = 0;
        public int? EducationAndGeneralKnowledge { get; set; } = 0;
        public int? Expert { get; set; } = 0;
        public int? Gamble { get; set; } = 0;
        public int? Geology { get; set; } = 0;
        public int? HideOrEvade { get; set; } = 0;
        public int? History { get; set; } = 0;
        public LanguageCategory? KnowLanguages { get; set; } //(Choose One) make the enum
        public int? LibrarySearch { get; set; } = 0;
        public int? Mathematics { get; set; } = 0;
        public int? Physics { get; set; } = 0;
        public int? Programming { get; set; } = 0;
        public int? ShadowOrTrack { get; set; } = 0;
        public int? StockMarket { get; set; } = 0;
        public int? SystemKnowledge { get; set; } = 0;
        public int? Teaching { get; set; } = 0;
        public int? Zoology { get; set; } = 0;
        public int? WeaponsTech { get; set; } = 0;

        //REF
        public int? Archery { get; set; } = 0;
        public int? Athletic { get; set; } = 0;
        public int? Brawling { get; set; } = 0;
        public int? Dance { get; set; } = 0;
        public int? DodgeAndEscape { get; set; } = 0;
        public int? Driving { get; set; } = 0;
        public int? Fencing { get; set; } = 0;
        public int? Handgun { get; set; } = 0;
        public int? HeavyWeapons { get; set; } = 0;
        public int? MartialArts { get; set; } = 0;
        public int? Melee { get; set; } = 0;
        public int? Motorcycle { get; set; } = 0;
        public int? OperateHeavyMachinery { get; set; } = 0;
        public int? PilotGyro { get; set; } = 0;
        public int? PilotFixedWing { get; set; } = 0;
        public int? PilotDirigible { get; set; } = 0;
        public int? PilotVectThrustVehicle { get; set; } = 0;
        public int? Rifle { get; set; } = 0;
        public int? Stealth { get; set; } = 0;
        public int? Submachinegun { get; set; } = 0;

        //TECH
        public int? AeroTech { get; set; } = 0;
        public int? AVTech { get; set; } = 0;
        public int? BasicTech { get; set; } = 0;
        public int? CryotankOperation { get; set; } = 0;
        public int? CyberdeckDesign { get; set; } = 0;
        public int? CyberTech { get; set; } = 0;
        public int? Demolitions { get; set; } = 0;
        public int? Disguise { get; set; } = 0;
        public int? Electronics { get; set; } = 0;
        public int? ElectSecurity { get; set; } = 0;
        public int? FirstAid { get; set; } = 0;
        public int? Forgery { get; set; } = 0;
        public int? GyroTech { get; set; } = 0;
        public int? PaintOrDraw { get; set; } = 0;
        public int? PhotoAndFilm { get; set; } = 0;
        public int? Pharmaceuticals { get; set; } = 0;
        public int? PickLock { get; set; } = 0;
        public int? PickPocket { get; set; } = 0;
        public int? PlayInstrument { get; set; } = 0;
        public int? Weaponsmith { get; set; } = 0;
    }
}
