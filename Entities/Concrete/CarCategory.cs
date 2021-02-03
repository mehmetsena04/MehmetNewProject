using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{//çıplak class kalmasın
   public  class CarCategory:IEntity
    {
        public int CarCategoryId { get; set; }
        public string CarCategoryName { get; set; }
    }
}
