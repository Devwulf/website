﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Momentum.Auth.Api.Controllers
{
    [Route("auth/twitter")]
    [ApiController]
    public class TwitterController : Controller
    {
        [Authorize(AuthenticationSchemes = "Twitter", Policy = "RequireNothing")]
        [HttpGet]
        public IActionResult SignIn()
        {
            if (User.Identity == null ||
                !User.Identity.IsAuthenticated)
                return Challenge("Twitter");

            // Twitter auth is opened in a new window,
            // and the client waits till the window is closed before continuing
            return Ok("<script>window.close();</script>");
        }
    }
}