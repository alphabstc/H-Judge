﻿using System.Threading.Tasks;
using hjudge.WebHost.Data;
using hjudge.WebHost.Data.Identity;
using hjudge.WebHost.Middlewares;
using hjudge.WebHost.Models;
using hjudge.WebHost.Models.Judge;
using hjudge.WebHost.Services;
using Microsoft.AspNetCore.Mvc;

namespace hjudge.WebHost.Controllers
{
    [Route("judge")]
    [AutoValidateAntiforgeryToken]
    [ApiController]
    public class JudgeController : ControllerBase
    {
        private readonly IJudgeService judgeService;
        private readonly CachedUserManager<UserInfo> userManager;

        public JudgeController(IJudgeService judgeService, CachedUserManager<UserInfo> userManager)
        {
            this.judgeService = judgeService;
            this.userManager = userManager;
        }


        [PrivilegeAuthentication.RequireSignedIn]
        [HttpPost]
        [Route("submit")]
        public async Task SubmitSolution([FromBody]SubmitModel model)
        {
            var userId = userManager.GetUserId(User);
            //TODO: validate

            await judgeService.QueueJudgeAsync(new Judge
            {
                Content = model.Content,
                Language = model.Language,
                ProblemId = model.ProblemId,
                ContestId = model.ContestId == 0 ? null : (int?)model.ContestId,
                GroupId = model.GroupId == 0 ? null : (int?)model.GroupId,
                UserId = userId
            });
        }
    }
}
