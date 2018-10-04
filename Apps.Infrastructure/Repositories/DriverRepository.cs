using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Core.Domain;
using Apps.Core.Repositories;

namespace Apps.Infrastructure.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();
        public void Add(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Driver Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Driver> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}