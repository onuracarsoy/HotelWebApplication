using Hotel.DataAccesLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BussinesLayer.Abstract
{
    public interface ITestimonialService:IGenericService<Testimonial>   
    {
        public int TGetTestimonialCount();
    }
}
