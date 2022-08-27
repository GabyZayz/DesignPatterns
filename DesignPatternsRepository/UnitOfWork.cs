using System;
using DesignPatters.Models;

namespace DesignPatternsRepository
{
    public class UnitOfWork: IUnitOfWork
    {
        private DesignPatternsContext _context;

        public IRepository<Beer> _beers;
        public IRepository<Brand> _brands;


        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ? _beers = new Repository<Beer>(_context) : _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ? _brands = new Repository<Brand>(_context) : _brands;
            }
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UnitOfWork(DesignPatternsContext context)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}


