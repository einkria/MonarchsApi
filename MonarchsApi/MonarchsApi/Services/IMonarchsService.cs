using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonarchsApi.Models;

namespace MonarchsApi.Services
{
    public interface IMonarchsService
    {
        IList<Monarch> GetMonarchs();
    }
}
