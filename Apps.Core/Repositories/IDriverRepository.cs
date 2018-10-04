using System;
using System.Collections.Generic;
using Apps.Core.Domain;

namespace Apps.Core.Repositories
{
    public interface IDriverRepository
    {
         Driver Get(Guid userId);
         IEnumerable<Driver> GetAll();
         void Add(Driver driver);
         void Update(Driver driver);
    }
}