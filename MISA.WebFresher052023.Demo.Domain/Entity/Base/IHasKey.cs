using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain.Entity.Base
{
    public interface IHasKey
    {
        Guid GetKey();
    }
}
