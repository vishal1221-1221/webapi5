using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserLogin.Database;
using UserLogin.Database.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

      
        public List<UserModel> usersList = new List<UserModel>()
        {
            new UserModel
            {
                UserName="gopal",
                Password="gopal"
            },
            new UserModel
            {
                UserName="Vishal",
                Password="Vishal123"
            },
            new UserModel
            {
                UserName="Ram",
                Password="Ram123"
            }
        };
        

        // [System.Web.Http.Route("Login")]

        [HttpPost]
        public IActionResult userLogin(UserModel login)
        {

            //var log = ln.Login(login.UserName, login.Password);
            //var log = db.users.Where(x => x.UserName.Equals(login.UserName) && x.Password.Equals(login.Password)).FirstOrDefault();
            var log = usersList.Find(x => x.UserName == login.UserName && x.Password == login.Password);
            if (log == null)
            {
                return Ok(new { Status = "Invalid", Message = "Invalid User" });
            }
            else
            {



                return Ok(new { Status = "Success", Message = "Login Success",});
            }
        }

    }
}
