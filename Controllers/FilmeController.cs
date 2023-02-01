using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController  : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();
        private static int Id = 1;

        [HttpPost]
        public void AdicionarFilme([FromBody]Filme filme)
        {
            filme.Id = Id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperaFilmePorId(int id)
        {
           return filmes.FirstOrDefault(filme => filme.Id == id);
        }

    }
}
