using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<CoindeskData> GetData();
        Task<JokeModel> GetJoke();

    }
}
