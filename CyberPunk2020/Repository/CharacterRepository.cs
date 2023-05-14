using CyberPunk2020.Data;
using CyberPunk2020.Interfaces;
using CyberPunk2020.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberPunk2020.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _context;
        public CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Character character)
        {
            _context.Add(character);//makes sql
            return Save();//creates entity
        }

        public bool Delete(Character character)
        {
            _context.Remove(character);
            return Save();
        }

        public async Task<IEnumerable<Character>> GetAll()//returns all characters
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character> GetByIdAsync(int id)//returns one character
        {
            return await _context.Characters.Include(s => s.Stats).Include(sk => sk.Skill).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Character> GetByIdAsyncNoTracking(int id)//returns one character
        {
            return await _context.Characters.Include(s => s.Stats).Include(sk => sk.Skill).AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Character character)
        {
            _context.Update(character);
            return Save();
        }
    }
}
