using Hotel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BussinesLayer.Abstract
{
    public interface IStaffService: IGenericService<Staff>
    {
        public int TGetStaffCount(); 
    }
}
