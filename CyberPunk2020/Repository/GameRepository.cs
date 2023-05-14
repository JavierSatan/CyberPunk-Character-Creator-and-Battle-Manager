using CyberPunk2020.Data;
using CyberPunk2020.Interfaces;
using CyberPunk2020.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberPunk2020.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;
        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Game game)
        {
            _context.Add(game);//makes sql
            return Save();//creates entity
        }

        public bool Delete(Game game)
        {
            _context.Remove(game);
            return Save();
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await _context.Games.ToListAsync();
        }

        ////////////////////////////////////just added

        public async Task<Game> UpdateAsync(Game game)
        {
            _context.Games.Update(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<Game> GetByIdAsync(int id)
        {
           return await _context.Games.Include(p => p.Players).Include(n => n.Npcs).FirstOrDefaultAsync(c => c.Id == id);
           //return await _context.Games.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Game> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Games.Include(p => p.Players).Include(n => n.Npcs).AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            //return await _context.Games.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Game game)
        {
            _context.Update(game);
            return Save();
        }
    }
}
