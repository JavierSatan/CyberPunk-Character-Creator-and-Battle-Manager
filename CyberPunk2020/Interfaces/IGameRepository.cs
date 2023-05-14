using CyberPunk2020.Models;

namespace CyberPunk2020.Interfaces
{
    public interface IGameRepository
    {
        Task<IEnumerable<Game>> GetAll();
        Task<Game> GetByIdAsync(int id);
        Task<Game> GetByIdAsyncNoTracking(int id);

        //just added
        Task<Game> UpdateAsync(Game game);

        //Task<IEnumerable<Game>> GetGameByCity(string city);    //future feature for games probabbly not going to be in this IChar
        bool Add(Game game);
        bool Update(Game game);
        bool Delete(Game game);
        bool Save();

    }
}