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
    public class EfRoomDal: GenericReporsitory<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {

        }

        public int GetRoomCount()
        {
            var context = new Context();
            return context.Rooms.Count();

        }

    }
}
