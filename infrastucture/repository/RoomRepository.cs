using Domain.domain;
using infrastucture.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastucture.repository
{
    public class RoomRepository : IRepository<Room>
    {
        private ApplicationContext _context;
        public RoomRepository(ApplicationContext context) {
            _context = context;
        
        }
        public void Delete(Room t)
        {
            _context.Set<Room>().Remove(t);
            _context.SaveChanges();
        }

        public List<Room> GetAll()
        {
            return _context.room.ToList();
        }

        public Room GetById(int id)
        {
            return _context.room
                 .AsNoTracking()
                 .SingleOrDefault(s => s.id == id);
        }

        public void Save(Room entity)
        {
            _context.Set<Room>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Room entity)
        {
            _context.Set<Room>().Update(entity);
            _context.SaveChanges();
        }
    }
}
