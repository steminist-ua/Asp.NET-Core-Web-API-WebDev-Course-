using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private FilmsContext _filmsContext;
        public GenreController(FilmsContext filmsContext)
        {
            _filmsContext = filmsContext;
        }

        // GET: api/<GenreController>
        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            //return new string[] { "value1", "value2" };
            return _filmsContext.Genres;
        }

        // GET api/<GenreController>/5
        [HttpGet("{id}")]
        public Genre Get(int id)
        {
            //return "value";
            return _filmsContext.Genres.FirstOrDefault(s => s.Id == id);
        }

        // POST api/<GenreController>
        [HttpPost]
        public void Post([FromBody] Genre genre)
        {
            _filmsContext.Genres.Add(genre);
            _filmsContext.SaveChanges();
        }

        // PUT api/<GenreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genre genre)
        {
            var putGenre = _filmsContext.Genres.FirstOrDefault(s => s.Id == id);
            if (putGenre != null)
            {
                _filmsContext.Entry<Genre>(putGenre).CurrentValues.SetValues(genre);
                _filmsContext.SaveChanges();
            }
        }

        // DELETE api/<GenreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var delGenre = _filmsContext.Genres.FirstOrDefault(s => s.Id == id);
            if (delGenre != null)
            {
                _filmsContext.Genres.Remove(delGenre);
                _filmsContext.SaveChanges();
            }
        }
    }
}
