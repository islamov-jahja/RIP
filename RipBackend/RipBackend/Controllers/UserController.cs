using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;
using RipBackend.Models.User;
using RipBackend.Services.Helpers;
using RipBackend.Persistence.Repositories.UserRepository;
using System.ComponentModel.DataAnnotations;

namespace RipBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // POST api/values
        [HttpPost("login")]
        public ActionResult<string> Post([FromBody] LoginForm loginForm)
        {
            if (ModelState.IsValid)
            {
                var userRep = new UserReposotory();
                loginForm.password = Privacy.GetHashedPassword(loginForm.password);

                if(!userRep.IsSet(loginForm)){
                    return BadRequest("неверный логин или пароль");
                }

                var user = userRep.GetUser(loginForm);

                var response = new {
                    access_token = Privacy.GetToken(user),
                    user_name = user.name
                };

                return new JsonResult(response);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                var userRep = new UserReposotory();
                user.isAdmin = false;
                user.password = Privacy.GetHashedPassword(user.password);
                if (!userRep.IsSet(user.email))
                {
                    userRep.Add(user);
                }
                else
                {
                    return BadRequest("Такой пользователь сушествует");
                }
                
                return Ok();
            }else
            {
                return BadRequest();
            }
        }
    }
}