using Domain.domain;
using infrastucture.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/propertyController")]

    public class PropertyController : ControllerBase
    {
     
        private readonly IRepository<Property> _PropertyRepository;

        
        public PropertyController(IRepository<Property> PropertyRepository) {
            _PropertyRepository = PropertyRepository; 
        }

        [HttpGet]
        public ActionResult<List<Property>> GetAll() {
            return _PropertyRepository.GetAll();
        }

        [HttpPost]
        public ActionResult<string> Save(Property entity) {
            try
            {
                _PropertyRepository.Save(entity);
                return Ok("Created property");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Property> GetById(int id) {
            return _PropertyRepository.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id) {
            var entity = _PropertyRepository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _PropertyRepository.Delete(entity);
            return Ok("Property del");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, Property entity) {
            var dbEntity = _PropertyRepository.GetById(id);
            if (dbEntity == null)
            {
                return NotFound();
            }
            dbEntity.description = entity.description;
            dbEntity.technical_specifi = entity.technical_specifi;
            dbEntity.room_id = entity.room_id;
            dbEntity.type_property_id = entity.type_property_id;

            _PropertyRepository.Update(dbEntity);
            return Ok("Property del");
        }

       

    }
}
