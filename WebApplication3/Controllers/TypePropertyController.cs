using Domain.domain;
using infrastucture.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/typeProperty")]

    public class TypePropertyController : ControllerBase
    {
     
        private readonly IRepository<TypeProperty> _TypePropertyRepository;

        
        public TypePropertyController(IRepository<TypeProperty> TypePropertyRepository) {
            _TypePropertyRepository = TypePropertyRepository; 
        }

        [HttpGet]
        public ActionResult<List<TypeProperty>> GetAll() {
            return _TypePropertyRepository.GetAll();
        }

        [HttpPost]
        public ActionResult<string> Save(TypeProperty entity) {
            try
            {
                _TypePropertyRepository.Save(entity);
                return Ok("Created property");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<TypeProperty> GetById(int id) {
            return _TypePropertyRepository.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id) {
            var entity = _TypePropertyRepository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _TypePropertyRepository.Delete(entity);
            return Ok("TypeProperty del");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, TypeProperty entity) {
            var dbEntity = _TypePropertyRepository.GetById(id);
            if (dbEntity == null)
            {
                return NotFound();
            }
            dbEntity.title = entity.title;
            _TypePropertyRepository.Update(dbEntity);
            return Ok("TypeProperty del");
        }
    }
}
