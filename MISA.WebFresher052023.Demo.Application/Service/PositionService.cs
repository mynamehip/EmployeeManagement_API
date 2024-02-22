using AutoMapper;
using MISA.WebFresher052023.Demo.Application.Dto;
using MISA.WebFresher052023.Demo.Application.Interface;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Entity;
using MISA.WebFresher052023.Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public class PositionService : BaseReadOnlyService<Position, Position, PositionDto>, IPositionService
    {
        public PositionService(IPositionRepository positionRepository, IMapper mapper) : base(positionRepository, mapper)
        {
        }
    }
}
