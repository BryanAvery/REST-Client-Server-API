using Microsoft.AspNetCore.Mvc;
using System;

namespace ServerAPI
{
    [Route("[controller]")]
    public class PasswordController : Controller
    {
        [HttpGet]
        public PasswordResponse Get()
        {
            return new PasswordResponse
            {
                Password = Guid.NewGuid().ToString().Substring(0, 6) + Guid.NewGuid().ToString().Substring(0, 6),
                ApiVersion = "1.0",
                ApiServer = Environment.MachineName
            };
        }
    }
}