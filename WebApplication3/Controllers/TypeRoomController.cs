using Domain.domain;
using infrastucture.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/typeRoom")]

    public class TypeRoomController : ControllerBase
    {
     
        private readonly IRepository<TypeRoom> _TypeRoomRepository;

        
        public TypeRoomController(IRepository<TypeRoom> TypeRoomRepository) {
            _TypeRoomRepository = TypeRoomRepository; 
        }

        [HttpGet]
        public ActionResult<List<TypeRoom>> GetAll() {
            return _TypeRoomRepository.GetAll();
        }

        [HttpPost]
        public ActionResult<string> Save(TypeRoom entity) {
            try
            {
                _TypeRoomRepository.Save(entity);
                return Ok("Created property");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<TypeRoom> GetById(int id) {
            return _TypeRoomRepository.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id) {
            var entity = _TypeRoomRepository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _TypeRoomRepository.Delete(entity);
            return Ok("TypeRoom del");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, TypeRoom entity) {
            var dbEntity = _TypeRoomRepository.GetById(id);
            if (dbEntity == null)
            {
                return NotFound();
            }
            dbEntity.description = entity.description;
            dbEntity.name = entity.name;

            _TypeRoomRepository.Update(dbEntity);
            return Ok("TypeRoom del");
        }

       

    }
}
