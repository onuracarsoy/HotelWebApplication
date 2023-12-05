using Hotel.BussinesLayer.Abstract;
using Hotel.DataAccesLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BussinesLayer.Concrete
{
    public class BookingManager : IBookingService
    {

        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public int TConfirmBookingCount()
        {
           return _bookingDal.ConfirmBookingCount();
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public int TDeniedBookingCount()
        {
            return _bookingDal.DeniedBookingCount();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }

        public int TWaitBookingCount()
        {
            return _bookingDal.WaitBookingCount();
        }
    }
}
