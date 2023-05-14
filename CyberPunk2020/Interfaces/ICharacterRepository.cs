using CyberPunk2020.Models;

namespace CyberPunk2020.Interfaces
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetAll();
        Task<Character> GetByIdAsync(int id);
        Task<Character> GetByIdAsyncNoTracking(int id);
        bool Add(Character character);
        bool Update(Character character);
        bool Delete(Character character);
        bool Save();

    }
}
