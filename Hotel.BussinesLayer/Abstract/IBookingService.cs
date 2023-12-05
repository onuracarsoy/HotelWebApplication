using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BussinesLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        public int TGetBookingCount();
        public int TConfirmBookingCount();
        public int TDeniedBookingCount();
        public int TWaitBookingCount();
    }
}
