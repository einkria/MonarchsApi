using System.Collections.Generic;

using MonarchsApi.Models;

namespace MonarchsApi.Services
{
    public interface IMonarchsService
    {
        /*
         * Get a list of Monarch objects.
         */
        IList<Monarch> GetMonarchs();
    }
}
