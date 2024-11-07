using MediatR;
using MyApp.Core.Interfaces;
using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Queries
{
    public record GetCoindeskDataQuery() : IRequest<CoindeskData>;

    public class GetCoindeskDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoindeskDataQuery,CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoindeskDataQuery request, CancellationToken cancel)
        {
            return await externalVendorRepository.GetData();
    }

    }
}


