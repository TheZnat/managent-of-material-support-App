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
    public class TypePropertyRepository : IRepository<TypeProperty>
    {
        private ApplicationContext _context;
        public TypePropertyRepository(ApplicationContext context) {
            _context = context;
        
        }
        public void Delete(TypeProperty t)
        {
            _context.Set<TypeProperty>().Remove(t);
            _context.SaveChanges();
        }

        public List<TypeProperty> GetAll()
        {
            return _context.typeProperty.ToList();
        }

        public TypeProperty GetById(int id)
        {
            return _context.typeProperty
                 .AsNoTracking()
                 .SingleOrDefault(s => s.id == id);
        }

        public void Save(TypeProperty entity)
        {
            _context.Set<TypeProperty>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TypeProperty entity)
        {
            _context.Set<TypeProperty>().Update(entity);
            _context.SaveChanges();
        }
    }
}
