using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Services.Models;

namespace Services.Cars.Commands
{
    public class CreateCarCommand : IRequest<ServiceResult<Car>>
    {
        public string Name { get; set; }
    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, ServiceResult<Car>>
    {
        public Task<ServiceResult<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            // create a car
            throw new NotImplementedException();
        }
    }
}