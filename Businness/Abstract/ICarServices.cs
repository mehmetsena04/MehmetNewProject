using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
   public interface ICarServices
    {
        List<Car> GetAll();
    }
}
