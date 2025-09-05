using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync(string? filterOn= null, string? filterQuery = null, 
            string? sortBy = null, bool isAscending = true,
            int pageNumber = 1, int pageSize = 100);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAync(Guid id, Walk walk);
        Task<Walk> DeleteAync(Guid id);

    }
}
