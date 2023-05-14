using CyberPunk2020.Data.Enum;
using CyberPunk2020.Interfaces;
using CyberPunk2020.Models;
using CyberPunk2020.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CyberPunk2020.Controllers
{
    public class CharacterController : Controller
    {
        //private readonly ApplicationDbContext _context;  //old way
        private readonly ICharacterRepository _characterRepository;

        private readonly IPhotoService _photoService;

        public CharacterController(ICharacterRepository characterRepository, IPhotoService photoService)//this is our database
        {
            _characterRepository = characterRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()///CCC controller
        {
            IEnumerable<Character> characters = await _characterRepository.GetAll();
            //var chatacters = _context.Characters.ToList();///MMMM mdoel also this is how you return a single thing
            return View(characters);//VVVV veiw
        }

        public async Task<IActionResult> Detail(int id)
        {
            Character character = await _characterRepository.GetByIdAsync(id);
            return View(character);
        }

        //CREEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAATTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEE character
        public IActionResult CreateChooseRole()
        {
            return View();
        }
        public IActionResult CreateRMAS()
        {
            return View();
        }

        public IActionResult CreateAssignSkills()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCharacterViewModel characterVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(characterVM.Image);

                var character = new Character
                {
                    Image = result.Url.ToString(),
                    Name = characterVM.Name,
                    StatPoints = characterVM.StatPoints,
                    age = characterVM.age,
                    Role = characterVM.Role,

                    Stats = new Stats
                    {
                        INT = characterVM.Stats.INT,
                        REF = characterVM.Stats.REF,
                        TECH = characterVM.Stats.TECH,
                        COOL = characterVM.Stats.COOL,
                        ATTR = characterVM.Stats.ATTR,
                        LUCK = characterVM.Stats.LUCK,
                        MA = characterVM.Stats.MA,
                        BODY = characterVM.Stats.BODY,
                        EMP = characterVM.Stats.EMP,
                        Humanity = characterVM.Stats.Humanity,
                        Run = characterVM.Stats.Run,
                        Leap = characterVM.Stats.Leap,
                        Lift = characterVM.Stats.Lift,
                        Carry = characterVM.Stats.Carry,
                        Save = characterVM.Stats.Save,//
                        BTM = characterVM.Stats.BTM,
                    },

                    Skill = new Skill
                    {

                        SpecialAbility = characterVM.Skill.SpecialAbility,
                        SpecialAbilityLvl = characterVM.Skill.SpecialAbilityLvl,

                        //ATTR
                        PersonalGrooming = characterVM.Skill.PersonalGrooming,
                        WardrobeAndStyle = characterVM.Skill.WardrobeAndStyle,

                        //BODY
                        Endurance = characterVM.Skill.Endurance,
                        StrengthFeat = characterVM.Skill.StrengthFeat,
                        Swimming = characterVM.Skill.Swimming,

                        //COOL/WILL
                        Interrogation = characterVM.Skill.Interrogation,
                        Oratory = characterVM.Skill.Oratory,
                        ResistTortureOrDrugs = characterVM.Skill.ResistTortureOrDrugs,
                        Streetwise = characterVM.Skill.Streetwise,

                        //EMPATHY
                        HumanPerception = characterVM.Skill.HumanPerception,
                        Interview = characterVM.Skill.Interview,
                        Leadership = characterVM.Skill.Leadership,
                        Social = characterVM.Skill.Social,
                        PersuasionAndFastTalk = characterVM.Skill.PersuasionAndFastTalk,
                        Perform = characterVM.Skill.Perform,

                        //INT
                        Accounting = characterVM.Skill.Accounting,
                        Anthropology = characterVM.Skill.Anthropology,
                        AwarenessOrNotice = characterVM.Skill.AwarenessOrNotice,
                        Biology = characterVM.Skill.Biology,
                        Botany = characterVM.Skill.Botany,
                        Chemistry = characterVM.Skill.Chemistry,
                        Composition = characterVM.Skill.Composition,
                        DiagnoseIllness = characterVM.Skill.DiagnoseIllness,
                        EducationAndGeneralKnowledge = characterVM.Skill.EducationAndGeneralKnowledge,
                        Expert = characterVM.Skill.Expert,
                        Gamble = characterVM.Skill.Gamble,
                        Geology = characterVM.Skill.Geology,
                        HideOrEvade = characterVM.Skill.HideOrEvade,
                        History = characterVM.Skill.History,
                        KnowLanguages = LanguageCategory.Japanese, //(Choose One)
                        LibrarySearch = characterVM.Skill.LibrarySearch,
                        Mathematics = characterVM.Skill.Mathematics,
                        Physics = characterVM.Skill.Physics,
                        Programming = characterVM.Skill.Programming,
                        ShadowOrTrack = characterVM.Skill.ShadowOrTrack,
                        StockMarket = characterVM.Skill.StockMarket,
                        SystemKnowledge = characterVM.Skill.SystemKnowledge,
                        Teaching = characterVM.Skill.Teaching,
                        Zoology = characterVM.Skill.Zoology,

                        //REF
                        Archery = characterVM.Skill.Archery,
                        Athletic = characterVM.Skill.Athletic,
                        Brawling = characterVM.Skill.Brawling,
                        Dance = characterVM.Skill.Dance,
                        DodgeAndEscape = characterVM.Skill.DodgeAndEscape,
                        Driving = characterVM.Skill.Driving,
                        Fencing = characterVM.Skill.Fencing,
                        Handgun = characterVM.Skill.Handgun,
                        HeavyWeapons = characterVM.Skill.HeavyWeapons,
                        MartialArts = characterVM.Skill.MartialArts, // (Choose One)
                        Melee = characterVM.Skill.Melee,
                        Motorcycle = characterVM.Skill.Motorcycle,
                        OperateHeavyMachinery = characterVM.Skill.OperateHeavyMachinery,
                        PilotGyro = characterVM.Skill.PilotGyro,
                        PilotFixedWing = characterVM.Skill.PilotFixedWing,
                        PilotDirigible = characterVM.Skill.PilotDirigible,
                        PilotVectThrustVehicle = characterVM.Skill.PilotVectThrustVehicle,
                        Rifle = characterVM.Skill.Rifle,
                        Stealth = characterVM.Skill.Stealth,
                        Submachinegun = characterVM.Skill.Submachinegun,

                        //TECH
                        AeroTech = characterVM.Skill.AeroTech,
                        AVTech = characterVM.Skill.AVTech,
                        BasicTech = characterVM.Skill.BasicTech,
                        CryotankOperation = characterVM.Skill.CryotankOperation,
                        CyberdeckDesign = characterVM.Skill.CyberdeckDesign,
                        CyberTech = characterVM.Skill.CyberTech,
                        Demolitions = characterVM.Skill.Demolitions,
                        Disguise = characterVM.Skill.Disguise,
                        Electronics = characterVM.Skill.Electronics,
                        ElectSecurity = characterVM.Skill.ElectSecurity,
                        FirstAid = characterVM.Skill.FirstAid,
                        Forgery = characterVM.Skill.Forgery,
                        GyroTech = characterVM.Skill.GyroTech,
                        PaintOrDraw = characterVM.Skill.PaintOrDraw,
                        PhotoAndFilm = characterVM.Skill.PhotoAndFilm,
                        Pharmaceuticals = characterVM.Skill.Pharmaceuticals,
                        PickLock = characterVM.Skill.PickLock,
                        PickPocket = characterVM.Skill.PickPocket,
                        PlayInstrument = characterVM.Skill.PlayInstrument,
                        Weaponsmith = characterVM.Skill.Weaponsmith,
                        WeaponsTech = characterVM.Skill.WeaponsTech,
                    }
                };
                _characterRepository.Add(character);
                return RedirectToAction("Index", new { id = characterVM.Id });
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(characterVM);
        }

        //EDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDIIIIIIIIIIIIIIIIIIIIIIIIT character
        public async Task<IActionResult> Edit(int id)
        {
            var character = await _characterRepository.GetByIdAsync(id);
            if (character == null)
            {
                return View("Error");
            }
            var CharacterVM = new EditCharacterViewModel
            {
                URL = character.Image,
                Name = character.Name,
                StatPoints = character.StatPoints,
                age = character.age,
                Role = character.Role,

                SkillId = character.SkillId,
                Skill = character.Skill,

                StatsId = character.StatstId,
                Stats = character.Stats,

            };
            return View(CharacterVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCharacterViewModel characterMV)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit club");
                return View("Edit", characterMV);
            }

            var userClub = await _characterRepository.GetByIdAsyncNoTracking(id);

            if (userClub == null)
            {
                return View("Error");
            }

            var photoResult = await _photoService.AddPhotoAsync(characterMV.Image);

            if (photoResult.Error != null)
            {
                ModelState.AddModelError("Image", "Photo upload failed");
                return View(characterMV);
            }

            if (!string.IsNullOrEmpty(userClub.Image))
            {
                _ = _photoService.DeletePhotoAsync(userClub.Image);
            }

            var character = new Character
            {
                Id = id,
                Name = characterMV.Name,
                Image = photoResult.Url.ToString(),
                StatPoints= characterMV.StatPoints,
                age = characterMV.age,
                Role = characterMV.Role,

                //skills
                SkillId= characterMV.SkillId,
                Skill= characterMV.Skill,

                //stats
                StatstId=characterMV.StatsId,
                Stats= characterMV.Stats,
            };

            _characterRepository.Update(character);

            return RedirectToAction("Index");
        }

        //DELEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEETE CHARACTER
        public async Task<IActionResult> Delete(int id)
        {
            var characterDetail = await _characterRepository.GetByIdAsync(id);
            if (characterDetail == null) { return View("Error"); }

            return View(characterDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            var characterDetail = await _characterRepository.GetByIdAsync(id);
            if (characterDetail == null) { return View("Error"); }
            _characterRepository.Delete(characterDetail);
            return RedirectToAction("Index");
        }
    }
}
