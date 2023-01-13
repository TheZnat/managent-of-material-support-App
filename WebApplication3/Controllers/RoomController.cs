using Domain.domain;
using infrastucture.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/room")]

    public class RoomController : ControllerBase
    {
     
        private readonly IRepository<Room> _RoomRepository;

        
        public RoomController(IRepository<Room> RoomRepository) {
            _RoomRepository = RoomRepository; 
        }

        [HttpGet]
        public ActionResult<List<Room>> GetAll() {
            return _RoomRepository.GetAll();
        }

        [HttpPost]
        public ActionResult<string> Save(Room entity) {
            try
            {
                _RoomRepository.Save(entity);
                return Ok("Created property");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Room> GetById(int id) {
            return _RoomRepository.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id) {
            var entity = _RoomRepository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _RoomRepository.Delete(entity);
            return Ok("Room del");
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, Room entity) {
            var dbEntity = _RoomRepository.GetById(id);
            if (dbEntity == null)
            {
                return NotFound();
            }
            dbEntity.type_room_id = entity.type_room_id;

            _RoomRepository.Update(dbEntity);
            return Ok("Room del");
        }

       

    }
}
