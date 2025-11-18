using BackEndEndpoint.Dtos;
using BackEndEndpoint.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndEndpoint.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        private readonly Repository<Wines> _wineRepo;

        public WineController(Repository<Wines> wineRepo)
        {
            _wineRepo = wineRepo;
        }
        // POST: api/wine
        [HttpPost]
        public Wines Create([FromBody] WinesCreateDto dto)
        {
            var wine = new Wines
            {
                Id = Guid.NewGuid().ToString(),
                Name = dto.Name,
                Type = dto.Type,
                Year = dto.Year,
                Price = dto.Price,
            };

            _wineRepo.Add(wine);
            return wine;
        }

        // GET: api/wine
        [HttpGet]
        public IEnumerable<Wines> GetAll()
        {
            return _wineRepo.GetAll().ToList();
        }


        // DELETE: api/wine/{id}
        [HttpDelete("{id}")]
        public bool DeleteById(string id)
        {
            var entity = _wineRepo.GetAll().FirstOrDefault(e => e.Id == id);
            if (entity == null) return false;

            _wineRepo.DeleteById(id);
            return true;
            //
        }
    }
}
