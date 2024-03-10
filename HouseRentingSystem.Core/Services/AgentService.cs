﻿using HouseRentingSystem.Core.Contracts;
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
		
		public async Task CreateAsync(string userId, string phoneNumber)
		{
			Agent agent = new()
			{
				UserId = userId,
				PhoneNumber = phoneNumber
			};

			await repository.AddAsync(agent);
			await repository.SaveChangesAsync();
		}

		public async Task<bool> ExistByIdAsync(string userId)
		{
			return await repository.AllReadOnly<Agent>()
				.AnyAsync(a => a.UserId == userId);
		}

		public async Task<bool> UserHasRentsAsync(string userId)
		{
			return await repository.AllReadOnly<House>()
				.AnyAsync(h => h.RenterId == userId);
		}

		public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
		{
			return await repository.AllReadOnly<Agent>()
				.AnyAsync(a => a.PhoneNumber == phoneNumber);
			
		}
	}
}
