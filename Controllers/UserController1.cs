using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion_final.Models;
using SistemaGestion_final.Repository;

namespace SistemaGestion_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController1 : ControllerBase
    {
        [HttpGet("{usuario}/{passw}")]
        public User Login(string usuario, string passw)
        {
            return UserHandler.Login(usuario, passw);
        }

        [HttpPost]
        public void Register(User user)
        {
            UserHandler.Register(user);
        }

        [HttpPut]
        public void ModificarUsuario(User user)
        {
            UserHandler.UpdateUser(user);
        }

        [HttpGet("{usuario}")]
        public User traerUsuario(string usuario)
        {
            return UserHandler.GetUser(usuario);
        }
    }
}
