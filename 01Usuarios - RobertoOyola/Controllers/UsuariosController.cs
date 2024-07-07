using _01Usuarios___RobertoOyola.Comunes;
using _01Usuarios___RobertoOyola.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _01Usuarios___RobertoOyola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // GET: api/<UsuariosController>
        [HttpGet]
        public List<Usuario> Get()
        {
            return ConexionBD.GetUsuarios();
        }

        


        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return ConexionBD.GetUsuarios(id);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public void Post([FromBody] Usuario ObjUsuario)
        {
            ConexionBD.PostUsuario(ObjUsuario);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{usuarioModificacion}")]
        public void Put(int usuarioModificacion, [FromBody] Usuario objUsuario)
        {
            ConexionBD.PutUsuario(usuarioModificacion, objUsuario);
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{idUsuario}/{idUsuarioModificacion}")]
        public void Delete(int idUsuario,int idUsuarioModificacion)
        {
            ConexionBD.DeleteUsuario(idUsuario, idUsuarioModificacion);
        }
    }
}
