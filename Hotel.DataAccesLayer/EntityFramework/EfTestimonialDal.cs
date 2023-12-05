using Hotel.DataAccesLayer.Abstract;
using Hotel.DataAccesLayer.Concrete;
using Hotel.DataAccesLayer.Repositories;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccesLayer.EntityFramework
{
    public class EfTestimonialDal : GenericReporsitory<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {

        }

        public int GetTestimonialCount()
        {
            var context = new Context();
            return context.Testimonials.Count();

        }

        
    }
}
