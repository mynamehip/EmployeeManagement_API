using MISA.WebFresher052023.Demo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain.Interface
{
    public interface IPositionRepository : IReadOnlyRepository<Position, Position>
    {
    }
}
