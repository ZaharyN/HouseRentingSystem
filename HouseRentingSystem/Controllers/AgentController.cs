using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Extensions;
using HouseRentingSystem.Models.Agents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }
        public async Task<IActionResult> Become()
        {
            if(await agentService.ExistByIdAsync(User.Id()))
            {
                return BadRequest();
            }
            var model = new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Beocome(BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
