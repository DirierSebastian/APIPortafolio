using APIPortafolio.Data;
using APIPortafolio.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace APIPortafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumController : ControllerBase
    {
        private readonly IMongoCollection<Curriculum> _curriculum;
        public CurriculumController(MongoDbService mongoDbService)
        {
            _curriculum = mongoDbService.Database?.GetCollection<Curriculum>("Curriculum");
        }
        [HttpGet]
        public async Task<IEnumerable<Curriculum>> get()
        {
            return await _curriculum.Find(FilterDefinition<Curriculum>.Empty).ToListAsync();
            
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Curriculum>> GetById(string id)
        {
            var filter = Builders<Curriculum>.Filter.Eq(x => x.Id, id);
            var customer = _curriculum.Find(filter).FirstOrDefault();
            return customer is not null ? Ok(customer) : NotFound();
        }
    }
}
