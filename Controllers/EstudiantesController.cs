using APIESTUDIANTES.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIESTUDIANTES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : Controller
    {
        private static List<Estudiante> _estudiantes = new List<Estudiante>
        {
            new Estudiante
            {
                Id = 1,
                Nombre ="Josua",
                Curso ="9No 'E'"
            },
             new Estudiante
            {
                Id = 2,
                Nombre ="Gustavo",
                Curso ="1ero bachillerato 'X'"
            },
              new Estudiante
            {
                Id = 3,
                Nombre ="Samuel",
                Curso ="2do bachillerato 'A'"
            },
        };

        [HttpGet]

        public IEnumerable<Estudiante> GetAllEstudiantes()
        {
            return _estudiantes;

        }
    }
}
