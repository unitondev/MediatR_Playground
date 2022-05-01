using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Services.Models;

namespace Services.Cars.Queries
{
    // trigger
    public class GetAllCarsQuery : BaseRequest, IRequest<IEnumerable<Car>> { }

    // handler
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        public Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult<IEnumerable<Car>>(new[]
            {
                new Car() {Name = $"Mercedes {request.UserId}"},
                new Car() {Name = "BMW"}
            });
        }
    }
}