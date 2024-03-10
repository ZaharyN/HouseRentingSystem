using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Models.Houses;
using HouseRentingSystem.Infrastructure.Data.DataModels;
using HouseRentingSystem.Models.Houses;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHoousesAsync();
        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();
        Task<bool> CategoryExistsAsync(int categoryId);
        Task<int> CreateAsync(HouseFormModel model, int agentId);
    }
}
