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
    public class EfBookingDal : GenericReporsitory<Booking>, IBookingDal
    {


        public EfBookingDal(Context context) : base(context)
        {

        }
        public int GetBookingCount()
        {
            var context = new Context();
            return context.Bookings.Count();
        }


        public int ConfirmBookingCount()
        {
            var context = new Context();
            return context.Bookings.Where(x => x.Status == "Onaylandı").Count();
        }

        public int DeniedBookingCount()
        {
            var context = new Context();
            return context.Bookings.Where(x => x.Status == "Onaylanmadı").Count();
        }

        public int WaitBookingCount()
        {
            var context = new Context();
            return context.Bookings.Where(x => x.Status == "Onay Bekliyor").Count();
        }
    }
}
