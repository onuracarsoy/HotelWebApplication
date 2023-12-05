using Hotel.DataAccesLayer.Abstract;
using Hotel.DataAccesLayer.Concrete;
using Hotel.DataAccesLayer.Repositories;
using Hotel.EntityLayer.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccesLayer.EntityFramework
{
    public class EfContactDal : GenericReporsitory<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
         
        }
    }
}
