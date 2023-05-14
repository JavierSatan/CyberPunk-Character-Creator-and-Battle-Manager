using CyberPunk2020.Interfaces;
using CyberPunk2020.Models;
using CyberPunk2020.Repository;
using CyberPunk2020.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CyberPunk2020.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        private readonly IPhotoService _photoService;

        public GameController(IGameRepository gameRepository, IPhotoService photoService)//this is our database
        {
            _gameRepository = gameRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()///CCC controller
        {
            IEnumerable<Game> Games = await _gameRepository.GetAll();
            return View(Games);//VVVV veiw
        }

        public async Task<IActionResult> Detail(int id)
        {
            Game games = await _gameRepository.GetByIdAsync(id);
            return View(games);
        }

        //CREEEEEEEEEEEEEEEEEEEEEEAAAAAAAAAAAAAAAAAAAAAAAAAAATTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEE game
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGameViewModel gameVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(gameVM.Image);

                var game = new Game
                {
                    name = gameVM.name,
                    description = gameVM.description,
                    Image = result.Url.ToString(),
                    Round = 0,
                    Players = gameVM.Players,
                    Npcs = gameVM.Npcs
                };

                if (game.Players == null)
                {
                    game.Players = new List<Player>();
                }

                if (game.Npcs == null)
                {
                    game.Npcs = new List<Npc>();
                }

                _gameRepository.Add(game);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(gameVM);
        }

        /////////////////////////////////////////////////////////////////////// Create a new player for a game
        public IActionResult CreatePlayer(int id)
        {
            var viewModel = new CreatePlayerViewModel
            {
                GameId = id
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer(CreatePlayerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var game = await _gameRepository.GetByIdAsync(viewModel.Id);
            if (game == null)
            {
                return NotFound();
            }

            var player = new Player
            {
                Name = viewModel.Name,
                HP = viewModel.HP,
                BTM = viewModel.BTM
            };

            if (player.BTM > 0)//making sure the btm is always (-)
            {
                player.BTM = player.BTM * -1;
            }

            game.Players.Add(player);
            await _gameRepository.UpdateAsync(game);

            return RedirectToAction("Detail", new { id = viewModel.Id });

        }

        //meoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooeeeew inflitc damage
        [HttpPost]
        public async Task<IActionResult> InflictDamage(int gameId, int playerId, int damageAmount)
        {

            var game = await _gameRepository.GetByIdAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var player = game?.Players.FirstOrDefault(p => p.Id == playerId);

            if (player != null)
            {
                // Reduce the player's HP by the specified damage amount
                if (player.HP <= 0)
                {
                    player.HP = 0;
                }
                else
                {
                    damageAmount = damageAmount + (int)player.BTM;
                    player.HP -= damageAmount;
                }

                // Save changes to the database
                _gameRepository.Save();
            }

            // Redirect back to the game view
            return RedirectToAction("Detail", new { id = gameId });
        }

        //meoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooeeeew heal damage
        [HttpPost]
        public async Task<IActionResult> heal(int gameId, int playerId, int healAmount)
        {

            var game = await _gameRepository.GetByIdAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var player = game?.Players.FirstOrDefault(p => p.Id == playerId);

            if (player != null)
            {
                // Increase the player's HP by the specified damage amount
                player.HP += healAmount;

                // Save changes to the database
                _gameRepository.Save();
            }

            // Redirect back to the game view
            return RedirectToAction("Detail", new { id = gameId });
        }

        /////////////////////////////////////////////////////////////////////// Create a new player for a game
        public IActionResult CreateNPC(int id)
        {
            var viewModel = new CreateNPCViewModel
            {
                GameId = id
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNPC(CreateNPCViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var game = await _gameRepository.GetByIdAsync(viewModel.Id);
            if (game == null)
            {
                return NotFound();
            }

            var npc = new Npc
            {
                Name = viewModel.Name,
                HP = viewModel.HP,
                BTM = viewModel.BTM
            };

            if(npc.BTM > 0)
            {
                npc.BTM = npc.BTM * -1;
            }

            game.Npcs.Add(npc);
            await _gameRepository.UpdateAsync(game);

            return RedirectToAction("Detail", new { id = viewModel.Id });
        }

        //meoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooeeeew inflitc damage
        [HttpPost]
        public async Task<IActionResult> InflictDamageNPC(int gameId, int npcId, int damageAmount)
        {

            var game = await _gameRepository.GetByIdAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var npc = game?.Npcs.FirstOrDefault(p => p.Id == npcId);

            if (npc != null)
            {
                // Reduce the player's HP by the specified damage amount
                if (npc.HP <= 0)
                {
                    npc.HP = 0;
                }
                else
                {
                    damageAmount = damageAmount + (int)npc.BTM;
                    npc.HP -= damageAmount;
                }

                // Save changes to the database
                _gameRepository.Save();
            }

            // Redirect back to the game view
            return RedirectToAction("Detail", new { id = gameId });
        }

        //meoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooeeeew heal damage
        [HttpPost]
        public async Task<IActionResult> healNPC(int gameId, int npcId, int healAmount)
        {

            var game = await _gameRepository.GetByIdAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var npc = game?.Npcs.FirstOrDefault(p => p.Id == npcId);

            if (npc != null)
            {
                // Increase the player's HP by the specified damage amount
                npc.HP += healAmount;

                // Save changes to the database
                _gameRepository.Save();
            }

            // Redirect back to the game view
            return RedirectToAction("Detail", new { id = gameId });
        }






        //EDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDIIIIIIIIIIIIIIIIIIIIIIIIT game
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            if (game == null)
            {
                return View("Error");
            }
            var GameVM = new EditGameViewModel
            {
                URL = game.Image,
                name = game.name,
                description = game.description,
                Round = game.Round,
                Players = game.Players,
            };
            return View(GameVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditGameViewModel gameVm)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit club");
                return View("Edit", gameVm);
            }

            var userClub = await _gameRepository.GetByIdAsyncNoTracking(id);

            if (userClub == null)
            {
                return View("Error");
            }

            var photoResult = await _photoService.AddPhotoAsync(gameVm.Image);

            if (photoResult.Error != null)
            {
                ModelState.AddModelError("Image", "Photo upload failed");
                return View(gameVm);
            }

            if (!string.IsNullOrEmpty(userClub.Image))
            {
                _ = _photoService.DeletePhotoAsync(userClub.Image);
            }

            var game = new Game
            {
                Id = id,
                Image = photoResult.Url.ToString(),
                name = gameVm.name,
                description = gameVm.description,
                Round = gameVm.Round,
                Players = gameVm.Players,
            };

            _gameRepository.Update(game);

            return RedirectToAction("Index");
        }

        //DELEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEETE game
        public async Task<IActionResult> Delete(int id)
        {
            var gameDetail = await _gameRepository.GetByIdAsync(id);
            if (gameDetail == null) { return View("Error"); }

            return View(gameDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            var gameDetail = await _gameRepository.GetByIdAsync(id);
            if (gameDetail == null) { return View("Error"); }
            _gameRepository.Delete(gameDetail);
            return RedirectToAction("Index");
        }

        // DELETE a player from a game
        [HttpPost]
        public async Task<IActionResult> DeletePlayer(int gameId, int playerId)
        {
            var game = await _gameRepository.GetByIdAsync(gameId);

            if (game == null)
            {
                return NotFound();
            }

            var player = game.Players.FirstOrDefault(p => p.Id == playerId);

            if (player == null)
            {
                return NotFound();
            }

            game.Players.Remove(player);

            await _gameRepository.UpdateAsync(game);

            return RedirectToAction("Detail", new { id = gameId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteNPC(int gameId, int npcId)
        {
            var game = await _gameRepository.GetByIdAsync(gameId);

            if (game == null)
            {
                return NotFound();
            }

            var npc = game.Npcs.FirstOrDefault(p => p.Id == npcId);

            if (npc == null)
            {
                return NotFound();
            }
            game.Npcs.Remove(npc);

            await _gameRepository.UpdateAsync(game);

            return RedirectToAction("Detail", new { id = gameId });
        }
    }
}
