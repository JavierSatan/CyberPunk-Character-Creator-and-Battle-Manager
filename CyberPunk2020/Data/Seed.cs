using CyberPunk2020.Data.Enum;
using CyberPunk2020.Models;

namespace CyberPunk2020.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Characters.Any())
                {
                    context.Characters.AddRange(new List<Character>()
                    {
                        new Character()
                        {
                            Name = "Bro",
                            Image = "https://wompampsupport.azureedge.net/fetchimage?siteId=7575&v=2&jpgQuality=100&width=700&url=https%3A%2F%2Fi.kym-cdn.com%2Fphotos%2Fimages%2Fnewsfeed%2F001%2F584%2F806%2F1a7.jpg",
                            StatPoints = 40,
                            age = 21,
                            Role = RoleCategory.RockerBoy,
                            Stats = new Stats()
                            {
                                INT = 1,
                                REF = 1,
                                TECH = 1,
                                COOL = 1,
                                ATTR = 1,
                                LUCK = 1,
                                MA = 1,
                                BODY = 1,
                                EMP = 1,
                                Humanity = 1,
                                Run = 1,
                                Leap = 1,
                                Lift = 1,
                                Carry= 1,
                                Save= 1,
                                BTM = 1,

                            },

                            Skill = new Skill()
                            {
                                SpecialAbility = SpecialAbilityCategory.CharismaLeadership,
                                SpecialAbilityLvl = 1,

                                //ATTR
                                PersonalGrooming = 1,
                                WardrobeAndStyle = 1,

                                //BODY
                                Endurance = 1,
                                StrengthFeat = 1,
                                Swimming = 1,

                                //COOL/WILL
                                Interrogation = 1,
                                Oratory = 1,
                                ResistTortureOrDrugs = 1,
                                Streetwise = 1,

                                //EMPATHY
                                HumanPerception = 1,
                                Interview = 1,
                                Leadership = 1,
                                Social = 1,
                                PersuasionAndFastTalk = 1,
                                Perform = 1,

                                //INT
                                Accounting = 1,
                                Anthropology = 1,
                                AwarenessOrNotice = 1,
                                Biology = 1,
                                Botany = 1,
                                Chemistry = 1,
                                Composition = 1,
                                DiagnoseIllness = 1,
                                EducationAndGeneralKnowledge = 1,
                                Expert = 1,
                                Gamble = 1,
                                Geology = 1,
                                HideOrEvade = 1,
                                History = 1,
                                KnowLanguages = LanguageCategory.Japanese, //(Choose One)
                                LibrarySearch = 1,
                                Mathematics = 1,
                                Physics = 1,
                                Programming = 1,
                                ShadowOrTrack = 1,
                                StockMarket = 1,
                                SystemKnowledge = 1,
                                Teaching = 1,
                                Zoology = 1,

                                //REF
                                Archery = 1,
                                Athletic = 1,
                                Brawling = 1,
                                Dance = 1,
                                DodgeAndEscape = 1,
                                Driving = 1,
                                Fencing = 1,
                                Handgun = 1,
                                HeavyWeapons = 1,
                                MartialArts = 11, // (Choose One)
                                Melee  = 1,
                                Motorcycle = 1,
                                OperateHeavyMachinery = 1,
                                PilotGyro = 1,
                                PilotFixedWing = 1,
                                PilotDirigible = 1,
                                PilotVectThrustVehicle = 1,
                                Rifle = 1,
                                Stealth = 1,
                                Submachinegun = 1,

                                //TECH
                                AeroTech = 1,
                                AVTech = 1,
                                BasicTech = 1,
                                CryotankOperation = 1,
                                CyberdeckDesign = 1,
                                CyberTech = 1,
                                Demolitions  = 1,
                                Disguise = 1,
                                Electronics = 1,
                                ElectSecurity = 1,
                                FirstAid = 1,
                                Forgery = 1,
                                GyroTech = 1,
                                PaintOrDraw = 1,
                                PhotoAndFilm = 1,
                                Pharmaceuticals = 1,
                                PickLock = 1,
                                PickPocket = 1,
                                PlayInstrument = 1,
                                Weaponsmith = 1,
                            }

                         },

                         new Character()
                        {
                            Name = "Meow",
                            Image = "https://www.meme-arsenal.com/memes/0158b40988118aee47fecf72245be7b6.jpg",
                            StatPoints = 40,
                            age = 19,
                            Role = RoleCategory.Cop,
                            Stats = new Stats()
                            {
                                INT = 12,
                                REF = 11,
                                TECH = 1,
                                COOL = 1,
                                ATTR = 11,
                                LUCK = 1,
                                MA = 1,
                                BODY = 1,
                                EMP = 1,
                                Humanity = 1,
                                Run = 1,
                                Leap = 1,
                                Lift = 1,
                                Carry= 1,
                                Save= 1,
                                BTM = 1,

                            },

                            Skill = new Skill()
                            {
                                SpecialAbility = SpecialAbilityCategory.CharismaLeadership,
                                SpecialAbilityLvl = 1,

                                //ATTR
                                PersonalGrooming = 1,
                                WardrobeAndStyle = 1,

                                //BODY
                                Endurance = 1,
                                StrengthFeat = 1,
                                Swimming = 1,

                                //COOL/WILL
                                Interrogation = 1,
                                Oratory = 1,
                                ResistTortureOrDrugs = 1,
                                Streetwise = 1,

                                //EMPATHY
                                HumanPerception = 1,
                                Interview = 1,
                                Leadership = 1,
                                Social = 1,
                                PersuasionAndFastTalk = 1,
                                Perform = 1,

                                //INT
                                Accounting = 1,
                                Anthropology = 1,
                                AwarenessOrNotice = 1,
                                Biology = 1,
                                Botany = 1,
                                Chemistry = 1,
                                Composition = 1,
                                DiagnoseIllness = 1,
                                EducationAndGeneralKnowledge = 1,
                                Expert = 1,
                                Gamble = 1,
                                Geology = 1,
                                HideOrEvade = 1,
                                History = 1,
                                KnowLanguages = LanguageCategory.Russian, //(Choose One)
                                LibrarySearch = 1,
                                Mathematics = 1,
                                Physics = 1,
                                Programming = 1,
                                ShadowOrTrack = 1,
                                StockMarket = 1,
                                SystemKnowledge = 1,
                                Teaching = 1,
                                Zoology = 1,

                                //REF
                                Archery = 1,
                                Athletic = 1,
                                Brawling = 1,
                                Dance = 1,
                                DodgeAndEscape = 1,
                                Driving = 1,
                                Fencing = 1,
                                Handgun = 1,
                                HeavyWeapons = 1,
                                MartialArts = 10, // (Choose One)
                                Melee  = 1,
                                Motorcycle = 1,
                                OperateHeavyMachinery = 1,
                                PilotGyro = 1,
                                PilotFixedWing = 1,
                                PilotDirigible = 1,
                                PilotVectThrustVehicle = 1,
                                Rifle = 1,
                                Stealth = 1,
                                Submachinegun = 1,

                                //TECH
                                AeroTech = 1,
                                AVTech = 1,
                                BasicTech = 1,
                                CryotankOperation = 1,
                                CyberdeckDesign = 1,
                                CyberTech = 1,
                                Demolitions  = 1,
                                Disguise = 1,
                                Electronics = 1,
                                ElectSecurity = 1,
                                FirstAid = 1,
                                Forgery = 1,
                                GyroTech = 1,
                                PaintOrDraw = 1,
                                PhotoAndFilm = 1,
                                Pharmaceuticals = 1,
                                PickLock = 1,
                                PickPocket = 1,
                                PlayInstrument = 1,
                                Weaponsmith = 1,
                            }

                         },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}