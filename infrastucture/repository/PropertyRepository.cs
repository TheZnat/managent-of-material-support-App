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
    public class PropertyRepository : IRepository<Property>
    {
        private ApplicationContext _context;
        public PropertyRepository(ApplicationContext context) {
            _context = context;
        
        }
        public void Delete(Property t)
        {
            _context.Set<Property>().Remove(t);
            _context.SaveChanges();
        }

        public List<Property> GetAll()
        {
            return _context.property.ToList();
        }

        public Property GetById(int id)
        {
            return _context.property
                 .AsNoTracking()
                 .SingleOrDefault(s => s.id == id);
        }

        public void Save(Property entity)
        {
            _context.Set<Property>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Property entity)
        {
            _context.Set<Property>().Update(entity);
            _context.SaveChanges();
        }
    }
}
