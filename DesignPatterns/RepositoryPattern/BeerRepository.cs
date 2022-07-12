using System;
using DesignPatterns.RepositoryPattern;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Models
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;

        public BeerRepository ( DesignPatternsContext context)
        {
            _context = context;
        }
        public void Add(Beer data) =>  _context.Beers.Add( data);


        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public void Get(int id) => _context.Beers.Find(id);
       

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;
       
    }
}

