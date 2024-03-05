using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
	public class AgentService : IAgentService
	{
		private readonly IRepository repository;

        public AgentService(IRepository _reopsitory)
        {
			repository = _reopsitory;
        }

		public Task CreateAsync(string userId, string phoneNumber)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> ExistByIdAsync(string userId)
		{
			return await repository.AllReadOnly<Agent>()
				.AnyAsync(a => a.UserId == userId);
		}

		public Task<bool> UserHasRentsAsync(string userId)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
		{
			throw new NotImplementedException();
		}
	}
}
