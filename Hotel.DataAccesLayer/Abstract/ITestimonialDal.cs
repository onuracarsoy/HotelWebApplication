using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccesLayer.Abstract
{
    public interface ITestimonialDal : IGenericDal<Testimonial>
    {
        public int GetTestimonialCount();
    }
}
