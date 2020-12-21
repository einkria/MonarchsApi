using System;

namespace MonarchsApi.Repositories
{
    public interface IMonarchsRepository
    {
        /*
         * Get a string representation of a list of Monarchs.
         */
        String GetMonarchs();
    }
}
