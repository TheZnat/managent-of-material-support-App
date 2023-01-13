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
    public class TypeRoomRepository : IRepository<TypeRoom>
    {
        private ApplicationContext _context;
        public TypeRoomRepository(ApplicationContext context) {
            _context = context;
        
        }
        public void Delete(TypeRoom t)
        {
            _context.Set<TypeRoom>().Remove(t);
            _context.SaveChanges();
        }

        public List<TypeRoom> GetAll()
        {
            return _context.typeRoom.ToList();
        }

        public TypeRoom GetById(int id)
        {
            return _context.typeRoom
                 .AsNoTracking()
                 .SingleOrDefault(s => s.id == id);
        }

        public void Save(TypeRoom entity)
        {
            _context.Set<TypeRoom>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TypeRoom entity)
        {
            _context.Set<TypeRoom>().Update(entity);
            _context.SaveChanges();
        }
    }
}
